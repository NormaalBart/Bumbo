using BumboData.Models;
using System.Text.Json.Nodes;

namespace BumboData.Interfaces.Repositories
{
    public interface IBranchRepository: IRepository<Branch>
    {
        IEnumerable<Branch> GetAllActiveBranches();
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
        void SetActive(int id);
        void RemoveSpecialOpeningHour(int id, DateOnly date);

        (TimeOnly, TimeOnly) GetOpenAndCloseTimes(int branchId, DateOnly day);
    }
}
