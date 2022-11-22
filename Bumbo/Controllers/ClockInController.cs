﻿using Bumbo.Models;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClockInController : ControllerBase
    {
        private IWorkedShiftRepository  _workedShiftRepository;
        private IEmployeeRepository _employeeRepository;
        private IBranchRepository _branchRepository;

        public ClockInController(IWorkedShiftRepository workedShiftRepository, IEmployeeRepository employeeRepository, IBranchRepository branchRepository)
        {
            _workedShiftRepository = workedShiftRepository;
            _employeeRepository = employeeRepository;
            _branchRepository = branchRepository;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create([FromForm] IncomingDataClockIn msgBody)
        {
            Employee employee = _employeeRepository.Get(msgBody.EmployeeId);
            Branch branch = _branchRepository.Get(msgBody.BranchId);
            if (employee == null || branch == null)
            {
                return BadRequest();
            }

            WorkedShift lastWorkedShift = _workedShiftRepository.LastWorkedShiftWithNoEndTime(employee);

            if (lastWorkedShift != null)
            {
                lastWorkedShift.EndTime = DateTime.Now;
                _workedShiftRepository.Update(lastWorkedShift);
            }
            else
            {
                WorkedShift newWorkedShift = new WorkedShift();
                newWorkedShift.Employee = employee;
                newWorkedShift.Branch = branch;
                newWorkedShift.StartTime = DateTime.Now;
                newWorkedShift.Sick = false;
                newWorkedShift.Approved = false;
                _workedShiftRepository.Create(newWorkedShift);
            }
            return Ok();
        }
    }
}