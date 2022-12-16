using AutoMapper;
using Bumbo.Models.EmployeeManager.Manager;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager.EmployeeManager
{
    public class EmployeeAdminController : EmployeeBaseController
    {

        public EmployeeAdminController(UserManager<Employee> userManager,
    IEmployeeRepository employeeService,
    IMapper mapper,
    IBranchRepository branchService,
    IDepartmentsRepository departmentService) : base(userManager, employeeService, mapper, branchService, departmentService)
        {

        }

        public IActionResult Create()
        {
            var viewModel = new ManagerCreateViewModel();
            viewModel.Branches = _branchRepository.GetList().ToList();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ManagerCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Branches = _branchRepository.GetList().ToList();
                return View(viewModel);
            }
            if (_employeesRepository.GetByEmail(viewModel.Email) != null)
            {
                ModelState.AddModelError("Email", "Dit email is al in gebruik");
                return View(viewModel);
            }
            var manager = await _userManager.GetUserAsync(User);
            var employee = _mapper.Map<Employee>(viewModel);
            employee.AllowedDepartments = _departmentsRepository.GetList().ToList();
            employee.DefaultBranchId = viewModel.SelectedBranch;
            employee.Id = Guid.NewGuid().ToString();
            employee.UserName = employee.Id;
            employee.Function = RoleType.MANAGER.Name;
            employee.NormalizedUserName = employee.UserName;
            await _userManager.CreateAsync(employee, viewModel.Password);
            await _userManager.AddToRoleAsync(employee, RoleType.MANAGER.RoleId);
            ShowMessage(MessageType.Success, "De data is opgeslagen");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = _mapper.Map<ManagerEditViewModel>(employee);
            viewModel.Branches = _branchRepository.GetList().ToList();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ManagerEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var employee = _employeesRepository.Get(viewModel.EmployeeKey);
            _mapper.Map<ManagerEditViewModel, Employee>(viewModel, employee);
            _employeesRepository.Update(employee);
            ShowMessage(MessageType.Success, "De data is opgeslagen");
            return RedirectToAction(nameof(Index));
        }

        public override IEnumerable<Employee> GetAllEmployees(int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc)
        {
            return _employeesRepository.GetAllManagers(start, amount);
        }
    }
}
