using BumboData.Models;

namespace BumboData
{
    public interface IUnavailableMoments
    {
        IEnumerable<WorkedShift> GetAll();
        WorkedShift GetById(int id);
        void Add(WorkedShift workedShift);
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
    }
}
