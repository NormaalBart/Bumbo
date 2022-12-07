using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IPlannedShiftsRepository : IRepository<PlannedShift>
    {
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);

        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);

        IEnumerable<PlannedShift> GetShiftsOnDayForEmployeeOnDate(DateTime date, string employeeId, int branchId);

        PlannedShift GetPlannedShiftById(int shiftId);

        List<PlannedShift> GetAllShiftsWeek(int branchId, DateOnly day);

        List<PlannedShift> GetAllShiftsDay(int branchId, DateOnly day);

        /*
         * Month needs to be supplied from 1 to 12;
         */
        List<PlannedShift> GetShiftsByMonth(int branchId, int year, int month);


        void Import(List<PlannedShift> list);
        List<PlannedShift> GetPlannedShiftsInBetween(int branchId, string employeeId, DateTime from, DateTime until);
        List<PlannedShift> GetPlannedShiftsInBetween(int branchId, DateTime from, DateTime until);
        double GetTotalHoursPlannedOnDay(int branchId, DateTime date);

        IEnumerable<PlannedShift> GetOfEmployeeOnDay(DateTime date, string employeeId);
    }
}
