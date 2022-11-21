using AutoMapper;
using Bumbo.Models.EmployeeManager;
using BumboData.Enums;
using BumboData.Models;
using BumboRepositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{

    [Authorize(Roles = "Administrator,Manager")]
    public class EmployeeManagerController : Controller
    {
        private UserManager<Employee> _userManager;
        private IEmployeeRepository _employeesRepository;
        private IMapper _mapper;
        private IBranchRepository _branchRepository;
        private IDepartmentsRepository _departmentsRepository;

        public EmployeeManagerController(UserManager<Employee> userManager, IEmployeeRepository employeeService, IMapper mapper, IBranchRepository branchService, IDepartmentsRepository departmentService)
        {
            _userManager = userManager;
            _employeesRepository = employeeService;
            _mapper = mapper;
            _branchRepository = branchService;
            _departmentsRepository = departmentService;

        }


        public IActionResult Index(string searchString, bool includeInactive, bool includeActive, EmployeeSortingOption currentSort)
        {

            EmployeeListIndexViewModel resultingListViewModel = new EmployeeListIndexViewModel();

            var employees = _employeesRepository.GetList();
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
                case EmployeeSortingOption.Name_Asc:
                    employees = employees.OrderBy(e => e.FirstName);
                    break;
                case EmployeeSortingOption.Name_Desc:
                    employees = employees.OrderByDescending(e => e.FirstName);
                    break;
                case EmployeeSortingOption.Function_Desc:
                    employees = employees.OrderByDescending(e => e.Function);
                    break;
                case EmployeeSortingOption.Function_Asc:
                    employees = employees.OrderBy(e => e.Function);
                    break;
                case EmployeeSortingOption.Birthdate_Asc:
                    employees = employees.OrderBy(e => e.Birthdate);
                    break;
                case EmployeeSortingOption.Birthdate_Desc:
                    employees = employees.OrderByDescending(e => e.Birthdate);
                    break;
                case EmployeeSortingOption.EmployeeSince_Asc:
                    employees = employees.OrderBy(e => e.EmployeeSince);
                    break;
                case EmployeeSortingOption.EmployeeSince_Desc:
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


            foreach (var d in _departmentsRepository.GetAllExistingDepartments().ToList())
            {
                employee.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel(d.Id, d.DepartmentName,
                    User.IsInRole(RoleType.ADMINISTRATOR.Name)));
            }

            if (User.IsInRole(RoleType.ADMINISTRATOR.Name))
            {
                employee.Function = "Manager";
                employee.Branches = _branchRepository.GetUnmanagedBranches();
            } else
            {
                employee.SelectedBranch = 1;
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(EmployeeCreateViewModel newEmployee, List<int> selectedDepartments)
        {
            // List of int 'selectedDepartments' contains the department ID's selected in the form.
            // we use those keys to get the correct departments from the department and add them to the new employee.
            if (selectedDepartments == null || selectedDepartments.Count() == 0)
            {
                ModelState.AddModelError("AllowedDepartments", "Geen afdelingen geselecteerd.");
            }

            if (ModelState.IsValid)
            {
                var employee = _mapper.Map<EmployeeCreateViewModel, Employee>(newEmployee);
                if (User.IsInRole(RoleType.ADMINISTRATOR.Name))
                {
                    employee.DefaultBranchId = (int)newEmployee.SelectedBranch;
                }
                else
                {
                    Employee manager = await _userManager.GetUserAsync(User);
                    employee.DefaultBranchId = manager.DefaultBranchId;
                    foreach (var selectedDep in selectedDepartments)
                    {
                        employee.AllowedDepartments.Add(_departmentsRepository.GetById(selectedDep));
                    }
                }

                if (_employeesRepository.Exists(employee))
                {
                    ModelState.AddModelError(string.Empty, "Deze gebruiker bestaat al met deze naam.");
                    return View();
                }

                _employeesRepository.Create(employee);
                if (User.IsInRole(RoleType.ADMINISTRATOR.Name))
                {
                    await _userManager.AddToRoleAsync(employee, RoleType.MANAGER.Name);
                    employee.DefaultBranch = _branchRepository.Get(employee.DefaultBranchId);
                    employee.DefaultBranch.Manager = employee;
                    _branchRepository.Update(employee.DefaultBranch);
                    await _userManager.AddToRoleAsync(employee, RoleType.MANAGER.Name);
                }
                else
                {
                    await _userManager.AddToRoleAsync(employee, RoleType.EMPLOYEE.Name);
                }
                return RedirectToAction("Index");

            }
            foreach (var d in _departmentsRepository.GetAllExistingDepartments().ToList())
            {
                newEmployee.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel(d.Id, d.DepartmentName, false));
            }
            return View(newEmployee);

        }

        public IActionResult Edit(string employeeKey)
        {
            EmployeeCreateViewModel employee = new EmployeeCreateViewModel();
            employee = _mapper.Map<Employee, EmployeeCreateViewModel>(_employeesRepository.Get(employeeKey));
            foreach (var d in _departmentsRepository.GetAllExistingDepartments().ToList())
            {
                employee.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel(d.Id, d.DepartmentName, _employeesRepository.EmployeeIsInDepartment(employeeKey, d.Id)));
            }

            employee.EmployeeKey = employeeKey;
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeCreateViewModel employee, List<int> selectedDepartments)
        {
            if (selectedDepartments == null || selectedDepartments.Count() == 0)
            {
                ModelState.AddModelError("AllowedDepartments", "Geen afdelingen geselecteerd.");
            }
            
            if (ModelState.IsValid)
            {
                var newEmployee = _mapper.Map<EmployeeCreateViewModel, Employee>(employee);
                foreach (var selectedDep in selectedDepartments)
                {
                    newEmployee.AllowedDepartments.Add(_departmentsRepository.GetById(selectedDep));
                }
                _employeesRepository.Update(newEmployee);
                return RedirectToAction("Index");

            }
            foreach (var d in _departmentsRepository.GetAllExistingDepartments().ToList())
            {
                employee.EmployeeSelectedDepartments.Add(new EmployeeDepartmentViewModel(d.Id, d.DepartmentName, _employeesRepository.EmployeeIsInDepartment(employee.EmployeeKey, d.Id)));
            }

            return View(employee);
        }

    }


}
