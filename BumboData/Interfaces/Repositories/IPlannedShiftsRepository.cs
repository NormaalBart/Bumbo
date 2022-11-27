using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IPlannedShiftsRepository: IRepository<PlannedShift>
    {
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);
        double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate);
        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);
        public List<PlannedShift> GetShiftsByWeek(int branchId, int year, int week);
        public void Import(List<PlannedShift> list);

        public List<PlannedShift> GetPlannedShiftsInBetween(int branchId, string employeeId, DateTime from,
            DateTime until);
    }
}
