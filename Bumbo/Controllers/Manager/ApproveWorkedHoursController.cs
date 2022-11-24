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

namespace Bumbo.Controllers.Manager
{
    [Authorize(Roles = "Manager")]
    public class ApproveWorkedHoursController : Controller
    {
        readonly private UserManager<Employee> _userManager;
        readonly private IMapper _mapper;
        readonly private IEmployeeRepository _employeeRepository;
        public ApproveWorkedHoursController(UserManager<Employee> userManager, IMapper mapper, IEmployeeRepository employee)
        {
            _userManager = userManager;
            _mapper = mapper;
            _employeeRepository = employee;
        }
        public async Task<IActionResult> IndexAsync(string? dateInput)
        {
            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            ApproveWorkedHoursViewModel viewModel = new ApproveWorkedHoursViewModel();
            viewModel.Date = date;
            var employee = await _userManager.GetUserAsync(User);
            var employeeList = _employeeRepository.GetAllThatWorkedOrWasPlannedOnDate(date, employee.DefaultBranchId);
            var e = _mapper.Map<IEnumerable<EmployeeWorkedHoursViewModel>>(employeeList);
            viewModel.Employees = e.ToList();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Approve(List<WorkedShiftViewModel> workedShiftViewModels)
        {
            return View();
        }
    }
}
