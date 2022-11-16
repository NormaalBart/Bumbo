using BumboData.Models;

namespace BumboData
{
    public interface IEmployee 
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(string id);
        void Add(Employee employee);

        void Update(Employee employee);

        IEnumerable<Department> GetDepartmentsOfEmployee(string id);

    }
}
