using BumboData.Models;

namespace BumboData
{
    public interface IPlannedShifts
    {
        IEnumerable<PlannedShift> GetAll();
        WorkedShift GetById(int id);
        void Add(PlannedShift plannedShift);
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);
        double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate);

        IEnumerable<PlannedShift> GetShiftsOfEmployeeOnDate(DateTime date, string employeeId);
    }
}
