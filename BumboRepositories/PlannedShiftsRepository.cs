using BumboData;
using BumboData.Models;
using BumboRepositories.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class PlannedShiftsRepository : IPlannedShiftsRepository
    {
        private BumboContext _context;

        public PlannedShiftsRepository(BumboContext context)
        {
            _context = context;
        }
        

        public void Add(PlannedShift plannedShift)
        {
            // db complains about foreign key being null
            plannedShift.Employee = _context.Employees.Where(e => e.Id == plannedShift.Employee.Id).FirstOrDefault();

            _context.PlannedShifts.Add(plannedShift);
            _context.SaveChanges();
        }

        public IEnumerable<PlannedShift> GetAll()
        {
            return _context.PlannedShifts.Include(p => p.Employee);
        }

        public WorkedShift GetById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate)
        {
            // start of week, calculated by getting the difference between the date and monday.
            int diff = DayOfWeek.Monday - currentDate.DayOfWeek;
            if (diff > 0)
                diff -= 7;
            var startOfWeek = currentDate.AddDays(diff);
            // check if the employee has worked too much this week 
            var shiftsThisWeek = _context.PlannedShifts.Where(p => p.Employee.Id == employeeId && p.StartTime.Date >= startOfWeek && p.StartTime.Date <= startOfWeek.AddDays(6)).ToList();
            if (shiftsThisWeek.Count > 0)
            {
                double totalHoursThisWeek = 0;
                foreach (var shift in shiftsThisWeek)
                {
                    totalHoursThisWeek += (shift.EndTime - shift.StartTime).TotalHours;
                }
                return totalHoursThisWeek;
            }
            return 0;

        }

        public IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId)
        {
            // returns the next 7 days.
            return _context.PlannedShifts.Where(p => p.Employee.Id == employeeId && p.StartTime.Date >= date && p.StartTime <= date.AddDays(7)).Include(p => p.Department).Include(p => p.Branch);
        }

        public bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift)
        {
            var overlappingShifts = _context.PlannedShifts.Where(p => p.Employee.Id == plannedShift.Employee.Id && p.StartTime.Date == plannedShift.StartTime.Date).ToList();
            if (overlappingShifts.Count > 0)
            {
                foreach (var shift in overlappingShifts)
                {
                    if (plannedShift.StartTime < shift.EndTime && plannedShift.EndTime > shift.StartTime)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
