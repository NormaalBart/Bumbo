using AutoMapper;
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

        public override IActionResult Create()
        {
            throw new NotImplementedException();
        }

        public override IActionResult Create(BaseCreateViewModel baseCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public override IActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        public override IActionResult Edit(BaseCreateViewModel baseCreateEditModel)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Employee> GetAllEmployeesAsync()
        {
            var employee = _userManager.GetUserAsync(User).Result;
            return _employeesRepository.GetAllEmployeesOfBranch(employee.DefaultBranchId);
        }
    }
}
