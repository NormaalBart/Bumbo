using BumboData;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class EmployeeRepository : Repository<Employee, string>, IEmployeeRepository
    {
        public EmployeeRepository(BumboContext context) : base(context)
        {
        }

        public bool EmployeeIsInDepartment(string employeeId, int departmentId)
        {
            // returns bool if an employee has a department with the department id
            return DbSet.Where(e => e.Id == employeeId).Include(e => e.AllowedDepartments)
                .Any(e => e.AllowedDepartments.Any(d => d.Id == departmentId));
        }

        public Employee GetByEmail(string emailAddress)
        {
            return DbSet.Include(e => e.AllowedDepartments).Where(e => e.NormalizedEmail == emailAddress.ToUpper())
                .FirstOrDefault();
        }

        public IEnumerable<Employee> GetAllManagers()
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId)
                .Select(role => role.UserId).ToList();
            return DbSet.Where(employee => users.Contains(employee.Id));
        }

        public IEnumerable<Employee> GetAllManagers(int start, int amount)
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId)
                .Select(role => role.UserId).Skip(start).Take(amount);
            return DbSet.Where(employee => users.Contains(employee.Id)).ToList();
        }

        public IEnumerable<Employee> GetAllManagers(int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc)
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId)
                .Select(role => role.UserId).ToList();

            var employees = DbSet.Where(employee => users.Contains(employee.Id));
            return SortAndOrderBy(start, amount, searchString, includeActive, includeInactive, sortingOption, employees);
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return DbSet.Where(employee => employee.DefaultBranchId == branch).ToList();
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch, int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc)
        {
            var employees = DbSet.Where(employee => employee.DefaultBranchId == branch);
            return SortAndOrderBy(start, amount, searchString, includeActive, includeInactive, sortingOption, employees);
        }

        private static IEnumerable<Employee> SortAndOrderBy(int start, int amount, string searchString, bool includeActive, bool includeInactive, EmployeeSortingOption sortingOption, IQueryable<Employee> employees)
        {
            if (!includeInactive && !includeActive)
            {
                employees = employees.Where(e => e.Active);
            }
            else if (!includeInactive && includeActive)
            {
                employees = employees.Where(e => e.Active);
            }
            else if (includeInactive && !includeActive)
            {
                employees = employees.Where(e => !e.Active);
            }


            if (!string.IsNullOrEmpty(searchString))
            {
                // search in employees if any of the columns contains the searchstring
                searchString = searchString.ToLower();
                employees = employees.Where(e => e.FirstName.ToLower().Contains(searchString) || e.LastName.ToLower().Contains(searchString));
            }

            switch (sortingOption)
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

            return employees.Skip(start).Take(amount).ToList();
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            return DbSet.Where(e => e.Id == id).Include(e => e.AllowedDepartments).FirstOrDefault().AllowedDepartments;
        }

        public bool Exists(Employee newEmployee)
        {
            return DbSet.Where(e =>
                e.NormalizedEmail == newEmployee.NormalizedEmail ||
                e.NormalizedUserName == newEmployee.NormalizedUserName).Any();
        }

        public override Employee? Get(string id)
        {
            return DbSet.Where(e => e.Id == id).Include(e => e.AllowedDepartments).First();
        }

        public void Import(List<Employee> employees)
        {
            DbSet.AddRange(employees);
            Context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllThatWorkedOrWasPlannedOnDate(DateTime date, int branchId)
        {
            return DbSet.Include(e => e.PlannedShifts.Where(p => p.StartTime.Date == date.Date && p.BranchId == branchId)).Include(e => e.WorkedShifts.Where(w => w.StartTime.Date == date.Date && w.EndTime != null && w.BranchId == branchId)).ToList().Where(e => e.PlannedShifts.Any() || e.WorkedShifts.Any());
        }
    }
}