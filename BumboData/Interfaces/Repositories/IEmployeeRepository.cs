using BumboData.Enums;
using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee, string>
    {

        IEnumerable<Department> GetDepartmentsOfEmployee(string id);
        Employee GetByEmail(string email);
        IEnumerable<Employee> GetAllManagers();
        IEnumerable<Employee> GetAllManagers(int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc);
        IEnumerable<Employee> GetAllThatWorkedOrWasPlannedOnDate(DateTime date, int branchId);
        IEnumerable<Employee> GetAllEmployeesOfBranch(int defaultBranchId);
        IEnumerable<Employee> GetAllEmployeesOfBranch(int branch, int start = 0, int amount = int.MaxValue, string searchString = "", bool includeActive = true, bool includeInactive = false, EmployeeSortingOption sortingOption = EmployeeSortingOption.Name_Asc);
        bool EmployeeIsInDepartment(string employeeKey, int id);
        bool Exists(Employee newEmployee);
        public void Import(List<Employee> employees);
    }
}
