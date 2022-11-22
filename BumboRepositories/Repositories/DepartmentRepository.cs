using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentsRepository
    {
        public DepartmentRepository(BumboContext context): base(context)
        {
        }

        public Department GetById(int id)
        {
            return DbSet.Where(d => d.Id == id).Include(d => d.AllowedEmployees).FirstOrDefault();
        }
    }
}
