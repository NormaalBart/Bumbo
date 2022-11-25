using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
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


        public async Task<IActionResult> IndexAsync(string? dateInput, string? errormessage)
        {

            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            // we make sure that the passed date is definitely without time.
            DateOnly dateonly = DateTime.Parse(dateInput).ToDateOnly();
            DateTime date = dateonly.ToDateTime(new TimeOnly(0,0,0));
            RosterDayViewModel viewModel = new RosterDayViewModel();
            viewModel.Date = date;
            var employeeList = _employeeRepository.GetList();
            var e = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(employeeList);
            viewModel.Employees = e.ToList();

            foreach (var emp in viewModel.Employees)
            {
                emp.PlannedShifts = _mapper.Map<IEnumerable<ShiftViewModel>>(_shiftRepository.GetShiftsOnDayForEmployeeOnDate(date, emp.Id)).ToList();
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


            viewModel.Departments = new List<DepartmentRosterViewModel>();
            foreach (var dep in _departmentsRepository.GetList().ToList())
            {
                
                viewModel.Departments.Add(new DepartmentRosterViewModel() { Id = dep.Id, DepartmentName = dep.DepartmentName});
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
            if (_shiftRepository.GetHoursPlannedInWorkWeek(plannedShift.Employee.Id, plannedShift.StartTime.Date) + (plannedShift.EndTime - plannedShift.StartTime).TotalHours > maxHoursInWeekAllowed)
            {
                return RedirectToAction("Index", "RosterManager", new { dateInput = date, errormessage = "Medewerker heeft al te veel gewerkt deze week." });
            }


            _shiftRepository.Create(plannedShift);

            return RedirectToAction("Index", "RosterManager", new { dateInput = date });
        }
    

    }

}
