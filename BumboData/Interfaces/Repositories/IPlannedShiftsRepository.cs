using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IPlannedShiftsRepository: IRepository<PlannedShift>
    {
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);

        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);

        IEnumerable<PlannedShift> GetShiftsOnDayForEmployeeOnDate(DateTime date, string employeeId, int branchId);

        PlannedShift GetPlannedShiftById(int shiftId);


        List<PlannedShift> GetShiftsByWeek(int branchId, int year, int week); 
        void Import(List<PlannedShift> list);
        List<PlannedShift> GetPlannedShiftsInBetween(int branchId, string employeeId, DateTime from, DateTime until);


        double GetTotalHoursPlannedOnDay(int branchId, DateTime date);

        IEnumerable<PlannedShift> GetOfEmployeeOnDay(DateTime date, string employeeId);

    }
}
