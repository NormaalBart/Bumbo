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
            var viewModel = new EmployeeCreateViewModel();
            return View("Views/EmployeeManager/Manager/Create.cshtml", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BaseCreateViewModel baseCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(string id)
        {
            var employee = _employeesRepository.Get(id);
            var viewModel = _mapper.Map<EmployeeCreateViewModel>(employee);
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
        public IActionResult Edit(EmployeeCreateViewModel employeeCreateEditModel, List<int> selectedDepartments )
        {
            var employee = _mapper.Map<Employee>(employeeCreateEditModel);
            foreach(var departmentId in selectedDepartments)
            {
                var department = _departmentsRepository.Get(departmentId);
                employee.AllowedDepartments.Add(department);
            }
            _employeesRepository.Update(employee);
            return RedirectToAction(nameof(Index));
        }

        public override IEnumerable<Employee> GetAllEmployeesAsync()
        {
            var employee = _userManager.GetUserAsync(User).Result;
            return _employeesRepository.GetAllEmployeesOfBranch(employee.DefaultBranchId);
        }
    }
}
