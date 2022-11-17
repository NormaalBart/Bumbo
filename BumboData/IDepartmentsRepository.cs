using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IDepartmentsRepository
    {
        IEnumerable<Department> GetAllExistingDepartments();
        Department GetById(int id);
        
    }
}
