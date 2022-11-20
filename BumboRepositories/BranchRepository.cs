using BumboData;
using BumboData.Models;
using BumboRepositories.Repositories;

namespace BumboRepositories
{
    public class BranchRepository : IBranchRepository
    {
        private BumboContext _context;

        public BranchRepository(BumboContext context)
        {
            this._context = context;
        }
        public void Add(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
        }

        public IEnumerable<Branch> GetAllActiveBranches()
        {
            return _context.Branches.Where(branch => !branch.Inactive).ToList();
        }

        public Branch? GetById(int id)
        {
            return _context.Branches.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Branch branch)
        {
            _context.Branches.Update(branch);
            _context.SaveChanges();
        }

        public List<Branch> GetUnmanagedBranches()
        {
            return _context.Branches.Where(branch => branch.Manager == null).ToList();
        }

         public void SetInactive(int id)
        {
            var branch = GetById(id);
            if (branch != null)
            {
                branch.Inactive = true;
                Update(branch);
            }
        }
    }
}
