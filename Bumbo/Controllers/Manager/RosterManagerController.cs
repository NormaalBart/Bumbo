using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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


        public async Task<IActionResult> IndexAsync(string? dateInput, string? errormessage, int copiedShifts = 0)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput).Date;
            RosterDayViewModel viewModel = new RosterDayViewModel();
            viewModel.Date = date;
            viewModel.CopyFromWeek = date;
            viewModel.CopyToWeek = date.AddDays(7);
            viewModel.CopiedShifts = copiedShifts;
            var employeeList = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(_employeeRepository.GetList());

            var employee = await _userManager.GetUserAsync(User);

            foreach (var emp in employeeList)
            {
                emp.PlannedShifts = _mapper.Map<IEnumerable<ShiftViewModel>>(_shiftRepository.GetShiftsOnDayForEmployeeOnDate(date, emp.Id, employee.DefaultBranchId)).ToList();
                if (emp.PlannedShifts.Count > 0)
                {
                    viewModel.RosteredEmployees.Add(emp);
                }
                viewModel.AvailableEmployees.Add(emp);
            }


            viewModel.CassierePrognose = _prognosesServices.GetCassierePrognoseAsync(date, employee.DefaultBranchId);
            viewModel.StockersPrognose = _prognosesServices.GetStockersPrognose(date, employee.DefaultBranchId);
            viewModel.FreshPrognose = _prognosesServices.GetFreshPrognose(date, employee.DefaultBranchId);
            var shiftsOnDay = _mapper.Map<IEnumerable<ShiftViewModel>>(_prognosisRepository.GetShiftsOnDayByDate(date)).ToList();
            viewModel.UpdatePrognosis(shiftsOnDay);
            viewModel.PrognosisDayId = _prognosisRepository.GetIdByDate(date);

            viewModel.SelectedStartTime = viewModel.Date.AddHours(8);
            viewModel.SelectedEndTime = viewModel.Date.AddHours(16);


            viewModel.Departments = new List<DepartmentRosterViewModel>();
            foreach (var dep in _departmentsRepository.GetList().ToList())
            {

                viewModel.Departments.Add(new DepartmentRosterViewModel() { Id = dep.Id, DepartmentName = dep.DepartmentName });
            }

            if (errormessage != null)
            {
                viewModel.ErrorMessage = errormessage;

            }

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShift(string selectedEmployeeId, int selectedDepartmentId, string selectedStartTime, string selectedEndTime, string date)
        {
            PlannedShift plannedShift = new PlannedShift();

            // Passed start time and end time are only time values, so we add the passed date as well.
            plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour).AddMinutes(DateTime.Parse(selectedStartTime).Minute);
            plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour).AddMinutes(DateTime.Parse(selectedEndTime).Minute);

            plannedShift.Employee = _employeeRepository.Get(selectedEmployeeId);
            plannedShift.Department = _departmentsRepository.Get(selectedDepartmentId);
            Employee employee = await _userManager.GetUserAsync(User);
            plannedShift.Branch = _branchRepository.Get(employee.DefaultBranchId);

            int maxHoursInWeekAllowed = 40; // TODO

            // time is valid
            if (plannedShift.StartTime > plannedShift.EndTime)
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen." });
            }
            // overlapping shifts
            if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "Medewerker is al ingepland for deze tijden." });
            }
            // check availability employee
            if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime, plannedShift.EndTime))
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd." });
            }

            // check if CAO rules are met.
            // TODO insert CAO rules services.


            _shiftRepository.Create(plannedShift);

            return RedirectToAction("Index", "RosterManager", new { dateInput = date });
        }

        public async Task<IActionResult> EditShift(string selectedEmployeeId, int selectedDepartmentId, string selectedStartTime, string selectedEndTime, string date, int selectedShiftId)
        {

            PlannedShift plannedShift = _shiftRepository.GetPlannedShiftById(selectedShiftId);

            // Passed start time and end time are only time values, so we add the passed date as well.
            plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour).AddMinutes(DateTime.Parse(selectedStartTime).Minute);
            plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour).AddMinutes(DateTime.Parse(selectedEndTime).Minute);

            plannedShift.Department = _departmentsRepository.GetById(selectedDepartmentId);

            int maxHoursInWeekAllowed = 40; // TODO

            // time is valid
            if (plannedShift.StartTime > plannedShift.EndTime)
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "eindtijd niet na de starttijd mag komen." });
            }
            // overlapping shifts
            if (_shiftRepository.ShiftOverlapsWithOtherShifts(plannedShift))
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "Medewerker is al ingepland for deze tijden." });
            }
            // check availability employee
            if (!_unavailableRepository.IsEmployeeAvailable(plannedShift.Employee.Id, plannedShift.StartTime, plannedShift.EndTime))
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "Medewerker is niet beschikbaar voor deze tijd." });
            }

            // check if CAO rules are met.

            // TODO insert CAO rules services.


            _shiftRepository.Update(plannedShift);

            return RedirectToAction("Index", "RosterManager", new { dateInput = date });
        }

        public async Task<IActionResult> CopyFromWeekAsync(string date, DateTime copyFromWeek, DateTime copyToWeek)
        {
            var beginOfTheWeek = new DateTime().AddYears(copyFromWeek.Year - 1).AddDays(copyFromWeek.DayOfYear - 1);
            beginOfTheWeek = beginOfTheWeek.GetMondayOfTheWeek();
            var endOfTheWeek = beginOfTheWeek.AddDays(7);
            var employee = await _userManager.GetUserAsync(User);
            var shifts = _shiftRepository.GetPlannedShiftsInBetween(employee.DefaultBranchId, beginOfTheWeek, endOfTheWeek);
            var diff = copyToWeek - copyFromWeek;
            int numberOfCopiedShifts = 0;
            foreach (var shift in shifts)
            {
                var oldShift = _shiftRepository.GetPlannedShiftById(shift.Id);
                var newShift = new PlannedShift();
                newShift.StartTime = oldShift.StartTime + diff;
                newShift.EndTime = oldShift.EndTime + diff;
                newShift.Branch = oldShift.Branch;
                newShift.BranchId = oldShift.BranchId;
                newShift.Employee = oldShift.Employee;
                newShift.EmployeeId = oldShift.EmployeeId;
                newShift.Department = oldShift.Department;
                newShift.DepartmentId = oldShift.DepartmentId;
                if (!_shiftRepository.ShiftOverlapsWithOtherShifts(newShift))
                {
                    _shiftRepository.Create(newShift);
                    numberOfCopiedShifts++;
                }
            }
            return RedirectToAction("Index", "RosterManager", new { dateInput = date, copiedShifts = numberOfCopiedShifts });
        }

    }

}
