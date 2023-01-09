using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;

namespace BumboRepositories.Repositories;

public class StandardRepository : IStandardRepository
{
    private readonly BumboContext _context;

    public StandardRepository(BumboContext context)
    {
        _context = context;
    }

    public Standard Get(StandardType standardType, Branch branch)
    {
        return _context.Standards.Where(o => o.Branch == branch && o.Key == standardType).SingleOrDefault();
    }

    public ICollection<Standard> Get(int branch)
    {
        return _context.Standards.Where(o => o.BranchId == branch).ToList();
    }

    public void Update(Standard standard)
    {
        _context.Standards.Update(standard);
        _context.SaveChanges();
    }
}