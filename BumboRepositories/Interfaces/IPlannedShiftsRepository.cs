using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IPlannedShiftsRepository: IRepository<PlannedShift>
    {
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);
        double GetHoursPlannedInWorkWeek(string employeeId, DateTime currentDate);
        IEnumerable<PlannedShift> GetWeekOfShiftsAfterDateForEmployee(DateTime date, string employeeId);
    }
}
