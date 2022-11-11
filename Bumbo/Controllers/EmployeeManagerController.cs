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

        public IActionResult Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            // The list will only show the following items: 'Name, Department, Function, Region, Employee since, Active' as is determined
            // in the use case. 


            var employees = _employeesRepository.GetAll();


            if (!String.IsNullOrEmpty(searchString))
            {
                // search in employees if any of the columns contains the searchstring
                searchString = searchString.ToLower();
                employees = employees.Where(e => e.FirstName.ToLower().Contains(searchString) || e.LastName.ToLower().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    employees = employees.OrderByDescending(e => e.LastName);
                    break;
                case "Date":
                    employees = employees.OrderBy(e => e.EmployeeJoinedCompany);
                    break;
                case "date_desc":
                    employees = employees.OrderByDescending(e => e.EmployeeJoinedCompany);
                    break;
                default:
                    employees = employees.OrderBy(e => e.LastName);
                    break;
            }


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
