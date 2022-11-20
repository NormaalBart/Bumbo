using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public interface IDepartmentsRepository
    {
        IEnumerable<Department> GetAllExistingDepartments();
        Department GetById(int id);

    }
}
