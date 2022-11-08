using BumboData;
using BumboData.Enums;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboServices
{
    public class EmployeeService : IEmployee
    {
        private MyContext _context;
        public EmployeeService(MyContext context)
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
            return _context.Employees.Include(e => e.Departments).Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<Departments> GetDepartmentsOfEmployee(int id)
        {
            // return _context.Employees.Where(e => e.Id == id).Include(e => e.Departments).SelectMany(e => e.Departments);
            throw new NotImplementedException();
        }


    }
}
