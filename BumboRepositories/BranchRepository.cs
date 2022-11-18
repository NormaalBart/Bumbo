using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _context.Branches.Where(branch => !branch.Inactive);
        }

        public Branch GetById(int id)
        {

            return _context.Branches.Where(e => e.Id == id).FirstOrDefault();
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
            Branch branch = GetById(id);
            branch.Inactive = true;
            Update(branch);
        }
    }
}
