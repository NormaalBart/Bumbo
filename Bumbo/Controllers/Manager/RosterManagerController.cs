using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboServices.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Bumbo.Controllers.Manager
{

    [Authorize(Roles = "Manager")]
    public class RosterManagerController : Controller
    {
        readonly private UserManager<Employee> _userManager;
        readonly private IMapper _mapper;
        readonly private IEmployeeRepository _employeeRepository;
        readonly private IPrognosisRepository _prognosisRepository;
        readonly private IPlannedShiftsRepository _shiftRepository;
        readonly private IUnavailableMomentsRepository _unavailableRepository;
        readonly private IPrognosesService _prognosesServices;
        readonly private IDepartmentsRepository _departmentsRepository;
        readonly private IBranchRepository _branchRepository;
        public RosterManagerController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee, IPrognosisRepository prognosis, IPlannedShiftsRepository plannedShifts, IUnavailableMomentsRepository unavailableMoments, IPrognosesService prognosesService, IDepartmentsRepository departments, IBranchRepository branches)
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
        }


        public async Task<IActionResult> IndexAsync(string? dateInput)
        {

            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            RosterDayViewModel viewModel = new RosterDayViewModel();
            viewModel.Date = date;
            var employeeList = _employeeRepository.GetList();
            var e = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(employeeList);
            viewModel.Employees = e.ToList();

            foreach (var emp in viewModel.Employees)
            {
                emp.PlannedShifts = _mapper.Map<IEnumerable<ShiftViewModel>>(_shiftRepository.GetWeekOfShiftsAfterDateForEmployee(date, emp.Id)).ToList();
            }

            var employee = await _userManager.GetUserAsync(User);
            viewModel.CassierePrognose = _prognosesServices.GetCassierePrognoseAsync(date, employee.DefaultBranchId);
            viewModel.StockersPrognose = _prognosesServices.GetStockersPrognose(date, employee.DefaultBranchId);
            viewModel.FreshPrognose = _prognosesServices.GetFreshPrognose(date, employee.DefaultBranchId);
            var shiftsOnDay = _mapper.Map<IEnumerable<ShiftViewModel>>(_prognosisRepository.GetShiftsOnDayByDate(date)).ToList();
            viewModel.UpdatePrognosis(shiftsOnDay);
            viewModel.PrognosisDayId = _prognosisRepository.GetIdByDate(date);

            viewModel.SelectedStartTime = viewModel.Date.AddHours(8);
            viewModel.SelectedEndTime = viewModel.Date.AddHours(16);

            viewModel.OpeningHour = 6;
            viewModel.ClosingHour = 20;

            viewModel.Departments = new List<DepartmentRosterViewModel>();
            foreach (var dep in _departmentsRepository.GetList().ToList())
            {
                
                viewModel.Departments.Add(new DepartmentRosterViewModel() { Id = dep.Id, DepartmentName = dep.DepartmentName});
            }
            return View(viewModel);
        }


        public IActionResult Create(string employeeId, string dateInput, int prognosisId)
        {
            RosterShiftCreateViewModel viewModel = new RosterShiftCreateViewModel();
            viewModel.Date = DateTime.Parse(dateInput);
            viewModel.StartTime = viewModel.Date.AddHours(8);
            viewModel.EndTime = viewModel.Date.AddHours(16);
            viewModel.PrognosisId = prognosisId;
            viewModel.DepartmentsList = _employeeRepository.Get(employeeId).AllowedDepartments.ToList();

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RosterShiftCreateViewModel newShift)
        {
            int maxHoursInWeekAllowed = 40; // DEFAULT 40 TODO 

            newShift.DepartmentsList = _employeeRepository.Get(newShift.EmployeeId).AllowedDepartments.ToList();

            // since starttime and endtime seem to only save the timestamps, we need to add the date to it
            newShift.StartTime = newShift.Date.AddHours(newShift.StartTime.Hour);
            newShift.EndTime = newShift.Date.AddHours(newShift.EndTime.Hour);

            //check if the endtime is after starttime
            if (newShift.EndTime < newShift.StartTime)
            {
                ModelState.AddModelError("EndTime", "Eindtijd moet na starttijd komen.");
                return View(newShift);
            }

            if (ModelState.IsValid)
            {
                var shift = _mapper.Map<PlannedShift>(newShift);


                // overlapping shifts
                if (_shiftRepository.ShiftOverlapsWithOtherShifts(shift))
                {
                    ModelState.AddModelError("StartTime", "Medewerker is al ingepland for deze tijden.");
                    ModelState.AddModelError("EndTime", "Medewerker is al ingepland for deze tijden.");
                    return View(newShift);
                }
                // check availability employee
                if (!_unavailableRepository.IsEmployeeAvailable(shift.Employee.Id, shift.StartTime, shift.EndTime))
                {
                    ModelState.AddModelError("StartTime", "Medewerker is niet beschikbaar voor deze tijd.");
                    ModelState.AddModelError("EndTime", "Medewerker is niet beschikbaar voor deze tijd.");
                }
                // check if CAO rules are met.
                if (_shiftRepository.GetHoursPlannedInWorkWeek(shift.Employee.Id, shift.StartTime.Date) + (shift.EndTime - shift.StartTime).TotalHours > maxHoursInWeekAllowed)
                {
                    ModelState.AddModelError("StartTime", "Medewerker heeft al te veel gewerkt deze week.");
                    ModelState.AddModelError("EndTime", "Medewerker heeft al te veel gewerkt deze week.");
                    return View(newShift);
                }


                _shiftRepository.Create(shift);
                return RedirectToAction("Index", new RouteValueDictionary(
                    new { controller = "RosterManager", action = "Index", dateInput = newShift.StartTime.Date.ToString() }));
            }
            return View(newShift);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShift(string selectedEmployeeId, int selectedDepartmentId, string selectedStartTime, string selectedEndTime)
        {
            PlannedShift plannedShift = new PlannedShift();
            plannedShift.StartTime = DateTime.Parse(selectedStartTime);
            plannedShift.EndTime = DateTime.Parse(selectedEndTime);
            plannedShift.Employee = _employeeRepository.Get(selectedEmployeeId);
            plannedShift.Department = _departmentsRepository.Get(selectedDepartmentId);
            Employee employee = await _userManager.GetUserAsync(User);
            plannedShift.Branch = _branchRepository.Get(employee.DefaultBranchId);
            _shiftRepository.Create(plannedShift);

            return RedirectToAction("Index");
        }
    

    }

}
