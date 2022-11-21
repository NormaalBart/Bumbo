using System.Globalization;
using Bumbo.Models.ExportManager;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using BumboServices.Surcharges.SurchargeRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

[Authorize(Roles = "Manager")]
public class ExportController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IBranchRepository _branchRepository;
    private readonly IWorkedShiftRepository _workedShiftRepository;
    private readonly IHourExportService _hourExportService;

    public ExportController(IEmployeeRepository employeeRepository,
        IBranchRepository branchRepository,
        IWorkedShiftRepository workedShiftRepository,
        IHourExportService hourExportService)
    {
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
        _workedShiftRepository = workedShiftRepository;
        _hourExportService = hourExportService;
    }

    public IActionResult Overview(string? SelectedMonth, string? SearchQuery, ExportOverviewSortingOption? SortMode = ExportOverviewSortingOption.HoursAsc)
    {
        var monthSelected = SelectedMonth == null
            ? DateTime.Now
            : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);

        var model = new ExportOverviewViewModel();

        var workedShiftsInMonth =
            _workedShiftRepository.GetWorkedShiftsInMonth(monthSelected.Year, monthSelected.Month);

        // Get all months available, where at least 1 shift has taken place in.
        var selectableMonths = _workedShiftRepository.GetAllApproved()
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
                _workedShiftRepository.GetWorkedShiftsInMonth(e.Key.Id, prevMonth.Year, prevMonth.Month))).ToList();

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

    public IActionResult GenerateExport(string? SelectedMonth)
    {
        var monthSelected = SelectedMonth == null
            ? DateTime.Now
            : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);

        return File(_hourExportService.CsvExportForMonth(monthSelected), "text/csv", "export-" + SelectedMonth + ".csv");
    }
}