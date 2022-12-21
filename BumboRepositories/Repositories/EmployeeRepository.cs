using System.Linq.Expressions;
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
        
        public List<Employee> Search(int? branchId, string query)
        {
            return DbSet
                .Where(e => (e.FirstName + e.LastName).Contains(query))
                .Where(e=>branchId == null || e.DefaultBranchId == branchId).ToList();
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

        public IEnumerable<Employee> GetAllManagers(int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc)
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId)
                .Select(role => role.UserId).ToList();

            var employees = DbSet.Where(employee => users.Contains(employee.Id));
            return SortAndOrderBy(start, amount, searchString, includeActive, includeInactive, sortingOption, employees);
        }
        public int GetAmountOfManagers(string searchString = "", bool includeActive = true, bool includeInactive = false)
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId)
                .Select(role => role.UserId).ToList();
            var employees = DbSet.Where(employee => users.Contains(employee.Id));
            return SortAndOrderBy(0, int.MaxValue, searchString, includeActive, includeInactive, EmployeeSortingOption.Name_Asc, employees).Count();
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return DbSet.Where(employee => employee.DefaultBranchId == branch).Include(e=>e.AllowedDepartments).ToList();
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch, int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc)
        {
            var employees = DbSet.Where(employee => employee.DefaultBranchId == branch);
            return SortAndOrderBy(start, amount, searchString, includeActive, includeInactive, sortingOption, employees).ToList();
        }
        public int GetAmountOfEmployeesOfBranch(int branch, string searchString = "", bool includeActive = true, bool includeInactive = false)
        {
            var employees = DbSet.Where(employee => employee.DefaultBranchId == branch);
            return SortAndOrderBy(0, int.MaxValue, searchString, includeActive, includeInactive, EmployeeSortingOption.Name_Asc, employees).Count();
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

            employees = sortingOption switch
            {
                // case for each sortingoption, with asc and desc
                EmployeeSortingOption.Name_Asc => employees.OrderBy(e => e.FirstName),
                EmployeeSortingOption.Name_Desc => employees.OrderByDescending(e => e.FirstName),
                EmployeeSortingOption.Function_Desc => employees.OrderByDescending(e => e.Function),
                EmployeeSortingOption.Function_Asc => employees.OrderBy(e => e.Function),
                EmployeeSortingOption.Birthdate_Asc => employees.OrderBy(e => e.Birthdate),
                EmployeeSortingOption.Birthdate_Desc => employees.OrderByDescending(e => e.Birthdate),
                EmployeeSortingOption.EmployeeSince_Asc => employees.OrderBy(e => e.EmployeeSince),
                EmployeeSortingOption.EmployeeSince_Desc => employees.OrderByDescending(e => e.EmployeeSince),
                _ => employees.OrderBy(e => e.FirstName)
            };

            return employees.Skip(start).Take(amount);
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            return DbSet.Where(e => e.Id == id).Include(e => e.AllowedDepartments).FirstOrDefault()?.AllowedDepartments;
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