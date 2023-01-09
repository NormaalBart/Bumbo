using Bumbo.Models;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

[ApiController]
[Route("[controller]")]
public class ClockInController : ControllerBase
{
    private readonly IBranchRepository _branchRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IWorkedShiftRepository _workedShiftRepository;

    public ClockInController(IWorkedShiftRepository workedShiftRepository, IEmployeeRepository employeeRepository,
        IBranchRepository branchRepository)
    {
        _workedShiftRepository = workedShiftRepository;
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Create([FromForm] IncomingDataClockIn msgBody)
    {
        var employee = _employeeRepository.Get(msgBody.EmployeeId);
        var branch = _branchRepository.Get(msgBody.BranchId);
        if (employee == null || branch == null) return BadRequest();

        var lastWorkedShift = _workedShiftRepository.LastWorkedShiftWithNoEndTime(employee);

        if (lastWorkedShift != null)
        {
            lastWorkedShift.EndTime = DateTime.Now;
            _workedShiftRepository.Update(lastWorkedShift);
        }
        else
        {
            var newWorkedShift = new WorkedShift();
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