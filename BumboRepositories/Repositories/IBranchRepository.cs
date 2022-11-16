using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetAll();
        Branch GetById(int key);
        void Add(Branch branch);
        void Update(Branch branch);
        Branch GetBranchOfUser();
    }
}
