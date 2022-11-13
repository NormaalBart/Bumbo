using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class PrognosisRepository : IPrognosis
    {
        private BumboContext _context;
        public PrognosisRepository(BumboContext context)
        {
            _context = context;
        }
        
        public void Add(Prognosis prognosisDay)
        {
            _context.Prognoses.Add(prognosisDay);
            _context.SaveChanges();
        }

        public IEnumerable<Prognosis> GetAll()
        {
            return _context.Prognoses;
        }

        public Prognosis GetByDate(DateTime date)
        {
            return _context.Prognoses.FirstOrDefault(p => p.Date == date.ToDateOnly());
        }

        public Prognosis GetById(int id)
        {
            return _context.Prognoses.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date)
        {
            return _context.PlannedShifts.Where(p => p.StartTime.Date == date).Include(p => p.Employee);
        }
        public double GetCassierePrognose(DateTime date)
        {
            throw new NotImplementedException();
        }
        public double GetFreshPrognose(DateTime date)
        {
            throw new NotImplementedException();
        }
        public double GetStockersPrognose(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Update(Prognosis prognosisDay)
        {
            throw new NotImplementedException();
        }

        public int GetIdByDate(DateTime date)
        {
            return _context.Prognoses.Where(p => p.Date == date.ToDateOnly()).Select(p => p.Id).FirstOrDefault();
        }

        public DateOnly GetNextEmptyPrognosisDate()
        {
            if (_context.Prognoses.OrderByDescending(p => p.Date).FirstOrDefault() != null)
            {
                return _context.Prognoses.OrderByDescending(p => p.Date).FirstOrDefault().Date.AddDays(1);
            }
            return DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
