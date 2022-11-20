using BumboData;
using BumboData.Models;
using BumboRepositories.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class DepartmentRepository : IDepartmentsRepository
    {
        private BumboContext _context;
        public DepartmentRepository(BumboContext context)
        {
            this._context = context;
        }

        public IEnumerable<Department> GetAllExistingDepartments()
        {
            return _context.Departments;
        }

        public Department GetById(int id)
        {
            return _context.Departments.Where(d => d.Id == id).Include(d => d.AllowedEmployees).FirstOrDefault();
        }
    }
}
