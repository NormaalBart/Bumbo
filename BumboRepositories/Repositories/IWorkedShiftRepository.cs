using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboRepositories.Repositories
{
    public interface IWorkedShiftRepository
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAll();
        WorkedShift GetById(string id);
        void Add(WorkedShift workedShift);
        void Update(WorkedShift workedShift);
    }
}
