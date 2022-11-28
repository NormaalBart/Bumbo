﻿using AutoMapper;
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
using BumboData.Enums;
using BumboServices.CAO.Rules;

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

        public RosterManagerController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee,
            IPrognosisRepository prognosis, IPlannedShiftsRepository plannedShifts,
            IUnavailableMomentsRepository unavailableMoments, IPrognosesService prognosesService,
            IDepartmentsRepository departments, IBranchRepository branches, ICAOService caoService)
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
        }


        public async Task<IActionResult> IndexAsync(string? dateInput, string? errormessage)
        {
            // Only manager can 
            if (!User.IsInRole(RoleType.MANAGER.Name))
            {
                return BadRequest();
            }

            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }

            var date = DateTime.Parse(dateInput).Date;
            var viewModel = new RosterDayViewModel();
            viewModel.Date = date;

            var employeeList = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(_employeeRepository.GetList());

            var manager = await _userManager.GetUserAsync(User);

            foreach (var emp in employeeList)
            {
                emp.PlannedShifts = _mapper
                    .Map<IEnumerable<ShiftViewModel>>(
                        _shiftRepository.GetShiftsOnDayForEmployeeOnDate(date, emp.Id, manager.DefaultBranchId))
                    .ToList();
                if (emp.PlannedShifts.Count > 0)
                {
                    viewModel.RosteredEmployees.Add(emp);
                }

                viewModel.AvailableEmployees.Add(emp);
            }

            viewModel.CassierePrognose = _prognosesServices.GetCassierePrognoseAsync(date, manager.DefaultBranchId);
            viewModel.StockersPrognose = _prognosesServices.GetStockersPrognose(date, manager.DefaultBranchId);
            viewModel.FreshPrognose = _prognosesServices.GetFreshPrognose(date, manager.DefaultBranchId);
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

            // Check if CAO rules are met
            // Get all shifts of this week for context for the cao service
            var allShiftsWeek = _shiftRepository.GetShiftsByWeek(manager.ManagesBranchId ?? -1,
                date.Year, date.GetWeekNumber());
            var invalidShifts = _caoService.VerifyPlannedShiftsWeek(allShiftsWeek);
            // Filter shifts to only display that of today
            viewModel.InvalidShifts = invalidShifts
                .Select(s => (s.Key, s.Value.Where(s => s.StartTime.Date == date.Date)))
                .ToDictionary(d => d.Key, d => d.Item2);

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShift(string selectedEmployeeId, int selectedDepartmentId,
            string selectedStartTime, string selectedEndTime, string date)
        {
            // Only manager can 
            if (!User.IsInRole(RoleType.MANAGER.Name))
            {
                return BadRequest();
            }

            PlannedShift plannedShift = new PlannedShift();

            // Passed start time and end time are only time values, so we add the passed date as well.
            plannedShift.StartTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedStartTime).Hour)
                .AddMinutes(DateTime.Parse(selectedStartTime).Minute);
            plannedShift.EndTime = DateTime.Parse(date).AddHours(DateTime.Parse(selectedEndTime).Hour)
                .AddMinutes(DateTime.Parse(selectedEndTime).Minute);

            plannedShift.Employee = _employeeRepository.Get(selectedEmployeeId);
            plannedShift.Department = _departmentsRepository.Get(selectedDepartmentId);
            var manager = await _userManager.GetUserAsync(User);

            plannedShift.Branch = _branchRepository.Get(manager.ManagesBranchId ?? -1);

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

            // check if CAO rules are met.
            // TODO insert CAO rules services.


            // allShiftsWeek.Add(plannedShift);
            // var caoResponse = _caoService.VerifyPlannedShiftsWeek(allShiftsWeek);
            //
            // if (caoResponse.Count != 0)
            // {
            //     return RedirectToAction("Index", "RosterManager",
            //         new {dateInput = date, errormessage = "CAO Regels overtreden", invalidShifts = caoResponse});
            // }

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

            int maxHoursInWeekAllowed = 40; // TODO

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

            // check if CAO rules are met.

            // TODO insert CAO rules services.


            _shiftRepository.Update(plannedShift);

            return RedirectToAction("Index", "RosterManager", new {dateInput = date});
        }
    }
}