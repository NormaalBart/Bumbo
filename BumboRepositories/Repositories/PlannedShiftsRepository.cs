using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class PlannedShiftsRepository : Repository<PlannedShift>, IPlannedShiftsRepository
    {
        public PlannedShiftsRepository(BumboContext context): base(context)
        {
        }

        public override PlannedShift Create(PlannedShift entity)
        { 
            // db complains about foreign key being null
            entity.Employee = Context.Employees.Where(e => e.Id == entity.Employee.Id).FirstOrDefault();
            return base.Create(entity);
        }

        public override IEnumerable<PlannedShift> GetList()
        {
            return Context.PlannedShifts.Include(p => p.Employee);
        }

        public double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate, int newShiftId)
        {
            // start of week
            DateTime startOfWeek = currentDate.GetMondayOfTheWeek();
            // check if the employee has worked too much this week, excluding the shift that's being edited rn.
            var shiftsThisWeek = DbSet.Where(p => p.Employee.Id == employeeId && p.StartTime.Date >= startOfWeek && p.StartTime.Date <= startOfWeek.AddDays(6) && p.Id != newShiftId).ToList();
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
            return DbSet.Where(p => p.Employee.Id == employeeId && p.StartTime.Date >= date && p.StartTime <= date.AddDays(7)).Include(p => p.Department).Include(p => p.Branch);
        }

        public bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift)
        {
            var overlappingShifts = DbSet.Where(p => p.Employee.Id == plannedShift.Employee.Id && p.StartTime.Date == plannedShift.StartTime.Date).ToList();
            if (overlappingShifts.Count > 0)
            {
                foreach (var shift in overlappingShifts)
                {
                    if (plannedShift.StartTime < shift.EndTime && plannedShift.EndTime > shift.StartTime)
                    {
                        if (plannedShift.Id != shift.Id)
                        {
                            return true;
                        }
                        
                    }

                }
            }
            return false;
        }

        public IEnumerable<PlannedShift> GetShiftsOnDayForEmployeeOnDate(DateTime date, string employeeId)
        {
            return DbSet.Where(p => p.Employee.Id == employeeId && p.StartTime.Date == date).Include(p => p.Department).Include(p => p.Branch);
        }


        public PlannedShift GetPlannedShiftById(int shiftId)
        {
            return DbSet.Where(p => p.Id == shiftId).Include(p => p.Department).Include(p => p.Branch).Include(p => p.Employee).FirstOrDefault();
        }
    }
}
