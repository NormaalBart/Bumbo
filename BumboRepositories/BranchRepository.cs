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

        public IEnumerable<Branch> GetAll()
        {
            return _context.Branches;
        }

        public Branch GetById(int id)
        {

            return _context.Branches.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Update(Branch branch)
        {
            throw new NotImplementedException();
        }
        public Branch GetBranchOfUser()
        {
            // I implemented this method when branch creation and login features
            // haven't been made yet. This gets a default first branch to assign
            // everything to that needs it such as prognosis. 
            // In the future, revamp this method so it returns the branch
            // of the user who is currently logged in.
            return _context.Branches.FirstOrDefault();
        }
    }
}
