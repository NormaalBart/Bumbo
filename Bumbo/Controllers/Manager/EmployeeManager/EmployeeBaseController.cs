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
    public abstract class EmployeeBaseController : NotificationController
    {
        protected readonly UserManager<Employee> _userManager;
        protected readonly IEmployeeRepository _employeesRepository;
        protected readonly IMapper _mapper;
        protected readonly IBranchRepository _branchRepository;
        protected readonly IDepartmentsRepository _departmentsRepository;
        private const int ItemsPerPage = 25;


        public EmployeeBaseController(UserManager<Employee> userManager, IEmployeeRepository employeeService, IMapper mapper, IBranchRepository branchService, IDepartmentsRepository departmentService)
        {
            _userManager = userManager;
            _employeesRepository = employeeService;
            _mapper = mapper;
            _branchRepository = branchService;
            _departmentsRepository = departmentService;

        }

        public abstract IEnumerable<Employee> GetAllEmployees(int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc);
        public abstract int GetAmountOfEmployees(string searchString = "", bool includeActive = true, bool includeInactive = false);
        public IActionResult Index(string searchString, bool includeInactive = false, bool includeActive = true, EmployeeSortingOption currentSort = EmployeeSortingOption.Name_Asc, int page = 1)
        {
            if (page < 1) page = 1;
            var amountOfEmployees = GetAmountOfEmployees(searchString, includeActive, includeInactive);
            if (amountOfEmployees == 0 && page != 1)
            {
                page--;
                return RedirectToAction(nameof(Index), new { page, searchString, includeInactive, includeActive, currentSort });
            }

            var employees = GetAllEmployees((page - 1) * ItemsPerPage, ItemsPerPage, searchString, includeActive, includeInactive, currentSort);

            EmployeeListIndexViewModel resultingListViewModel = new EmployeeListIndexViewModel();
            resultingListViewModel.Page = page;
            resultingListViewModel.SearchString = searchString;
            resultingListViewModel.CurrentSort = currentSort;
            resultingListViewModel.IncludeInactive = includeInactive;
            resultingListViewModel.IncludeActive = includeActive;

            resultingListViewModel.Employees = _mapper.Map<IEnumerable<EmployeeListItemViewModel>>(employees).ToList();

            resultingListViewModel.AmountOfPages = (GetAmountOfEmployees(searchString, includeActive, includeInactive) - ((page - 1) * ItemsPerPage + ItemsPerPage)) / ItemsPerPage + 1;

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
            ShowMessage(MessageType.Success, "De data is opgeslagen");
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

            ShowMessage(MessageType.Success, "De data is opgeslagen");
            var user = await _userManager.FindByIdAsync(viewModel.Id);
            user.Active = !user.Active;
            _employeesRepository.Update(user);
            return RedirectToAction(nameof(Index));
        }
    }

}