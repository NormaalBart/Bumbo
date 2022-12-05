using AutoMapper;
using Bumbo.Models.EmployeeManager.Common;
using Bumbo.Models.EmployeeManager.Index;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager.EmployeeManager
{

    [Authorize(Roles = "Administrator,Manager")]
    public abstract class EmployeeBaseController : Controller
    {
        protected readonly UserManager<Employee> _userManager;
        protected readonly IEmployeeRepository _employeesRepository;
        protected readonly IMapper _mapper;
        protected readonly IBranchRepository _branchRepository;
        protected readonly IDepartmentsRepository _departmentsRepository;

        public EmployeeBaseController(UserManager<Employee> userManager, IEmployeeRepository employeeService, IMapper mapper, IBranchRepository branchService, IDepartmentsRepository departmentService)
        {
            _userManager = userManager;
            _employeesRepository = employeeService;
            _mapper = mapper;
            _branchRepository = branchService;
            _departmentsRepository = departmentService;

        }

        public abstract IEnumerable<Employee> GetAllEmployeesAsync();

        public IActionResult Index(string searchString, bool includeInactive, bool includeActive, EmployeeSortingOption currentSort)
        {

            EmployeeListIndexViewModel resultingListViewModel = new EmployeeListIndexViewModel();
            var employees = GetAllEmployeesAsync();

            if (!includeInactive && !includeActive)
            {
                employees = employees.Where(e => e.Active);
                resultingListViewModel.IncludeActive = true;
            }
            else if (!includeInactive && includeActive)
            {
                employees = employees.Where(e => e.Active);
            }
            else if (includeInactive && !includeActive)
            {
                employees = employees.Where(e => e.Active == false);
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                // search in employees if any of the columns contains the searchstring
                resultingListViewModel.SearchString = searchString;
                searchString = searchString.ToLower();
                employees = employees.Where(e => e.FirstName.ToLower().Contains(searchString) || e.LastName.ToLower().Contains(searchString));
            }

            switch (currentSort)
            {
                // case for each sortingoption, with asc and desc
                case EmployeeSortingOption.Name_Asc:
                    employees = employees.OrderBy(e => e.FirstName);
                    break;
                case EmployeeSortingOption.Name_Desc:
                    employees = employees.OrderByDescending(e => e.FirstName);
                    break;
                case EmployeeSortingOption.Function_Desc:
                    employees = employees.OrderByDescending(e => e.Function);
                    break;
                case EmployeeSortingOption.Function_Asc:
                    employees = employees.OrderBy(e => e.Function);
                    break;
                case EmployeeSortingOption.Birthdate_Asc:
                    employees = employees.OrderBy(e => e.Birthdate);
                    break;
                case EmployeeSortingOption.Birthdate_Desc:
                    employees = employees.OrderByDescending(e => e.Birthdate);
                    break;
                case EmployeeSortingOption.EmployeeSince_Asc:
                    employees = employees.OrderBy(e => e.EmployeeSince);
                    break;
                case EmployeeSortingOption.EmployeeSince_Desc:
                    employees = employees.OrderByDescending(e => e.EmployeeSince);
                    break;
                default:
                    employees = employees.OrderBy(e => e.FirstName);
                    break;
            }

            resultingListViewModel.Employees = _mapper.Map<IEnumerable<EmployeeListItemViewModel>>(employees).ToList();
            return View("Views/EmployeeBase/Index.cshtml", resultingListViewModel);
        }

        public IActionResult ChangePassword(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = new EditPasswordViewModel { EmployeeKey = id, FullName = employee.FullName() };
            return View("Views/EmployeeBase/ChangePassword.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(EditPasswordViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Views/EmployeeBase/ChangePassword.cshtml", viewModel);
            }

            var user = await _userManager.FindByIdAsync(viewModel.EmployeeKey);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, viewModel.Password);
            TempData["saved"] = true;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ToggleActive(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var viewModel = new ChangeWorkStatusViewModel
            {
                Id = id,
                Name = user.FullName(),
                IsActive = user.Active
            };
            return View("Views/EmployeeBase/ToggleActive.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleActive(ChangeWorkStatusViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Views/EmployeeBase/ToggleActive.cshtml", viewModel);
            }

            TempData["saved"] = true;
            var user = await _userManager.FindByIdAsync(viewModel.Id);
            user.Active = !user.Active;
            _employeesRepository.Update(user);
            return RedirectToAction(nameof(Index));
        }
    }

}