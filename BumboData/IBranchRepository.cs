using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IBranchRepository 
    {
        Branch GetBranchOfUser();
    }
}
