using System.Globalization;
using Bumbo.Models.ExportManager;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboServices.Interface;
using BumboServices.Surcharges.SurchargeRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager;

[Authorize(Roles = "Manager")]
public class ExportController : Controller
{
    private readonly IWorkedShiftRepository _workedShiftRepository;
    private readonly IHourExportService _hourExportService;
    private readonly UserManager<Employee> _userManager;
    private readonly IImportService _importService;

    // Default page size for export page
    private const int _pageSize = 20;

    public ExportController(
        IWorkedShiftRepository workedShiftRepository,
        IHourExportService hourExportService,
        UserManager<Employee> userManager,
        IImportService importService)
    {
        _workedShiftRepository = workedShiftRepository;
        _hourExportService = hourExportService;
        _userManager = userManager;
        _importService = importService;
    }
    
    public async Task<IActionResult> Overview(string? SelectedMonth, string? SearchQuery, int? Page = 1)
    {
        var monthSelected = SelectedMonth == null
            ? DateTime.Now
            : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);

        var model = new ExportOverviewViewModel();

        var branch = (await _userManager.GetUserAsync(User)).DefaultBranchId;

        if (branch == null)
        {
            return BadRequest();
        }

        var workedShiftsInMonth =
            _workedShiftRepository.GetWorkedShiftsInMonth(branch, monthSelected.Year, monthSelected.Month);

        // Get all months available, where at least 1 shift has taken place in.
        var selectableMonths = _workedShiftRepository.GetAllApproved(branch)
            .Select(s => (s.StartTime.Date.Year, s.StartTime.Date.Month))
            .Distinct()
            .Select(s => new DateTime(s.Year, s.Month, 1)).OrderBy(s => s.Date).Reverse().ToList();

        model.SelectableMonths = selectableMonths;
        model.SelectedMonth = monthSelected;
        model.SearchQuery = SearchQuery;
        
        if (SearchQuery != null && SearchQuery.Trim().Length != 0)
        {
            workedShiftsInMonth = workedShiftsInMonth.Where(s =>
                s.Employee.FullName().Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        var prevMonth = new DateTime(monthSelected.Ticks).AddMonths(-1);
        
        // Apply pagination on the employees
        var employees = workedShiftsInMonth.GroupBy(i => i.Employee);

        // Pagination
        model.MaxPage = (employees.Count() + _pageSize - 1) / _pageSize;
        Page = Math.Max(1, Page ?? 1);
        Page = Math.Min(Page ?? 1, model.MaxPage);
        model.Page = Page ?? 1;
        employees = employees.Skip(_pageSize * ((Page ?? 1) - 1)).Take(_pageSize).ToList();

        // Get all employees that have worked in this month, and get all worked shifts for each employee.
        model.ExportOverviewListItemViewModels = employees
            .Select(e => FromWorkedShifts(e.Key, e.ToList(),
                _workedShiftRepository.GetWorkedShiftsInMonth(branch, e.Key.Id, prevMonth.Year, prevMonth.Month)))
            .ToList();

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
        var branch = (await _userManager.GetUserAsync(User)).DefaultBranchId;

        if (branch == null)
        {
            return BadRequest();
        }

        return File(_hourExportService.CsvExportForMonth(branch, monthSelected), "text/csv",
            "export-" + SelectedMonth + ".csv");
    }

    public async Task<IActionResult> Import(ImportViewModel? viewModel)
    {
        if (viewModel == null ||
            (viewModel.ImportEmployees == null &&
             viewModel.ImportClockEvents == null))
        {
            return View(new ImportViewModel());
        }
        // Import data

        // Only allow manger to import
        if (!User.IsInRole(RoleType.MANAGER.Name))
        {
            // TODO: Change error page
            return BadRequest();
        }

        // get manager branch id
        var manager = await _userManager.GetUserAsync(User);

        if (viewModel.ImportEmployees != null)
        {
            _importService.ImportEmployees(viewModel.ImportEmployees.OpenReadStream(), manager.DefaultBranchId);
        }

        if (viewModel.ImportClockEvents != null)
        {
            _importService.ImportClockEvents(viewModel.ImportClockEvents.OpenReadStream(),
                manager.DefaultBranchId);
        }


        return Redirect("Import");
    }
}