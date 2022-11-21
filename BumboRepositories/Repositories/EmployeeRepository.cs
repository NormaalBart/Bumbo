using BumboData;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class EmployeeRepository : Repository<Employee, string>, IEmployeeRepository
    {
        public EmployeeRepository(BumboContext context): base(context)
        {
        }

        public string GetIdOfEmployeeLoggedIn()
        {
            return DbSet.FirstOrDefault().Id;
        }

        public bool EmployeeIsInDepartment(string employeeId, int departmentId)
        {
            // returns bool if an employee has a department with the department id
            return DbSet.Where(e => e.Id == employeeId).Include(e => e.AllowedDepartments).Any(e => e.AllowedDepartments.Any(d => d.Id == departmentId));

        }

        public Employee GetByEmail(string emailAddress)
        {
            return DbSet.Include(e => e.AllowedDepartments).Where(e => e.NormalizedEmail == emailAddress.ToUpper()).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAllManagers()
        {
            var users = Context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId).Select(role => role.UserId).ToList();
            return DbSet.Where(employee => users.Contains(employee.Id));
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return DbSet.Where(employee => employee.DefaultBranchId == branch);
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            return DbSet.Where(e => e.Id == id).Include(e => e.AllowedDepartments).FirstOrDefault().AllowedDepartments;
        }

        public bool Exists(Employee newEmployee)
        {
            return DbSet.Where(e => e.NormalizedEmail == newEmployee.NormalizedEmail || e.NormalizedUserName == newEmployee.NormalizedUserName).Any();
        }
    }
}
