using AutoMapper;
using Bumbo.Models.EmployeeManager.EmployeeCreate;
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
            throw new NotImplementedException();
        }

        public IActionResult Create(BaseEditViewModel baseCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(string id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(BaseEditViewModel baseCreateEditModel)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Employee> GetAllEmployeesAsync()
        {
            return _employeesRepository.GetAllManagers();
        }
    }
}
