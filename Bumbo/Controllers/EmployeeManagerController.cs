using AutoMapper;
using Bumbo.Models;
using Bumbo.Models.EmployeeManager;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;
using BumboData.Enums;

namespace Bumbo.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private IEmployee _employeesRepository;
        private IMapper _mapper;
        private IBranchRepository _branchRepository;
        private IDepartmentsRepository _departmentsRepository;
        public EmployeeManagerController(IEmployee employeeService, IMapper mapper, IBranchRepository branchService, IDepartmentsRepository departmentService)
        {
            _employeesRepository = employeeService;
            _mapper = mapper;
            _branchRepository = branchService;
            _departmentsRepository = departmentService; 

        }


        public IActionResult Index(string searchString, bool includeInactive, bool includeActive, SortingOption currentSort)
        {

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

            switch (currentSort)
            {
                // case for each sortingoption, with asc and desc
                case SortingOption.Name_Asc:
                    employees = employees.OrderBy(e => e.FirstName);
                    break;
                case SortingOption.Name_Desc:
                    employees = employees.OrderByDescending(e => e.FirstName);
                    break;
                case SortingOption.Function_Desc:
                    employees = employees.OrderByDescending(e => e.Function);
                    break;
                case SortingOption.Function_Asc:
                    employees = employees.OrderBy(e => e.Function);
                    break;
                case SortingOption.Birthdate_Asc:
                    employees = employees.OrderBy(e => e.Birthdate);
                    break;
                case SortingOption.Birthdate_Desc:
                    employees = employees.OrderByDescending(e => e.Birthdate);
                    break;
                case SortingOption.EmployeeSince_Asc:
                    employees = employees.OrderBy(e => e.EmployeeSince);
                    break;
                case SortingOption.EmployeeSince_Desc:
                    employees = employees.OrderByDescending(e => e.EmployeeSince);
                    break;
                default: 
                    employees = employees.OrderBy(e => e.FirstName);
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
                _employeesRepository.Add(e);
                return RedirectToAction("Index");

            }
            
            return View(newEmployee);
            
        }

        public IActionResult Edit(string employeeKey)
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee = _mapper.Map<Employee, EmployeeCreateViewModel>(_employeesRepository.GetById(employeeKey));
            employee.DepartmentSelectionList = _departmentsRepository.GetAllExistingDepartments().ToList();
            employee.EmployeeKey = employeeKey;
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeCreateViewModel employee, List<int> AllowedDepartments)
        {
            ModelState.Clear();
            TryValidateModel(employee);
            if (ModelState.IsValid)
            {
                var newEmployee = _mapper.Map<EmployeeCreateViewModel, Employee>(employee);
                foreach (var selectedDep in AllowedDepartments)
                {
                    newEmployee.AllowedDepartments.Add(_departmentsRepository.GetById(selectedDep));
                }
                _employeesRepository.Update(newEmployee);
                return RedirectToAction("Index");

            }

            return View(employee);
        }

    } 
        
    
}
