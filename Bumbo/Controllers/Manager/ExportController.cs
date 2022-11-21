using System.Globalization;
using Bumbo.Models.ExportManager;
using BumboData.Enums;
using BumboData.Models;
using BumboRepositories.Repositories;
using BumboRepositories.Utils;
using BumboServices.Interface;
using BumboServices.Surcharges.SurchargeRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

[Authorize(Roles = "Manager")]
public class ExportController : Controller
{
    private readonly IWorkedShiftRepository _workedShiftRepository;
    private readonly IHourExportService _hourExportService;
    private readonly UserManager<Employee> _userManager;

    public ExportController(
        IWorkedShiftRepository workedShiftRepository,
        IHourExportService hourExportService,
        UserManager<Employee> userManager)
    {
        _workedShiftRepository = workedShiftRepository;
        _hourExportService = hourExportService;
        _userManager = userManager;
    }

    public async Task<IActionResult> Overview(string? SelectedMonth, string? SearchQuery, ExportOverviewSortingOption? SortMode = ExportOverviewSortingOption.HoursAsc)
    {
        var monthSelected = SelectedMonth == null
            ? DateTime.Now
            : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);

        var model = new ExportOverviewViewModel();
        
        var branch = (await _userManager.GetUserAsync(User)).ManagesBranchId;

        if (branch == null)
        {
            return BadRequest();
        }

        var workedShiftsInMonth =
            _workedShiftRepository.GetWorkedShiftsInMonth(branch ?? -1, monthSelected.Year, monthSelected.Month);

        // Get all months available, where at least 1 shift has taken place in.
        var selectableMonths = _workedShiftRepository.GetAllApproved(branch ?? -1)
            .Select(s => (s.StartTime.Date.Year, s.StartTime.Date.Month))
            .Distinct()
            .Select(s => new DateTime(s.Year, s.Month, 1)).ToList();

        model.SelectableMonths = selectableMonths;
        model.SelectedMonth = monthSelected;
        model.SortMode = SortMode;
        model.SearchQuery = SearchQuery;

        if (SearchQuery != null && SearchQuery.Trim().Length != 0)
        {
            workedShiftsInMonth = workedShiftsInMonth.Where(s =>
                s.Employee.FullName().Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        var prevMonth = new DateTime(monthSelected.Ticks).AddMonths(-1);

        // Get all employees that have worked in this month, and get all worked shifts for each employee.
        model.ExportOverviewListItemViewModels = workedShiftsInMonth.GroupBy(i => i.Employee)
            .Select(e => FromWorkedShifts(e.Key, e.ToList(),
                _workedShiftRepository.GetWorkedShiftsInMonth(branch ?? -1, e.Key.Id, prevMonth.Year, prevMonth.Month))).ToList();

        // Apply sorting
        model.ExportOverviewListItemViewModels = SortMode switch
        {
            ExportOverviewSortingOption.HoursAsc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.CurrentMonth.HoursWorked).Reverse().ToList(),
            ExportOverviewSortingOption.HoursDesc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.CurrentMonth.HoursWorked).ToList(),
            ExportOverviewSortingOption.SickAsc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.CurrentMonth.Surcharges[SurchargeType.Sick]).Reverse().ToList(),
            ExportOverviewSortingOption.SickDesc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.CurrentMonth.Surcharges[SurchargeType.Sick]).ToList(),
            ExportOverviewSortingOption.DifferenceAsc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.GetDifference().HoursWorked).Reverse().ToList(),
            ExportOverviewSortingOption.DifferenceDesc => model.ExportOverviewListItemViewModels
                .OrderBy(m => m.GetDifference().HoursWorked).ToList()
        };
        return View(model);
    }

    private ExportOverviewListItemViewModel FromWorkedShifts(
        Employee employee,
        List<WorkedShift> workedShiftsCurrentMonth,
        List<WorkedShift> prevMonthWorkedShifts)
    {
        return new ExportOverviewListItemViewModel()
        {
            Employee = employee,
            CurrentMonth = _hourExportService.WorkedShiftsToExportOverview(workedShiftsCurrentMonth),
            PrevMonth = _hourExportService.WorkedShiftsToExportOverview(prevMonthWorkedShifts),
        };
    }

    public async Task<IActionResult> GenerateExport(string? SelectedMonth)
    {
        var monthSelected = SelectedMonth == null
            ? DateTime.Now
            : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);
        
        // Get branch id from logged in user
        var branch = (await _userManager.GetUserAsync(User)).ManagesBranchId;

        if (branch == null)
        {
            return BadRequest();
        }        
        
        return File(_hourExportService.CsvExportForMonth(branch ?? -1, monthSelected), "text/csv", "export-" + SelectedMonth + ".csv");
    }
}