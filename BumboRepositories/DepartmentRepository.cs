using BumboData;
using BumboData.Models;
using BumboRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
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
