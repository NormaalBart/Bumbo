using AutoMapper;
using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Bumbo.Controllers
{


    public class WorkedHoursController : Controller
    {
        readonly private UserManager<Employee> _userManager;
        readonly private IMapper _mapper;
        readonly private IEmployeeRepository _employeeRepository;
        readonly private IWorkedShiftRepository _workedShiftRepository;
        public WorkedHoursController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee, IWorkedShiftRepository workedShiftRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _employeeRepository = employee;
            _workedShiftRepository = workedShiftRepository;
        }
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> IndexAsync(string? dateInput)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            var viewModel = new ApproveWorkedHoursViewModel();
            viewModel.Date = date;
            var employee = await _userManager.GetUserAsync(User);
            var employeeList = _employeeRepository.GetAllThatWorkedOrWasPlannedOnDate(date, employee.DefaultBranchId);
            var e = _mapper.Map<IEnumerable<EmployeeWorkedHoursViewModel>>(employeeList);
            viewModel.Employees = e.ToList();
            return View(viewModel);
        }
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> EmployeeAsync(string? dateInput)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            var viewModel = new ApproveWorkedHoursViewModel();
            viewModel.Date = date;
            var employee = await _userManager.GetUserAsync(User);
            var employeeList = _employeeRepository.GetAllThatWorkedOrWasPlannedOnDate(date, employee.DefaultBranchId);
            var e = _mapper.Map<IEnumerable<EmployeeWorkedHoursViewModel>>(employeeList);
            viewModel.Employees = e.ToList();
            return View(viewModel);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Approve(List<int> ids)
        {
            foreach (var id in ids)
            {
                var tempWorkedShift = _workedShiftRepository.Get(id);
                tempWorkedShift.Approved = true;
                _workedShiftRepository.Update(tempWorkedShift);
            }
            return Redirect("Index");
        }
        [Authorize(Roles = "Manager")]
        public IActionResult Edit(List<int> workedShiftId, string employeeId)
        {
            var employeeWorkedHoursViewModel = _mapper.Map<EmployeeWorkedHoursViewModel>(_employeeRepository.Get(employeeId));
            foreach (var id in workedShiftId)
            {
                var w = _mapper.Map<WorkedShiftViewModel>(_workedShiftRepository.Get(id));
                employeeWorkedHoursViewModel.WorkedShifts.Add(w);
            }
            return View(employeeWorkedHoursViewModel);
        }
        [Authorize(Roles = "Manager")]
        [HttpPost]
        public IActionResult Edit(EmployeeWorkedHoursViewModel employeeWorkedHoursViewModel)
        {
            foreach (var item in employeeWorkedHoursViewModel.WorkedShifts)
            {
                var temp = _workedShiftRepository.Get(item.Id);
                temp.StartTime = item.StartTime;
                temp.EndTime = item.EndTime;
                _workedShiftRepository.Update(temp);
            }
            return Redirect("Index");
        }

    }
}
