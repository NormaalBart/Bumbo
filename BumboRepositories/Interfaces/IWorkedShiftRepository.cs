using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IWorkedShiftRepository: IRepository<WorkedShift>
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAllApproved();
        List<WorkedShift> GetWorkedShiftsInMonth(string employee, int year, int month);
        List<WorkedShift> GetWorkedShiftsInMonth(int year, int month);
    }
}
