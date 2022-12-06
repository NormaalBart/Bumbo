using System.Net;
using System.Text.Json.Nodes;
using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BumboServices.CAO.Rules;
using BumboServices.Roster;
using NuGet.Protocol;

namespace Bumbo.Controllers.Manager
{
    [Authorize(Roles = "Manager")]
    public class RosterManagerController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPrognosisRepository _prognosisRepository;
        private readonly IPlannedShiftsRepository _shiftRepository;
        private readonly IUnavailableMomentsRepository _unavailableRepository;
        private readonly IPrognosesService _prognosesServices;
        private readonly IDepartmentsRepository _departmentsRepository;
        private readonly IBranchRepository _branchRepository;
        private readonly ICAOService _caoService;
        private readonly IRosterService _rosterService;

        public RosterManagerController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee,
            IPrognosisRepository prognosis, IPlannedShiftsRepository plannedShifts,
            IUnavailableMomentsRepository unavailableMoments, IPrognosesService prognosesService,
            IDepartmentsRepository departments, IBranchRepository branches, ICAOService caoService, IRosterService rosterService)
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
        }

        public async Task<IActionResult> IndexAsync(string? dateInput, string? errormessage)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }

            var date = DateTime.Parse(dateInput).Date;
            var viewModel = new RosterDayViewModel
            {
                Date = date
            };
            var manager = await _userManager.GetUserAsync(User);

            var employeeList = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(_employeeRepository.GetList(e=>e.DefaultBranchId == (manager.DefaultBranchId ?? -1)));
            
            // Start CAO
            // Filter shifts to only display that of today
            // Setup invalid shifts
            var invalidShifts = InvalidPlannedShiftsFollowigCAO(date, manager.DefaultBranchId ?? -1);
            viewModel.InvalidShifts = invalidShifts;

            foreach (var emp in employeeList)
            {
                emp.PlannedShifts = _mapper
                    .Map<IEnumerable<ShiftViewModel>>(_shiftRepository.GetShiftsOnDayForEmployeeOnDate(date, emp.Id, manager.DefaultBranchId ?? -1))
                    .ToList();
                if (emp.PlannedShifts.Count > 0)
                {
                    emp.PlannedShifts.ForEach(shift =>
                    {
                        // Add invalid shift validated rules to the viewmodel.
                        shift.ValidatesRules.AddRange(invalidShifts.Where(s =>
                                s.Value.Any(s => s.Id == shift.Id))
                            .Select(s => s.Key));
                    });

                    viewModel.RosteredEmployees.Add(emp);
                }

                viewModel.AvailableEmployees.Add(emp);
            }

            // Sort by the amount of rules violated.
            viewModel.RosteredEmployees = viewModel.RosteredEmployees
                .OrderByDescending(e => e.PlannedShifts.Sum(s => s.ValidatesRules.Count)).ToList();

            viewModel.InvalidShifts = invalidShifts;

            viewModel.CassierePrognose = _prognosesServices.GetCassierePrognose(date, manager.DefaultBranchId ?? -1 );
            viewModel.StockersPrognose = _prognosesServices.GetStockersPrognose(date, manager.DefaultBranchId ?? -1);
            viewModel.FreshPrognose = _prognosesServices.GetFreshPrognose(date, manager.DefaultBranchId ?? -1);
            var shiftsOnDay = _mapper.Map<IEnumerable<ShiftViewModel>>(_prognosisRepository.GetShiftsOnDayByDate(date))
                .ToList();
            viewModel.UpdatePrognosis(shiftsOnDay);
            viewModel.PrognosisDayId = _prognosisRepository.GetIdByDate(date);

            viewModel.SelectedStartTime = viewModel.Date.AddHours(8);
            viewModel.SelectedEndTime = viewModel.Date.AddHours(16);

            viewModel.Departments = new List<DepartmentRosterViewModel>();
            foreach (var dep in _departmentsRepository.GetList().ToList())
            {
                viewModel.Departments.Add(new DepartmentRosterViewModel()
                    {Id = dep.Id, DepartmentName = dep.DepartmentName});
            }

            if (errormessage != null)
            {
                viewModel.ErrorMessage = errormessage;
            }

            return View(viewModel);
        }


        public async Task<IActionResult> GetEmployeeList(int departmentId)
        {
            var manager = await _userManager.GetUserAsync(User);

            var employeeList = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(_employeeRepository.GetList(e => e.DefaultBranchId == (manager.DefaultBranchId ?? -1)));
            return Json(employeeList);
        }


        public async Task<IActionResult> Overview(string? dateInput)
        {
            var employee = await _userManager.GetUserAsync(User);
            DateTime date = DateTime.Now;
            if (dateInput != null)
            {
                date = DateTime.Parse(dateInput).Date;
            }

            OverviewList overviewList = new OverviewList();
            
            // loops through month
            for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
            {
                OverviewItem item = new OverviewItem();
                item.Date = new DateTime(date.Year, date.Month, i);
                // gets the sum of the prognosis hours of departments
                item.PrognosisHours = _prognosesServices.GetCassierePrognose(item.Date, employee.DefaultBranchId ?? -1)
                                        + _prognosesServices.GetStockersPrognose(item.Date, employee.DefaultBranchId ?? -1)
                                        + _prognosesServices.GetFreshPrognose(item.Date, employee.DefaultBranchId ?? -1);
                item.PrognosisHours = Math.Round(item.PrognosisHours);
                if (item.PrognosisHours < 0)
                {
                    item.PrognosisHours = 0;
                }
                // gets the sum of total planned hours on day
                item.RosteredHours = _shiftRepository.GetTotalHoursPlannedOnDay(employee.DefaultBranchId ?? -1, item.Date);

                overviewList.Days.Add(item);
            }
            overviewList.Date = date;

            return View(overviewList);
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

            var error = await _rosterService.GenerateRoster(manager.DefaultBranchId ?? -1, forDate.ToDateOnly(), plannedShifts);

            if (error == RosterCreationResponse.Succes || error == RosterCreationResponse.Incomplete)
            {
                var jsonObj = new JsonObject();
                jsonObj["incomplete"] = error == RosterCreationResponse.Incomplete;
                return Ok(Json(jsonObj));
            }
            else
            {
                var err = error switch
                {
                    RosterCreationResponse.NoBranch => "Filiaal van medewerker is niet gevonden.",
                    RosterCreationResponse.NoEmployees => "Geen medewerkers gevonden die beschikbaar zijn.",
                    RosterCreationResponse.ClosedOnDay => "Winkel staat als gesloten geregistreerd op huidige dag.",
                    RosterCreationResponse.AlreadyReachedPrognosis => "Prognose is al behaald!",
                    RosterCreationResponse.CaoViolationsFound => "CAO overtredingen gevonden, verhelp deze eerst voor het rooster aangevuld kan worden.",
                };
                return BadRequest(err);
            }
        }

        private Dictionary<ICAORule, List<PlannedShift>> InvalidPlannedShiftsFollowigCAO(DateTime day,
            int branchNr)
        {
            var allShiftsWeek = _shiftRepository.GetAllShiftsWeek(branchNr, day.ToDateOnly());
            return _caoService.VerifyPlannedShifts(allShiftsWeek, day.ToDateOnly());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShift(string selectedEmployeeId, int selectedDepartmentId,
            string selectedStartTime, string selectedEndTime, string date)
        {
            var plannedShift = new PlannedShift();

            // Passed start time and end time are only time values, so we add the passed date as well.
            plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour)
                .AddMinutes(DateTime.Parse(selectedStartTime).Minute);
            plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour)
                .AddMinutes(DateTime.Parse(selectedEndTime).Minute);

            plannedShift.Employee = _employeeRepository.Get(selectedEmployeeId);
            plannedShift.Department = _departmentsRepository.Get(selectedDepartmentId);
            var manager = await _userManager.GetUserAsync(User);

            plannedShift.Branch = _branchRepository.Get(manager.DefaultBranchId ?? -1);

            // time is valid
            if (plannedShift.StartTime > plannedShift.EndTime)
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen."});
            }

            // overlapping shifts
            if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "Medewerker is al ingepland for deze tijden."});
            }

            // check availability employee
            if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime,
                    plannedShift.EndTime))
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd."});
            }

            var dateDt = DateTime.Parse(date);
            // First check if all shifts present follow the cao, prevent creating new shifts when cao is validated.
            var invalid = InvalidPlannedShiftsFollowigCAO(dateDt, manager.DefaultBranchId ?? -1);
            if (invalid.Count > 0)
            {
                return RedirectToAction("Index", "RosterManager",
                    new
                    {
                        dateInput = date,
                        errormessage =
                            "er zijn nog CAO overtreding(en) zijn op deze dag, los deze eerst op voordat je een nieuwe shift toe voegt."
                    });
            }

            _shiftRepository.Create(plannedShift);

            return RedirectToAction("Index", "RosterManager", new {dateInput = date});
        }

        public async Task<IActionResult> EditShift(string selectedEmployeeId, int selectedDepartmentId,
            string selectedStartTime, string selectedEndTime, string date, int selectedShiftId)
        {
            PlannedShift plannedShift = _shiftRepository.GetPlannedShiftById(selectedShiftId);

            // Passed start time and end time are only time values, so we add the passed date as well.
            plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour)
                .AddMinutes(DateTime.Parse(selectedStartTime).Minute);
            plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour)
                .AddMinutes(DateTime.Parse(selectedEndTime).Minute);

            plannedShift.Department = _departmentsRepository.GetById(selectedDepartmentId);

            // time is valid
            if (plannedShift.StartTime > plannedShift.EndTime)
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen."});
            }

            // overlapping shifts
            if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "Medewerker is al ingepland for deze tijden."});
            }

            // check availability employee
            if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime,
                    plannedShift.EndTime))
            {
                return RedirectToAction("Index", "RosterManager",
                    new {dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd."});
            }

            _shiftRepository.Update(plannedShift);

            return RedirectToAction("Index", "RosterManager", new {dateInput = date});
        }
    }
}