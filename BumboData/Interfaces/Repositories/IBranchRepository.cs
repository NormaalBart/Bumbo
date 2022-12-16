using BumboData.Models;
using System.Text.Json.Nodes;

namespace BumboData.Interfaces.Repositories
{
    public interface IBranchRepository: IRepository<Branch>
    {
        void SetInactive(int id);
        void SetActive(int id);

        void RemoveSpecialOpeningHour(int id, DateOnly date);

        // Returns the opening times for given day, will return TimeSpan.MinValue if closed
        (TimeOnly Open, TimeOnly Close) GetOpenAndCloseTimes(int branchId, DateOnly day);

        bool HasSpecialOpeningTimeOnDay(int branch, DateOnly day);
    }
}
