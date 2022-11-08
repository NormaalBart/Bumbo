using AutoMapper;
using Bumbo.Models.EmployeeManager;
using BumboData;
using BumboData.Enums;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private IEmployee _employeesRepository;
        private IMapper _mapper;
        public EmployeeManagerController(IEmployee employeeService, IMapper mapper)
        {
            _employeesRepository = employeeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var employees = _employeesRepository.GetAll();
            EmployeeListIndexViewModel list = new EmployeeListIndexViewModel();
            list.Employees = _mapper.Map<IEnumerable<EmployeeListItemViewModel>>(employees).ToList();
            
            return View(list);
        }

        public IActionResult Create()
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee.BirthDate = DateTime.Now.AddYears(-18);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeCreateViewModel newEmployee)
        {
            if (ModelState.IsValid)
            {
                var e = _mapper.Map<EmployeeCreateViewModel, Employee>(newEmployee);
                //e.Departments.Add(new Departments());
                if (newEmployee.InCassiereDep)
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
                }
                _employeesRepository.Add(e);
                return RedirectToAction("Index");

            }
            
            return View(newEmployee);
            
        }
        
    } 
        
    
}
