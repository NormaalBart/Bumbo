using BumboData;
using BumboData.Models;
using BumboRepositories.Repositories;
using Microsoft.EntityFrameworkCore;

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
            return _context.WorkedShifts.ToList();
        }
        
        public IEnumerable<WorkedShift> GetAllApproved()
        {
            return _context.WorkedShifts.Where(s=>s.Approved).ToList();
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

        public List<WorkedShift> GetWorkedShiftsInMonth(string employee, int year, int month)
        {
            return _context.WorkedShifts.Include(i => i.Employee).Where(s =>
                s.Employee.Id == employee && s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }
        
        public List<WorkedShift> GetWorkedShiftsInMonth(int year, int month)
        {
            return _context.WorkedShifts.Include(i => i.Employee)
                .Where(s => s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }

        public void Update(WorkedShift workedShift)
        {
            _context.WorkedShifts.Update(workedShift);
            _context.SaveChanges();
        }
    }
}
