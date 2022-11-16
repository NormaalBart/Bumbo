using AutoMapper;
using Bumbo.Models.EmployeeManager;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bumbo.Controllers
{

    [Authorize(Roles = "Administrator,Manager")]
    public class EmployeeManagerController : Controller
    {
        private IEmployeeRepository _employeesRepository;
        private IMapper _mapper;

        public EmployeeManagerController(IEmployeeRepository employeeService, IMapper mapper)
        {
            _employeesRepository = employeeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employees;
            if (User.IsInRole("Administrator"))
            {
                employees = _employeesRepository.GetAllManagers();
            }
            else
            {
                var currentUserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Employee manager = _employeesRepository.GetById(currentUserID);
                employees = _employeesRepository.GetAllEmployeesOfBranch(manager.DefaultBranchId);
            }
            EmployeeListIndexViewModel list = new EmployeeListIndexViewModel();
            list.Employees = _mapper.Map<IEnumerable<EmployeeListItemViewModel>>(employees).ToList();
            return View(list);
        }

        public IActionResult CreateEmployee()
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee.BirthDate = DateTime.Now.AddYears(-18);
            return View(employee);
        }

        public IActionResult CreateManager()
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee.BirthDate = DateTime.Now.AddYears(-18);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEmployee(EmployeeCreateViewModel newEmployee)
        {
            if (ModelState.IsValid)
            {
                var e = _mapper.Map<EmployeeCreateViewModel, Employee>(newEmployee);
                //e.Departments.Add(new Departments());
                // TODO: Redo this code since departments are now stored in the database
                /*if (newEmployee.InCassiereDep)
                {
                    e.Departments.Add(new Departments(e.Id, DepartmentEnum.Cassiere));
                }
                if (newEmployee.InStockersDep)
                {
                    e.Departments.Add(new Departments(e.Id, DepartmentEnum.Stocker));
                }
                if (newEmployee.InFreshDep)
                {
                    e.Departments.Add(new Departments(e.Id, DepartmentEnum.Fresh));
                }*/
                _employeesRepository.Add(e);
                return RedirectToAction("Index");

            }

            return View(newEmployee);

        }

    }


}
