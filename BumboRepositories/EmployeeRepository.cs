using BumboData;
using BumboData.Enums;
using BumboData.Models;
using BumboRepositories.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private BumboContext _context;

        public EmployeeRepository(BumboContext context)
        {
            this._context = context;
        }

        public string GetIdOfEmployeeLoggedIn()
        {
            return _context.Employees.FirstOrDefault().Id;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public IEnumerable<Employee> GetAll(int branchId)
        {
            return _context.Employees.Where(m=> m.DefaultBranchId == branchId).ToList();
        }

        public Employee GetById(string id)
        {
            return _context.Employees.Include(e => e.AllowedDepartments).Where(e => e.Id == id).FirstOrDefault();
        }

        public bool EmployeeIsInDepartment(string employeeId, int departmentId)
        {
            // returns bool if an employee has a department with the department id
            return _context.Employees.Where(e => e.Id == employeeId).Include(e => e.AllowedDepartments).Any(e => e.AllowedDepartments.Any(d => d.Id == departmentId));

        }

        public Employee GetByEmail(string emailAddress)
        {
            return _context.Employees.Include(e => e.AllowedDepartments).Where(e => e.NormalizedEmail == emailAddress.ToUpper()).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAllManagers()
        {
            var users = _context.UserRoles.Where(role => role.RoleId == RoleType.MANAGER.RoleId).Select(role => role.UserId).ToList();
            return _context.Employees.Where(employee => users.Contains(employee.Id));
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return _context.Employees.Where(employee => employee.DefaultBranchId == branch);
        }

        public void Update(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            return _context.Employees.Where(e => e.Id == id).Include(e => e.AllowedDepartments).FirstOrDefault().AllowedDepartments;
        }

        public bool Exists(Employee newEmployee)
        {
            return _context.Employees.Where(e => e.NormalizedEmail == newEmployee.NormalizedEmail || e.NormalizedUserName == newEmployee.NormalizedUserName).Any();
        }
    }
}
