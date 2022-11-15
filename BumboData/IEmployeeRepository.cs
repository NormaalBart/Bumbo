using BumboData.Models;

namespace BumboData
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(string id);
        void Add(Employee employee);

        IEnumerable<Department> GetDepartmentsOfEmployee(string id);

        Employee GetByEmail(string email);

    }
}
