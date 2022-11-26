using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData.Interfaces.Repositories
{
    public interface IStandardRepository
    {
        Standard Get(StandardType standardType, Branch branch);
    }
}
