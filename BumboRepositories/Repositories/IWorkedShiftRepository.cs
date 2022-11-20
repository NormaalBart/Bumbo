using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public interface IWorkedShiftRepository
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAll();
        WorkedShift GetById(string id);
        void Add(WorkedShift workedShift);
        void Update(WorkedShift workedShift);
        List<WorkedShift> GetWorkedShiftsInMonth(string employee, int year, int month);
        List<WorkedShift> GetWorkedShiftsInMonth(int year, int month);
    }
}
