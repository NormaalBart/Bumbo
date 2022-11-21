using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IWorkedShiftRepository
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAll();
        IEnumerable<WorkedShift> GetAllApproved();
        WorkedShift GetById(string id);
        void Add(WorkedShift workedShift);
        void Update(WorkedShift workedShift);
        List<WorkedShift> GetWorkedShiftsInMonth(string employee, int year, int month);
        List<WorkedShift> GetWorkedShiftsInMonth(int year, int month);
    }
}
