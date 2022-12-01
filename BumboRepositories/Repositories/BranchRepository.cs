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

        public IEnumerable<Branch> GetAllActiveBranches(int start, int amount)
        {
            var result = DbSet.Where(branch => branch.Inactive == false);
            var count = result.Count();
            if (start > count) { return new List<Branch>(); }
            if (start + amount > count + start) { amount = count; }
            var range = new Range(start, amount);
            var result2 = result.Skip(start).Take(amount);
            var result3 = result2.ToList();
            return result3;
        }

        public List<Branch> GetUnmanagedBranches()
        {
            return DbSet.Where(branch => branch.Managers.Count == 0).ToList();
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
