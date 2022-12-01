using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetAllActiveBranches();
        IEnumerable<Branch> GetAllActiveBranches(int start, int amount);
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
    }
}
