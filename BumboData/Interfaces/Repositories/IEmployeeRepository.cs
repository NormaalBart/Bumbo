using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IEmployeeRepository: IRepository<Employee, string>
    {

        IEnumerable<Department> GetDepartmentsOfEmployee(string id);
        Employee GetByEmail(string email);
        IEnumerable<Employee> GetAllManagers();
        IEnumerable<Employee> GetAllEmployeesOfBranch(int defaultBranchId);
        bool EmployeeIsInDepartment(string employeeKey, int id);
        bool Exists(Employee newEmployee);
    }
}
