using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
