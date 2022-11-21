using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IPlannedShiftsRepository
    {
        IEnumerable<PlannedShift> GetAll();
        WorkedShift GetById(int id);
        void Add(PlannedShift plannedShift);
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);
        double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate);

        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);
    }
}
