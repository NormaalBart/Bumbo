using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetAllActiveBranches();
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
        void SetActive(int id);

        IEnumerable<Branch> GetList(int start, int amount);
        void RemoveSpecialOpeningHour(int id, DateOnly date);

        // Returns the opening times for given day, will return TimeSpan.MinValue if closed
        (TimeOnly, TimeOnly) GetOpenAndCloseTimes(int branchId, DateOnly day);
    }
}
