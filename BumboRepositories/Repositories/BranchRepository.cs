using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

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
            return DbSet.Where(branch => branch.Managers.Count == 0).ToList();
        }

        public override Branch? Get(int id)
        {
            return DbSet.Include(branch => branch.StandardOpeningHours).Include(branch => branch.OpeningHoursOverrides).FirstOrDefault(branch => branch.Id == id);
        }

        public override IEnumerable<Branch> GetList()
        {
            return DbSet.Include(branch => branch.Managers).Include(branch => branch.DefaultEmployees).ToList();
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

        public void SetActive(int id)
        {
            var branch = Get(id);
            if (branch != null)
            {
                branch.Inactive = false;
                Update(branch);
            }
        }
    }
}
