using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IBranch
    {
        /// <summary>
        /// Returns the default branch of the user who is currently logged in.
        /// </summary>
        Branch GetBranchOfUser();
    }
}
