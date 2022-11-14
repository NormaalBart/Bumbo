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

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Include(e => e.AllowedDepartments).Where(e => e.Key == id).FirstOrDefault();
        }

        public IEnumerable<Department> GetDepartmentsOfEmployee(string id)
        {
            // return _context.Employees.Where(e => e.Id == id).Include(e => e.Departments).SelectMany(e => e.Departments);
            throw new NotImplementedException();
        }


    }
}
