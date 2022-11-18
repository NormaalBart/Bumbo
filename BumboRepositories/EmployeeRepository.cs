using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class EmployeeRepository : IEmployee
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
            return _context.Employees;
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

        public void Update(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }
    }
}
