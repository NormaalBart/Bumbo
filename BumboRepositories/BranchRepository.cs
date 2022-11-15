using BumboData;
using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboRepositories
{
    public class BranchRepository : IBranch
    {
        private BumboContext _context;

        public BranchRepository(BumboContext context)
        {
            this._context = context;
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
