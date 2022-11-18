using BumboData.Models;

namespace BumboData
{
    public interface IEmployee 
    {
        string GetIdOfEmployeeLoggedIn();
        IEnumerable<Employee> GetAll();
        Employee GetById(string id);
        void Add(Employee employee);

        void Update(Employee employee);

        bool EmployeeIsInDepartment(string employeeId, int departmentId);

    }
}
