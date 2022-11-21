using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IUnavailableMomentsRepository: IRepository<UnavailableMoment>
    {
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
    }
}
