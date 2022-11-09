using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BumboServices
{
    public class PlannedShiftsRepository : IPlannedShifts
    {
        private MyContext _context;

        public PlannedShiftsRepository(MyContext context)
        {
            _context = context;
        }
        

        public void Add(PlannedShift plannedShift)
        {
            // db complains about foreign key being null
            plannedShift.Employee = _context.Employees.Where(e => e.Id == plannedShift.EmployeeId).FirstOrDefault();
            plannedShift.PrognosisDay = _context.Prognosis.Where(p => p.Id == plannedShift.PrognosisId).FirstOrDefault();

            _context.PlannedShift.Add(plannedShift);
            _context.SaveChanges();
        }

        public IEnumerable<PlannedShift> GetAll()
        {
            return _context.PlannedShift.Include(p => p.Employee).Include(p => p.PrognosisDay);
        }

        public WorkedShift GetById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetHoursPlannedInWorkWeek(int employeeId, DateTime currentDate)
        {
            // start of week, calculated by getting the difference between the date and monday.
            int diff = DayOfWeek.Monday - currentDate.DayOfWeek;
            if (diff > 0)
                diff -= 7;
            var startOfWeek = currentDate.AddDays(diff);
            // check if the employee has worked too much this week 
            var shiftsThisWeek = _context.PlannedShift.Where(p => p.EmployeeId == employeeId && p.StartTime.Date >= startOfWeek && p.StartTime.Date <= startOfWeek.AddDays(6)).ToList();
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

        public IEnumerable<PlannedShift> GetShiftsOfEmployeeOnDate(DateTime date, int employeeId)
        {

            return _context.PlannedShift.Where(p => p.EmployeeId == employeeId && p.StartTime.Date == date);
        }

        public bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift)
        {
            var overlappingShifts = _context.PlannedShift.Where(p => p.EmployeeId == plannedShift.EmployeeId && p.StartTime.Date == plannedShift.StartTime.Date).ToList();
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
