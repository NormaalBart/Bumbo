using BumboData;
using BumboData.Models;
using BumboRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class WorkedShiftRepository : Repository<WorkedShift>, IWorkedShiftRepository
    {
        public WorkedShiftRepository(BumboContext context) : base(context)
        {
        }
        
        public IEnumerable<WorkedShift> GetAllApproved()
        {
            return DbSet.Where(s => s.Approved).ToList();
        }

        public WorkedShift LastWorkedShiftWithNoEndTime(Employee employee)
        {
            return DbSet.Where(o => o.Employee == employee && o.EndTime == null)
                .OrderByDescending(o => o.StartTime)
                .FirstOrDefault();
        }

        public List<WorkedShift> GetWorkedShiftsInMonth(string employee, int year, int month)
        {
            return DbSet.Include(i => i.Employee).Where(s =>
                s.Employee.Id == employee && s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }

        public List<WorkedShift> GetWorkedShiftsInMonth(int year, int month)
        {
            return DbSet.Include(i => i.Employee)
                .Where(s => s.StartTime.Year == year && s.StartTime.Month == month).ToList();
        }
    }
}