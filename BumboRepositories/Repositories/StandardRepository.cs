using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboRepositories.Repositories
{
    public class StandardRepository : IStandardRepository
    {
        readonly BumboContext _context; 
        public StandardRepository(BumboContext context)
        {
            _context = context;
        }
        public Standard Get(StandardType standardType, Branch branch)
        {
            return _context.Standards.Where(o => o.Branch == branch && o.Key == standardType).SingleOrDefault();
        }
    }
}
