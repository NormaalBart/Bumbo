using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IDepartmentsRepository: IRepository<Department>
    {
        Department GetById(int id);
    }
}
