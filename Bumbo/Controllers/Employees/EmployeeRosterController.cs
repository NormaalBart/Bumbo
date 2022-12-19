using AutoMapper;
using Bumbo.Models.EmployeeRoster;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Bumbo.Controllers.Employees
{

    [Authorize(Roles = "Employee")]
    public class EmployeeRosterController : Controller
    {

        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IPlannedShiftsRepository _shiftRepository;
        private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
        public EmployeeRosterController(UserManager<Employee> userManager, IMapper mapper, IPlannedShiftsRepository shiftsRepository, IUnavailableMomentsRepository unavailableMomentsRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _shiftRepository = shiftsRepository;
            _unavailableMomentsRepository = unavailableMomentsRepository;
        }


        public async Task<IActionResult> Index(string? dateInput)
        {
            // requested date 
            DateTime date = DateTime.Today;
            if (dateInput != null)
            {
                date = DateTime.Parse(dateInput);
            }

            // id of the employee logged in currently.
            Employee employee = await _userManager.GetUserAsync(User);

            EmployeeShiftsListViewModel shiftsVM = new EmployeeShiftsListViewModel();
            shiftsVM.Date = date.ToDateOnly();
            var shifts = _shiftRepository.GetOfEmployeeOnDay(date, employee.Id);
            var moments = _unavailableMomentsRepository.GetUnavailableMomentsByDay(employee.Id, date.ToDateOnly());

            shiftsVM.shifts = _mapper.Map<IEnumerable<EmployeeShiftViewModel>>(shifts).ToList();
            shiftsVM.shifts.AddRange(_mapper.Map<IEnumerable<EmployeeShiftViewModel>>(moments).ToList());
            shiftsVM.shifts = shiftsVM.shifts.OrderBy(s => s.StartTime).ToList();
            return View(shiftsVM);
        }
    }
}
