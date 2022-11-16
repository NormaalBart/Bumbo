using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BumboRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private BumboContext _context;

        public EmployeeRepository(BumboContext context)
        {
            this._context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees;
        }

        public Employee GetById(string id)
        {
            return _context.Employees.Include(e => e.AllowedDepartments).Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            // return _context.Employees.Where(e => e.Id == id).Include(e => e.Departments).SelectMany(e => e.Departments);
            throw new NotImplementedException();
        }

        public Employee GetByEmail(string emailAddress)
        {
            return _context.Employees.Include(e => e.AllowedDepartments).Where(e => e.Email.ToUpper() == emailAddress.ToUpper()).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAllManagers()
        {
            var users = _context.UserRoles.Where(role => role.RoleId == "2").Select(role=> role.UserId).ToList();
            return _context.Employees.Where(employee => users.Contains(employee.Id));
        }

        public IEnumerable<Employee> GetAllEmployeesOfBranch(int branch)
        {
            return _context.Employees.Where(employee => employee.DefaultBranchId == branch);
        }

        object IEmployeeRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
