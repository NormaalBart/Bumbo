using BumboData;
using BumboData.Models;
using BumboRepositories.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboRepositories
{
    public class WorkedShiftRepository : IWorkedShiftRepository
    {
        private BumboContext _context;

        public WorkedShiftRepository(BumboContext context)
        {
            this._context = context;
        }

        public void Add(WorkedShift workedShift)
        {
            _context.WorkedShifts.Add(workedShift);
            _context.SaveChanges();
        }

        public IEnumerable<WorkedShift> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkedShift GetById(string id)
        {
            throw new NotImplementedException();
        }

        public WorkedShift LastWorkedShiftWithNoEndTime(Employee employee)
        {
            return _context.WorkedShifts.Where(o => o.Employee == employee && o.EndTime == null)
                       .OrderByDescending(o => o.StartTime)
                       .FirstOrDefault();
        }

        public void Update(WorkedShift workedShift)
        {
            _context.WorkedShifts.Update(workedShift);
            _context.SaveChanges();
        }
    }
}
