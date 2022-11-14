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
            throw new NotImplementedException();
        }

        public IEnumerable<Branch> GetAll()
        {
            throw new NotImplementedException();
        }

        public Branch GetById(int id)
        {
            
            return _context.Branches.Where(e => e.Key == id).FirstOrDefault();
        }

        public void Update(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
