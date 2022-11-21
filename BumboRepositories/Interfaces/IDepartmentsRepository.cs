using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IDepartmentsRepository
    {
        IEnumerable<Department> GetAllExistingDepartments();
        Department GetById(int id);

    }
}
