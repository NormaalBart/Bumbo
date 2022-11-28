using System.Globalization;
using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class PlannedShiftsRepository : Repository<PlannedShift>, IPlannedShiftsRepository
    {
        public PlannedShiftsRepository(BumboContext context) : base(context)
        {
        }

        public override PlannedShift Create(PlannedShift entity)
        {
            // db complains about foreign key being null
            entity.Employee = Context.Employees.Where(e => e.Id == (entity.EmployeeId ?? entity.Employee.Id))
                .FirstOrDefault();
            return base.Create(entity);
        }

        public override IEnumerable<PlannedShift> GetList()
        {
            return Context.PlannedShifts.Include(p => p.Employee);
        }

        public double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate)
        {
            // start of week, calculated by getting the difference between the date and monday.
            int diff = DayOfWeek.Monday - currentDate.DayOfWeek;
            if (diff > 0)
                diff -= 7;
            var startOfWeek = currentDate.AddDays(diff);
            // check if the employee has worked too much this week 
            var shiftsThisWeek = DbSet.Where(p =>
                p.Employee.Id == employeeId && p.StartTime.Date >= startOfWeek &&
                p.StartTime.Date <= startOfWeek.AddDays(6)).ToList();
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
            return DbSet
                .Where(p => p.Employee.Id == employeeId && p.StartTime.Date >= date && p.StartTime <= date.AddDays(7))
                .Include(p => p.Department).Include(p => p.Branch);
        }

        public bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift)
        {
            var overlappingShifts = DbSet.Where(p =>
                p.Employee.Id == plannedShift.Employee.Id && p.StartTime.Date == plannedShift.StartTime.Date).ToList();
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

        public List<PlannedShift> GetShiftsByWeek(int branchId, int year, int week)
        {
            var cal = new GregorianCalendar();
            return DbSet.Include(s => s.Employee).ToList().Where(s => s.BranchId == branchId &&
                                                                      s.StartTime.Year == year &&
                                                                      cal.GetWeekOfYear(s.StartTime,
                                                                          CalendarWeekRule.FirstFourDayWeek,
                                                                          DayOfWeek.Monday) == week).ToList();
        }
        public IEnumerable<PlannedShift> GetOfEmployeeOnDay(DateTime date, string employeeId)
        {
            return DbSet.Where(p => p.EmployeeId == employeeId && p.StartTime.Date == date.Date);
        }

        public void Import(List<PlannedShift> list)
        {
            DbSet.AddRange(list);
            Context.SaveChanges();
        }
        
        // Returns all worked shifts found in between timestamps.
        public List<PlannedShift> GetPlannedShiftsInBetween(int branchId, string employeeId, DateTime from, DateTime until)
        {
            return DbSet.Where(s => s.BranchId == branchId && s.EmployeeId == employeeId
                                                           && s.StartTime >= from && s.EndTime <= until).ToList();
        }
    }
}