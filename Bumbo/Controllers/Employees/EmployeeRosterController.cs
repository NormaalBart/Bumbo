using AutoMapper;
using Bumbo.Models.EmployeeRoster;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Employees;

[Authorize(Roles = "Employee")]
public class EmployeeRosterController : Controller
{
    private readonly IMapper _mapper;
    private readonly IPlannedShiftsRepository _shiftRepository;
    private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;

    private readonly UserManager<Employee> _userManager;

    public EmployeeRosterController(UserManager<Employee> userManager, IMapper mapper,
        IPlannedShiftsRepository shiftsRepository, IUnavailableMomentsRepository unavailableMomentsRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _shiftRepository = shiftsRepository;
        _unavailableMomentsRepository = unavailableMomentsRepository;
    }

    public async Task<IActionResult> Index(string? dateInput)
    {
        // requested date 
        var date = DateTime.Today;
        if (dateInput != null) date = DateTime.Parse(dateInput);

        // id of the employee logged in currently.
        var employee = await _userManager.GetUserAsync(User);

        var shiftsVM = new EmployeeShiftsListViewModel();
        shiftsVM.Date = date.ToDateOnly();
        var dbshifts = _shiftRepository.GetWeekOfShiftsAfterDateForEmployee(date, employee.Id);
        var dbMoments =
            _unavailableMomentsRepository.GetWeekOfUnavailableMomentsAfterDateForEmployee(date.Date, employee.Id);

        shiftsVM.Shifts = _mapper.Map<IEnumerable<EmployeeShiftViewModel>>(dbshifts).ToList();
        shiftsVM.Shifts.AddRange(_mapper.Map<IEnumerable<EmployeeShiftViewModel>>(dbMoments).ToList());
        shiftsVM.Shifts = shiftsVM.Shifts.OrderBy(s => s.StartTime).ToList();
        return View(shiftsVM);
    }
}