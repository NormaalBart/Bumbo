using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {

        public BranchRepository(BumboContext context)
            : base(context)
        {

        }

        public IEnumerable<Branch> GetAllActiveBranches()
        {
            return DbSet.Where(branch => !branch.Inactive).ToList();
        }

        public List<Branch> GetUnmanagedBranches()
        {
            return DbSet.Where(branch => branch.Manager == null).ToList();
        }

         public void SetInactive(int id)
        {
            var branch = Get(id);
            if (branch != null)
            {
                branch.Inactive = true;
                Update(branch);
            }
        }
    }
}
