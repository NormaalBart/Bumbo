﻿using System.Globalization;
using System.Text.Json.Nodes;
using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.CAO.Rules;
using BumboServices.Interface;
using BumboServices.Roster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager;

[Authorize(Roles = "Manager")]
public class RosterManagerController : Controller
{
    private readonly IBranchRepository _branchRepository;
    private readonly ICAOService _caoService;
    private readonly IDepartmentsRepository _departmentsRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IPrognosesService _prognosesServices;
    private readonly IPrognosisRepository _prognosisRepository;
    private readonly IRosterService _rosterService;
    private readonly IPlannedShiftsRepository _shiftRepository;
    private readonly IUnavailableMomentsRepository _unavailableRepository;
    private readonly UserManager<Employee> _userManager;
    private readonly IWorkedShiftRepository _workedShiftRepository;

    public RosterManagerController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee,
        IPrognosisRepository prognosis, IPlannedShiftsRepository plannedShifts,
        IUnavailableMomentsRepository unavailableMoments, IPrognosesService prognosesService,
        IDepartmentsRepository departments, IBranchRepository branches, ICAOService caoService,
        IRosterService rosterService, IWorkedShiftRepository workedShiftRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _employeeRepository = employee;
        _prognosisRepository = prognosis;
        _shiftRepository = plannedShifts;
        _unavailableRepository = unavailableMoments;
        _prognosesServices = prognosesService;
        _departmentsRepository = departments;
        _branchRepository = branches;
        _caoService = caoService;
        _rosterService = rosterService;
        _workedShiftRepository = workedShiftRepository;
    }

    public async Task<IActionResult> IndexAsync(string? dateInput, string? errormessage, int copiedShifts = 0)
    {
        dateInput ??= DateTime.Today.ToString(CultureInfo.CurrentCulture);

        var date = DateTime.Parse(dateInput).Date;
        var viewModel = new RosterDayViewModel
        {
            Date = date
        };

        var manager = await _userManager.GetUserAsync(User);

        var employeeList =
            _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(
                _employeeRepository.GetAllEmployeesOfBranch(manager.DefaultBranchId ?? -1)).ToList();
        
        // Add external employees that are rostered in that day
        // employeeList.
        employeeList.AddRange(_mapper.Map<IEnumerable<EmployeeRosterViewModel>>(_shiftRepository.GetAllShiftsDay(manager.DefaultBranchId ?? -1, date.ToDateOnly())
            .GroupBy(s=>s.Employee)
            .Where(s=> employeeList.All(e => e.Id != s.Key.Id))
            .Select(s=>s.Key)
            .ToList()));
        
        viewModel.Date = date;
        viewModel.CopyFrom = date;
        viewModel.CopyTo = date.AddDays(7);
        viewModel.CopiedShifts = copiedShifts;

        var openAndCloseTimes =
            _branchRepository.GetOpenAndCloseTimes(manager.DefaultBranchId ?? -1, date.ToDateOnly());
        // TableMinHour and TableMaxHour are for the width of the table. 
        viewModel.OpenTime = openAndCloseTimes.Item1;
        viewModel.CloseTime = openAndCloseTimes.Item2;
        viewModel.TableMinHour = viewModel.OpenTime.Hour - 1;
        viewModel.TableMaxHour = viewModel.CloseTime.Hour + 1;

        // Start CAO
        // Filter shifts to only display that of today
        // Setup invalid shifts
        var invalidShifts = InvalidPlannedShiftsFollowigCAO(date, manager.DefaultBranchId ?? -1);
        viewModel.InvalidShifts = invalidShifts;

        foreach (var emp in employeeList)
        {
            emp.PlannedShifts = _mapper
                .Map<IEnumerable<ShiftViewModel>>(
                    _shiftRepository.GetShiftsOnDayForEmployeeOnDate(date, emp.Id, manager.DefaultBranchId ?? -1))
                .ToList();
            if (emp.PlannedShifts.Count > 0)
            {
                emp.PlannedShifts.ForEach(shift =>
                {
                    // Add invalid shift validated rules to the viewmodel.
                    shift.ViolatedRules.AddRange(invalidShifts.Where(s =>
                            s.Value.Any(s => s.Id == shift.Id))
                        .Select(s => s.Key));

                    // If the shift is outside of the opening and closing times we use the max so they don't go offscreen.
                    // Min and max get a 1 offset to make it look a little better. 
                    if (shift.EndTime.Hour > viewModel.TableMaxHour) viewModel.TableMaxHour = shift.EndTime.Hour + 1;
                    if (shift.StartTime.Hour < viewModel.TableMinHour)
                        viewModel.TableMinHour = shift.StartTime.Hour - 1;
                });

                viewModel.RosteredEmployees.Add(emp);
            }

            viewModel.AvailableEmployees.Add(emp);
        }

        // Sort by the amount of rules violated.
        viewModel.RosteredEmployees = viewModel.RosteredEmployees
            .OrderByDescending(e => e.PlannedShifts.Sum(s => s.ViolatedRules.Count)).ToList();

        viewModel.InvalidShifts = invalidShifts;

        viewModel.CassierePrognoseHours =
            Math.Ceiling(_prognosesServices.GetCashierPrognose(date, manager.DefaultBranchId ?? -1).Hours);
        viewModel.CassierePrognoseWorkers =
            _prognosesServices.GetCashierPrognose(date, manager.DefaultBranchId ?? -1).Workers;
        viewModel.StockersPrognoseHours =
            Math.Ceiling(_prognosesServices.GetStockersPrognoseHours(date, manager.DefaultBranchId ?? -1));
        viewModel.FreshPrognoseHours =
            Math.Ceiling(_prognosesServices.GetFreshPrognose(date, manager.DefaultBranchId ?? -1).Hours);
        viewModel.FreshPrognoseWorkers =
            _prognosesServices.GetFreshPrognose(date, manager.DefaultBranchId ?? -1).Workers;

        var shiftsOnDay = _mapper.Map<IEnumerable<ShiftViewModel>>(_prognosisRepository.GetShiftsOnDayByDate(date))
            .ToList();
        viewModel.PrognosisDayId = _prognosisRepository.GetIdByDate(date);

        viewModel.SelectedStartTime = viewModel.Date.AddHours(8);
        viewModel.SelectedEndTime = viewModel.Date.AddHours(16);

        viewModel.Departments = new List<DepartmentRosterViewModel>();
        foreach (var dep in _departmentsRepository.GetList().ToList())
            viewModel.Departments.Add(new DepartmentRosterViewModel {Id = dep.Id, DepartmentName = dep.DepartmentName});

        if (!string.IsNullOrEmpty(errormessage)) viewModel.ErrorMessage = errormessage;

        if (viewModel.TableMinHour is < 0 or > 24) viewModel.TableMinHour = 0;
        if (viewModel.TableMaxHour is < 0 or > 24) viewModel.TableMinHour = 24;

        return View(viewModel);
    }

    public async Task<IActionResult> Overview(string? dateInput)
    {
        var employee = await _userManager.GetUserAsync(User);
        var date = DateTime.Now;
        if (dateInput != null) date = DateTime.Parse(dateInput).Date;

        var overviewList = new OverviewList();

        // loops through month
        for (var i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
        {
            var item = new OverviewItem();
            item.Date = new DateTime(date.Year, date.Month, i);
            // gets the sum of the prognosis hours of departments
            item.PrognosisHours = _prognosesServices.GetCashierPrognose(item.Date, employee.DefaultBranchId ?? -1).Hours
                                  + _prognosesServices.GetStockersPrognoseHours(item.Date,
                                      employee.DefaultBranchId ?? -1)
                                  + _prognosesServices.GetFreshPrognose(item.Date, employee.DefaultBranchId ?? -1)
                                      .Hours;
            item.PrognosisHours = Math.Round(item.PrognosisHours);
            if (item.PrognosisHours < 0) item.PrognosisHours = 0;
            // gets the sum of total planned hours on day
            item.RosteredHours = _shiftRepository.GetTotalHoursPlannedOnDay(employee.DefaultBranchId ?? -1, item.Date);

            overviewList.Days.Add(item);
        }

        overviewList.Date = date;

        return View(overviewList);
    }

    [HttpPost]
    public IActionResult RegisterSick(int shiftId)
    {
        // Update planned shift
        var shift = _shiftRepository.Get(shiftId);
        if (shift == null) return BadRequest();

        shift.Sick = true;
        _shiftRepository.Update(shift);

        // Immediately create the worked shift as well
        var workedShift = new WorkedShift
        {
            Approved = true,
            BranchId = shift.BranchId,
            EmployeeId = shift.EmployeeId,
            StartTime = shift.StartTime,
            EndTime = shift.EndTime,
            Sick = true
        };
        _workedShiftRepository.Create(workedShift);

        return Ok();
    }

    [HttpGet]
    // Search through employees for semantic ui
    public async Task<IActionResult> SearchEmployees(string q, bool? external)
    {
        var manager = await _userManager.GetUserAsync(User);

        var users = _employeeRepository.Search(external == true ? null : manager.DefaultBranchId, q)
            .ToList();

        // Only allow employees
        users = users.Where(u => _userManager.GetRolesAsync(u).Result.Contains(RoleType.EMPLOYEE.Name)).Take(50)
            .ToList();

        // If external is false or not found, return only employees from the same branch.
        if (external is null or false)
        {
            var resp = new SemanticResultList<List<SemanticResult>>
            {
                Results = users.Select(e => new SemanticResult
                {
                    Id = e.Id,
                    Title = e.FullName(),
                    Description = e.Email
                }).ToList()
            };
            return Json(resp);
        }
        else
        {
            // Return as categorized list by branch.
            var resp = new SemanticResultList<List<SemanticResultCategory>>
            {
                Results = users.GroupBy(e => e.DefaultBranchId).Select(g => new SemanticResultCategory
                {
                    Name = _branchRepository.Get(g.Key ?? -1)?.Name ?? "onbekend",
                    Results = g.Select(e => new SemanticResult
                    {
                        Id = e.Id,
                        Title = e.FullName(),
                        Description = e.Email
                    }).ToList()
                }).ToList()
            };
            return Json(resp);
        }
    }

    [HttpPost]
    public IActionResult DeleteShift(int shiftId)
    {
        var shift = _shiftRepository.Get(shiftId);
        if (shift == null) return BadRequest();
        _shiftRepository.Delete(shift);

        // If the shift was a sick shift, try and find and delete the worked shift as well.
        var workedShift = _workedShiftRepository.Get(s =>
            s.Sick && s.EmployeeId == shift.EmployeeId && s.StartTime == shift.StartTime && s.EndTime == shift.EndTime);

        if (workedShift == null) return Ok();

        _workedShiftRepository.Delete(workedShift);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> DayHasInvalidShifts(string date)
    {
        var requestedDate = DateTime.Parse(date);
        var employee = await _userManager.GetUserAsync(User);

        // check for cAO violations
        var invalidshifts = InvalidPlannedShiftsFollowigCAO(requestedDate, employee.DefaultBranchId ?? -1);
        // if there are invalid shifts, we return true otherwise false
        return Json(invalidshifts.Count > 0);
    }

    // Will generate roster for given date
    [HttpPost]
    public async Task<IActionResult> GenerateRoster(string date)
    {
        var forDate = DateTime.Parse(date);

        var manager = await _userManager.GetUserAsync(User);

        // Get already planned shifts
        var plannedShifts = _shiftRepository.GetAllShiftsDay(manager.DefaultBranchId ?? -1, forDate.ToDateOnly());

        var error = await _rosterService.GenerateRoster(manager.DefaultBranchId ?? -1, forDate.ToDateOnly(),
            plannedShifts);

        if (error == RosterCreationResponse.Success || error == RosterCreationResponse.Incomplete)
        {
            var jsonObj = new JsonObject();
            jsonObj["incomplete"] = error == RosterCreationResponse.Incomplete;
            return Ok(Json(jsonObj));
        }

        var err = error switch
        {
            RosterCreationResponse.NoBranch => "Filiaal van medewerker is niet gevonden.",
            RosterCreationResponse.NoEmployees => "Geen medewerkers gevonden die beschikbaar zijn.",
            RosterCreationResponse.ClosedOnDay => "Winkel staat als gesloten geregistreerd op huidige dag.",
            RosterCreationResponse.AlreadyReachedPrognosis => "Prognose is al behaald!",
            RosterCreationResponse.CaoViolationsFound =>
                "CAO overtredingen gevonden, verhelp deze eerst voor het rooster aangevuld kan worden.",
            RosterCreationResponse.NoPrognoseFound =>
                "Geen prognose voor deze dag gevonden, maak deze eerst aan voor dat je automatisch het rooster kan genereren."
        };
        return BadRequest(err);
    }

    private Dictionary<ICAORule, List<PlannedShift>> InvalidPlannedShiftsFollowigCAO(DateTime day,
        int branchNr)
    {
        var allShiftsWeek = _shiftRepository.GetAllShiftsWeek(branchNr, day.ToDateOnly());
        return _caoService.VerifyPlannedShifts(allShiftsWeek, day.ToDateOnly());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateShift(string? selectedEmployeeId, int selectedDepartmentId,
        string selectedStartTime, string selectedEndTime, string date)
    {
        var plannedShift = new PlannedShift();

        // Passed start time and end time are only time values, so we add the passed date as well.
        plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour)
            .AddMinutes(DateTime.Parse(selectedStartTime).Minute);
        plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour)
            .AddMinutes(DateTime.Parse(selectedEndTime).Minute);

        if (selectedEmployeeId == null)
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "er geen medewerker geselecteerd was."});

        plannedShift.Employee = _employeeRepository.Get(selectedEmployeeId);
        plannedShift.Department = _departmentsRepository.Get(selectedDepartmentId);
        var manager = await _userManager.GetUserAsync(User);

        plannedShift.Branch = _branchRepository.Get(manager.DefaultBranchId ?? -1);

        // time is valid
        if (plannedShift.StartTime >= plannedShift.EndTime)
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen."});

        // overlapping shifts
        if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "medewerker is al ingepland for deze tijden."});

        // check availability employee
        if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime,
                plannedShift.EndTime, true))
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd."});

        var dateDt = DateTime.Parse(date);
        // First check if all shifts present follow the cao, prevent creating new shifts when cao is validated.
        var invalid = InvalidPlannedShiftsFollowigCAO(dateDt, manager.DefaultBranchId ?? -1);
        if (invalid.Count > 0)
            return RedirectToAction("Index", "RosterManager",
                new
                {
                    dateInput = date,
                    errormessage =
                        "er zijn nog CAO overtreding(en) zijn op deze dag, los deze eerst op voordat je een nieuwe dienst toe voegt."
                });

        _shiftRepository.Create(plannedShift);

        return RedirectToAction("Index", "RosterManager", new {dateInput = date});
    }

    public async Task<IActionResult> EditShift(string selectedEmployeeId, int selectedDepartmentId,
        string selectedStartTime, string selectedEndTime, string date, int selectedShiftId)
    {
        var plannedShift = _shiftRepository.GetPlannedShiftById(selectedShiftId);

        // Passed start time and end time are only time values, so we add the passed date as well.
        plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour)
            .AddMinutes(DateTime.Parse(selectedStartTime).Minute);
        plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour)
            .AddMinutes(DateTime.Parse(selectedEndTime).Minute);

        plannedShift.Department = _departmentsRepository.GetById(selectedDepartmentId);

        // time is valid
        if (plannedShift.StartTime > plannedShift.EndTime)
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen."});

        // overlapping shifts
        if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "Medewerker is al ingepland for deze tijden."});

        // check availability employee
        if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime,
                plannedShift.EndTime, false))
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd."});

        _shiftRepository.Update(plannedShift);

        return RedirectToAction("Index", "RosterManager", new {dateInput = date});
    }

    public async Task<IActionResult> CopyRoster(string date, DateTime copyFrom, DateTime copyTo)
    {
        var employee = await _userManager.GetUserAsync(User);
        var shifts = _shiftRepository.GetAllShiftsDay((int) employee.DefaultBranchId, copyFrom.ToDateOnly());
        var diff = copyTo - copyFrom;
        var numberOfCopiedShifts = 0;
        foreach (var shift in shifts)
        {
            var oldShift = _shiftRepository.GetPlannedShiftById(shift.Id);
            var newShift = new PlannedShift();
            newShift.StartTime = oldShift.StartTime + diff;
            newShift.EndTime = oldShift.EndTime + diff;
            newShift.BranchId = oldShift.BranchId;
            newShift.EmployeeId = oldShift.EmployeeId;
            newShift.DepartmentId = oldShift.DepartmentId;
            if (!_shiftRepository.ShiftOverlapsWithOtherShifts(newShift))
            {
                _shiftRepository.Create(newShift);
                numberOfCopiedShifts++;
            }
        }

        return RedirectToAction("Index", "RosterManager",
            new {dateInput = copyTo.ToString(), copiedShifts = numberOfCopiedShifts});
    }
}