using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IDepartmentsRepository: IRepository<Department>
    {
        Department GetById(int id);
    }
}
