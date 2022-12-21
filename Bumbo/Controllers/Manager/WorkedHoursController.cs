using AutoMapper;
using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using Bumbo.Models.WorkedHours;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

public class WorkedHoursController : NotificationController
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IPlannedShiftsRepository _plannedShiftRepository;
    private readonly UserManager<Employee> _userManager;
    private readonly IWorkedShiftRepository _workedShiftRepository;

    public WorkedHoursController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee,
        IWorkedShiftRepository workedShiftRepository, IPlannedShiftsRepository plannedShiftsRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _employeeRepository = employee;
        _workedShiftRepository = workedShiftRepository;
        _plannedShiftRepository = plannedShiftsRepository;
    }

    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> IndexAsync(string? dateInput)
    {
        if (dateInput == null) dateInput = DateTime.Today.ToString();
        var date = DateTime.Parse(dateInput);
        var viewModel = new IndexWorkedHoursViewModel();
        viewModel.Date = date;
        var employee = await _userManager.GetUserAsync(User);
        var employeeList = _employeeRepository.GetAllThatWorkedOrWasPlannedOnDate(date, employee.DefaultBranchId ?? -1);
        var e = _mapper.Map<IEnumerable<EmployeeWorkedHoursViewModel>>(employeeList);
        viewModel.Employees = e.ToList();
        return View(viewModel);
    }

    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> EmployeeAsync(string? dateInput)
    {
        if (dateInput == null) dateInput = DateTime.Today.ToString();
        var date = DateTime.Parse(dateInput).GetMondayOfTheWeek();
        var viewModel = new EmployeeWorkedHoursListViewModel();
        viewModel.Date = date;
        var employee = await _userManager.GetUserAsync(User);
        var employeeList = new List<EmployeeWorkedHoursListItemViewModel>();
        //for adding all the days in the week
        for (var i = 0; i < 7; i++)
        {
            var temp = new EmployeeWorkedHoursListItemViewModel();
            temp.Date = date.AddDays(i);
            temp.WorkedShifts = _mapper
                .Map<IEnumerable<WorkedShiftViewModel>>(
                    _workedShiftRepository.GetOfEmployeeOnDayThatIsComplete(temp.Date, employee.Id)).ToList();
            temp.PlannedShifts = _mapper
                .Map<IEnumerable<ShiftViewModel>>(_plannedShiftRepository.GetOfEmployeeOnDay(temp.Date, employee.Id))
                .ToList();
            employeeList.Add(temp);
        }

        viewModel.employeeWorkedHoursListItemViewModels = employeeList;
        return View(viewModel);
    }

    [Authorize(Roles = "Manager")]
    public IActionResult Approve(List<int> ids)
    {
        WorkedShift tempWorkedShift = null;
        foreach (var id in ids)
        {
            tempWorkedShift = _workedShiftRepository.Get(id);
            tempWorkedShift.Approved = true;
            _workedShiftRepository.Update(tempWorkedShift);
        }

        return RedirectToAction("Index", new {dateInput = tempWorkedShift.StartTime.ToString()});
    }

    [Authorize(Roles = "Manager")]
    public IActionResult Edit(List<int> workedShiftId, string employeeId)
    {
        var employeeWorkedHoursViewModel =
            _mapper.Map<EmployeeWorkedHoursViewModel>(_employeeRepository.Get(employeeId));
        foreach (var id in workedShiftId)
        {
            var w = _mapper.Map<WorkedShiftViewModel>(_workedShiftRepository.Get(id));
            employeeWorkedHoursViewModel.WorkedShifts.Add(w);
        }

        return View(employeeWorkedHoursViewModel);
    }

    [Authorize(Roles = "Manager")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(EmployeeWorkedHoursViewModel employeeWorkedHoursViewModel)
    {
        foreach (var item in employeeWorkedHoursViewModel.WorkedShifts)
        {
            var temp = _workedShiftRepository.Get(item.Id);
            temp.StartTime = item.StartTime;
            temp.EndTime = item.EndTime;
            _workedShiftRepository.Update(temp);
        }

        ShowMessage(MessageType.Success, "De data is opgeslagen");
        return RedirectToAction("Index",
            new {dateInput = employeeWorkedHoursViewModel.WorkedShifts.FirstOrDefault().StartTime.ToString()});
    }
}