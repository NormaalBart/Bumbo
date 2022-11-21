using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetAllActiveBranches();
        Branch? GetById(int key);
        void Add(Branch branch);
        void Update(Branch branch);
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
    }
}
