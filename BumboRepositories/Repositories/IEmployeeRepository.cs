using BumboData.Models;
using System.Collections.Generic;

namespace BumboData
{
    public interface IEmployeeRepository
    {

        Employee GetById(string id);

        void Add(Employee employee);

        IEnumerable<Department> GetDepartmentsOfEmployee(string id);

        Employee GetByEmail(string email);

        IEnumerable<Employee> GetAllManagers();
        IEnumerable<Employee> GetAllEmployeesOfBranch(int defaultBranchId);
        object GetAll();
    }
}
