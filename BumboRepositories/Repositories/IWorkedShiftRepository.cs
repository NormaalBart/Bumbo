using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public interface IWorkedShiftRepository
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAll();
        IEnumerable<WorkedShift> GetAllApproved(int branch);
        WorkedShift GetById(string id);
        void Add(WorkedShift workedShift);
        void Update(WorkedShift workedShift);
        List<WorkedShift> GetWorkedShiftsInMonth(int branchId, string employee, int year, int month);
        List<WorkedShift> GetWorkedShiftsInMonth(int branchId, int year, int month);
    }
}
