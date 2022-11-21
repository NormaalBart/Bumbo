using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public interface IUnavailableMomentsRepository
    {
        IEnumerable<WorkedShift> GetAll();
        WorkedShift GetById(int id);
        void Add(WorkedShift workedShift);
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
    }
}
