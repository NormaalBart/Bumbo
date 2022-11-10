using BumboData.Enums;
using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IEmployee 
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);

        IEnumerable<Departments> GetDepartmentsOfEmployee(int id);

    }
}
