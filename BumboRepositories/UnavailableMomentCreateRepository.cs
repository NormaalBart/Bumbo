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
        public void AddEmployeeToUnavailableMoment(UnavailableMoment unavailableMoment)
        {
            //TODO get right employee to connect the unavailable moment to the employee
            var e = _context.Employees.Where(s => true).First<Employee>();
            // this works only if you have an employee in the database...

            unavailableMoment.Employee = e;
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
