using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IPlannedShiftsRepository: IRepository<PlannedShift>
    {
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);

        double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate, int newShiftId);
        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);

        IEnumerable<PlannedShift> GetShiftsOnDayForEmployeeOnDate(DateTime date, string employeeId);

        PlannedShift GetPlannedShiftById(int shiftId);


        List<PlannedShift> GetShiftsByWeek(int branchId, int year, int week); 
        void Import(List<PlannedShift> list);
        List<PlannedShift> GetPlannedShiftsInBetween(int branchId, string employeeId, DateTime from, DateTime until);

    }
}
