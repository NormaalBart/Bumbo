using Bumbo.Models;
using BumboData.Models;
using BumboRepositories.Repositories;
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
            Employee employee = _employeeRepository.GetById(msgBody.EmployeeId);
            Branch branch = _branchRepository.GetById(msgBody.BranchId);
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
                _workedShiftRepository.Add(newWorkedShift);
            }
            return Ok();
        }
    }
}
