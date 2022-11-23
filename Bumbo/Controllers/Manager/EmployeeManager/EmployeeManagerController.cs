using AutoMapper;
using Bumbo.Models.EmployeeManager.Employee;
using Bumbo.Models.EmployeeManager.Index;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager.EmployeeManager
{
    public class EmployeeManagerController : EmployeeBaseController
    {

        public EmployeeManagerController(UserManager<Employee> userManager,
            IEmployeeRepository employeeService,
            IMapper mapper,
            IBranchRepository branchService,
            IDepartmentsRepository departmentService) : base(userManager, employeeService, mapper, branchService, departmentService)
        {

        }

        public IActionResult Create()
        {
            var viewModel = new EmployeeCreateViewModel();
            PopulateUnselectedDepartments(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeCreateViewModel viewModel, List<int> selectedDepartments)
        {
            if (!ModelState.IsValid)
            {
                PopulateUnselectedDepartments(viewModel);
                return View(viewModel);
            }
            if (selectedDepartments.Count == 0)
            {
                PopulateUnselectedDepartments(viewModel);
                ModelState.AddModelError("EmployeeSelectedDepartments", "Er moet minimaal 1 department zijn geselecteerd");
                return View(viewModel);
            }
            if(_employeesRepository.GetByEmail(viewModel.Email) != null)
            {
                PopulateUnselectedDepartments(viewModel);
                ModelState.AddModelError("Email", "Dit email is al in gebruik");
                return View(viewModel);
            }
            var manager = await _userManager.GetUserAsync(User);
            var employee = _mapper.Map<Employee>(viewModel);
            foreach (var departmentId in selectedDepartments)
            {
                var department = _departmentsRepository.Get(departmentId);
                employee.AllowedDepartments.Add(department);
            }
            employee.DefaultBranchId = manager.DefaultBranchId;
            employee.Id = Guid.NewGuid().ToString();
            employee.UserName = employee.Id;
            employee.NormalizedUserName = employee.UserName;
            await _userManager.CreateAsync(employee, viewModel.Password);
            await _userManager.AddToRoleAsync(employee, RoleType.EMPLOYEE.RoleId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = _mapper.Map<EmployeeEditViewModel>(employee);
            viewModel.EmployeeSelectedDepartments.Clear();
            PopulateDepartments(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeEditViewModel employeeCreateEditModel, List<int> selectedDepartments)
        {
            if (!ModelState.IsValid)
            {
                PopulateDepartments(employeeCreateEditModel);
                return View(employeeCreateEditModel);
            }
            if (selectedDepartments.Count == 0)
            {
                PopulateDepartments(employeeCreateEditModel);
                ModelState.AddModelError("EmployeeSelectedDepartments", "Er moet minimaal 1 department zijn geselecteerd");
                return View(employeeCreateEditModel);
            }
            var employee = _employeesRepository.Get(employeeCreateEditModel.EmployeeKey);
            _mapper.Map<EmployeeEditViewModel, Employee>(employeeCreateEditModel, employee);
            employee.AllowedDepartments.Clear();
            foreach (var departmentId in selectedDepartments)
            {
                var department = _departmentsRepository.Get(departmentId);
                employee.AllowedDepartments.Add(department);
            }
            _employeesRepository.Update(employee);
            return RedirectToAction(nameof(Index));
        }

        private void PopulateDepartments(EmployeeEditViewModel viewModel)
        {
            viewModel.EmployeeSelectedDepartments = _mapper.Map<List<EmployeeDepartmentViewModel>>(_employeesRepository.GetDepartmentsOfEmployee(viewModel.EmployeeKey));
            viewModel.EmployeeSelectedDepartments.ForEach(department => department.IsSelected = true);
            PopulateUnselectedDepartments(viewModel);
        }

        private void PopulateUnselectedDepartments(EmployeeEditViewModel viewModel)
        {
            foreach (var department in _departmentsRepository.GetList())
            {
                if (!viewModel.EmployeeSelectedDepartments.Any(departmentViewModel => departmentViewModel.DepartmentId == department.Id))
                {
                    viewModel.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel() { DepartmentId = department.Id, DepartmentName = department.DepartmentName, IsSelected = false });
                }
            }
        }

        public override IEnumerable<Employee> GetAllEmployeesAsync()
        {
            var employee = _userManager.GetUserAsync(User).Result;
            return _employeesRepository.GetAllEmployeesOfBranch(employee.DefaultBranchId);
        }
    }
}
