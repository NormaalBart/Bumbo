using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IUnavailableMomentsRepository: IRepository<UnavailableMoment>
    {
        bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime);
    }
}
