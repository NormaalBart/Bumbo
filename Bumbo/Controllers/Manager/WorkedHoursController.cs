﻿using AutoMapper;
using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using Bumbo.Models.WorkedHours;
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

    [Authorize(Roles = "Manager")]
    public class WorkedHoursController : NotificationController
    {
        readonly private UserManager<Employee> _userManager;
        readonly private IMapper _mapper;
        readonly private IEmployeeRepository _employeeRepository;
        readonly private IWorkedShiftRepository _workedShiftRepository;
        readonly private IPlannedShiftsRepository _plannedShiftRepository;
        public WorkedHoursController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee, IWorkedShiftRepository workedShiftRepository, IPlannedShiftsRepository plannedShiftsRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _employeeRepository = employee;
            _workedShiftRepository = workedShiftRepository;
            _plannedShiftRepository = plannedShiftsRepository;
        }

        public async Task<IActionResult> IndexAsync(string? dateInput)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            var viewModel = new IndexWorkedHoursViewModel();
            viewModel.Date = date;
            var employee = await _userManager.GetUserAsync(User);
            var employeeList = _employeeRepository.GetAllThatWorkedOrWasPlannedOnDate(date, employee.DefaultBranchId ?? -1);
            var e = _mapper.Map<IEnumerable<EmployeeWorkedHoursViewModel>>(employeeList);
            viewModel.Employees = e.ToList();
            return View(viewModel);
        }

        public async Task<IActionResult> EmployeeAsync(string? dateInput)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput).GetMondayOfTheWeek();
            var viewModel = new EmployeeWorkedHoursListViewModel();
            viewModel.Date = date;
            var employee = await _userManager.GetUserAsync(User);
            var employeeList = new List<EmployeeWorkedHoursListItemViewModel>();
            //for adding all the days in the week
            for (int i = 0; i < 7; i++)
            {
                var temp = new EmployeeWorkedHoursListItemViewModel();
                temp.Date = date.AddDays(i);
                temp.WorkedShifts = _mapper.Map<IEnumerable<WorkedShiftViewModel>>(_workedShiftRepository.GetOfEmployeeOnDayThatIsComplete(temp.Date, employee.Id)).ToList();
                temp.PlannedShifts = _mapper.Map<IEnumerable<ShiftViewModel>>(_plannedShiftRepository.GetOfEmployeeOnDay(temp.Date, employee.Id)).ToList();
                employeeList.Add(temp);
            }

            viewModel.employeeWorkedHoursListItemViewModels = employeeList;
            return View(viewModel);
        }

        public IActionResult Approve(List<int> ids)
        {
            WorkedShift tempWorkedShift = null;
            foreach (var id in ids)
            {
                tempWorkedShift = _workedShiftRepository.Get(id);
                tempWorkedShift.Approved = true;
                _workedShiftRepository.Update(tempWorkedShift);
            }
            return RedirectToAction("Index", new { dateInput = tempWorkedShift.StartTime.ToString() });
        }

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
            return RedirectToAction("Index",new { dateInput = employeeWorkedHoursViewModel.WorkedShifts.FirstOrDefault().StartTime.ToString() });
        }

    }
}