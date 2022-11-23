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
            var manager = await _userManager.GetUserAsync(User);
            var employee = _mapper.Map<Employee>(viewModel);
            foreach (var department in _departmentsRepository.GetList())
            {
                employee.AllowedDepartments.Add(department);
            }
            employee.DefaultBranchId = viewModel.SelectedBranch;
            employee.ManagesBranchId = viewModel.SelectedBranch;
            employee.Id = Guid.NewGuid().ToString();
            employee.UserName = employee.Id;
            employee.NormalizedUserName = employee.UserName;
            await _userManager.CreateAsync(employee, viewModel.Password);
            await _userManager.AddToRoleAsync(employee, RoleType.MANAGER.RoleId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = _mapper.Map<ManagerEditViewModel>(employee);
            viewModel.Branches = _branchRepository.GetList().ToList();
            return View("Views/EmployeeManager/Manager/Edit.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ManagerEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Views/EmployeeManager/Manager/Edit.cshtml", viewModel);
            }

            var employee = _employeesRepository.Get(viewModel.EmployeeKey);
            _mapper.Map<ManagerEditViewModel, Employee>(viewModel, employee);
            _employeesRepository.Update(employee);
            return RedirectToAction(nameof(Index));
        }

        public override IEnumerable<Employee> GetAllEmployeesAsync()
        {
            return _employeesRepository.GetAllManagers();
        }
    }
}
