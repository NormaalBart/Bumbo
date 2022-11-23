using AutoMapper;
using Bumbo.Models.EmployeeManager;
using Bumbo.Models.EmployeeManager.EmployeeCreate;
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
            var viewModel = new EmployeeEditViewModel();
            return View("Views/EmployeeManager/Manager/Create.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BaseEditViewModel baseCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = _mapper.Map<EmployeeEditViewModel>(employee);
            viewModel.EmployeeSelectedDepartments.ForEach(department => department.IsSelected = true);
            foreach (var department in _departmentsRepository.GetList())
            {
                if (!viewModel.EmployeeSelectedDepartments.Any(departmentViewModel => departmentViewModel.DepartmentId == department.Id))
                {
                    viewModel.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel() { DepartmentId = department.Id, DepartmentName = department.DepartmentName, IsSelected = false });
                }
            }
            return View("Views/EmployeeManager/Manager/Edit.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeEditViewModel employeeCreateEditModel, List<int> selectedDepartments)
        {
            if (!ModelState.IsValid)
            {
                if (selectedDepartments.Count == 0)
                {
                    ModelState.AddModelError("EmployeeSelectedDepartments", "Er moet minimaal 1 department zijn geselecteerd");
                }
                PopulateDepartments(employeeCreateEditModel);
                return View("Views/EmployeeManager/Manager/Edit.cshtml", employeeCreateEditModel);
            }
            if (selectedDepartments.Count == 0)
            {
                PopulateDepartments(employeeCreateEditModel);
                ModelState.AddModelError("EmployeeSelectedDepartments", "Er moet minimaal 1 department zijn geselecteerd");
                return View("Views/EmployeeManager/Manager/Edit.cshtml", employeeCreateEditModel);
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
