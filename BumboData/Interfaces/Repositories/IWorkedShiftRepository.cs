using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IWorkedShiftRepository: IRepository<WorkedShift>
    {
        WorkedShift LastWorkedShiftWithNoEndTime(Employee employee);
        IEnumerable<WorkedShift> GetAllApproved(int branchId);
        List<WorkedShift> GetWorkedShiftsInMonth(int branchId, string employee, int year, int month);
        List<WorkedShift> GetWorkedShiftsInMonth(int branchId, int year, int month);
        void Import(List<WorkedShift> list);
    }
}
