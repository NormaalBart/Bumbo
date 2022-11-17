using BumboData;
using BumboData.Models;

namespace BumboRepositories
{
    public class UnavailableMomentCreateRepository : IUnavailableMomentsCreate
    {
        private BumboContext _context;

        public UnavailableMomentCreateRepository(BumboContext context)
        {
            this._context = context;
        }

        public void Add(UnavailableMoment unavailable)
        {
            _context.UnavailableMoments.Add(unavailable);
            _context.SaveChanges();
        }

        public IEnumerable<UnavailableMoment> GetAll()
        {
            List<UnavailableMoment> unavailableMoments = _context.UnavailableMoments.ToList();
            return unavailableMoments;
        }

    }
}
