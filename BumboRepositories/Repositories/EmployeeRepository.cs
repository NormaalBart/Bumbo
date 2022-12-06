using BumboData;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
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

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return DbSet.Where(employee => employee.DefaultBranchId == branch).ToList();
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