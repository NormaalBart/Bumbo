using BumboData.Models;

namespace BumboRepositories.Interfaces
{
    public interface IBranchRepository: IRepository<Branch>
    {
        IEnumerable<Branch> GetAllActiveBranches();
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
    }
}
