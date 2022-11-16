using AutoMapper;
using Bumbo.Models;
using Bumbo.Models.EmployeeManager;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bumbo.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private IEmployee _employeesRepository;
        private IMapper _mapper;
        private IBranch _branchRepository;
        private IDepartments _departmentsRepository;
        public EmployeeManagerController(IEmployee employeeService, IMapper mapper, IBranch branchService, IDepartments departmentService)
        {
            _employeesRepository = employeeService;
            _mapper = mapper;
            _branchRepository = branchService;
            _departmentsRepository = departmentService; 

        }


        public IActionResult Index(string sortOrder, string searchString, bool includeInactive, bool includeActive, int? pageNumber)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            //ViewData["CurrentFilter"] = searchString;
            ViewData["IncludeInactive"] = includeInactive;
            ViewData["IncludeActive"] = includeActive;

            if (searchString != null)
            {
                pageNumber = 1;
            }

            EmployeeListIndexViewModel resultingListViewModel = new EmployeeListIndexViewModel();

            var employees = _employeesRepository.GetAll();
            if (!includeInactive && !includeActive)
            {
                employees = employees.Where(e => e.Active);
                resultingListViewModel.IncludeActive = true;
            }
            else if (!includeInactive && includeActive)
            {
                employees = employees.Where(e => e.Active);
            }
            else if (includeInactive && !includeActive)
            {
                employees = employees.Where(e => e.Active == false);
            }

           
            
            

            if (!String.IsNullOrEmpty(searchString))
            {
                // search in employees if any of the columns contains the searchstring
                resultingListViewModel.SearchString = searchString;
                searchString = searchString.ToLower();
                employees = employees.Where(e => e.FirstName.ToLower().Contains(searchString) || e.LastName.ToLower().Contains(searchString));
                
            }
            switch (sortOrder)
            {
                case "name_desc":
                    employees = employees.OrderByDescending(e => e.LastName);
                    break;
                //case "Date":
                //    employees = employees.OrderBy(e => e.);
                //    break;
                //case "date_desc":
                //    employees = employees.OrderByDescending(e => e.EmployeeJoinedCompany);
                //    break;
                default:
                    employees = employees.OrderBy(e => e.LastName);
                    break;
            }

            resultingListViewModel.Employees = _mapper.Map<IEnumerable<EmployeeListItemViewModel>>(employees).ToList();

            return View(resultingListViewModel);
        }
        
        public IActionResult Create()
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee.DepartmentSelectionList = _departmentsRepository.GetAllExistingDepartments().ToList();
            return View(employee);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeCreateViewModel newEmployee, List<int> AllowedDepartments)
        {
            // List of int 'AllowedDepartments' contains the department ID's selected in the form.
            // we use those keys to get the correct departments from the department and add them to the new employee.
            // Parameter name is 'AllowedDepartments' due to Form auto binding to make it easier.
            ModelState.Clear();
            TryValidateModel(newEmployee);
            if (ModelState.IsValid)
            {
   
                
                var e = _mapper.Map<EmployeeCreateViewModel, Employee>(newEmployee);
                e.DefaultBranch = _branchRepository.GetBranchOfUser();
                foreach (var selectedDep in AllowedDepartments)
                {
                    e.AllowedDepartments.Add(_departmentsRepository.GetById(selectedDep));
                }
                Console.WriteLine(e.AllowedDepartments.Count);
                _employeesRepository.Add(e);
                return RedirectToAction("Index");

            }
            
            return View(newEmployee);
            
        }
        
    } 
        
    
}
