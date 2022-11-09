using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class PrognosisRepository : IPrognosis
    {
        private MyContext _context;
        public PrognosisRepository(MyContext context)
        {
            _context = context;
        }
        
        public void Add(PrognosisDay prognosisDay)
        {
            _context.Prognosis.Add(prognosisDay);
            _context.SaveChanges();
        }

        public IEnumerable<PrognosisDay> GetAll()
        {
            return _context.Prognosis;
        }

        public PrognosisDay GetByDate(DateTime date)
        {
            return _context.Prognosis.Where(p => p.Date == date).Include(p => p.PlannedShiftsOnDay).FirstOrDefault();
        }

        public PrognosisDay GetById(int id)
        {
            return _context.Prognosis.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date)
        {
            return _context.PlannedShift.Where(p => p.StartTime.Date == date).Include(p => p.Employee);
        }
        public double GetCassierePrognose(DateTime date)
        {
            return _context.Prognosis.Where(p => p.Date == date).Select(p => p.CassiereDepartment).FirstOrDefault();
        }
        public double GetFreshPrognose(DateTime date)
        {
            return _context.Prognosis.Where(p => p.Date == date).Select(p => p.FreshDepartment).FirstOrDefault();
        }
        public double GetStockersPrognose(DateTime date)
        {
            return _context.Prognosis.Where(p => p.Date == date).Select(p => p.StockersDepartment).FirstOrDefault();
        }

        public void Update(PrognosisDay prognosisDay)
        {
            throw new NotImplementedException();
        }

        public int GetIdByDate(DateTime date)
        {
            return _context.Prognosis.Where(p => p.Date == date).Select(p => p.Id).FirstOrDefault();
        }

        public DateTime GetNextEmptyPrognosisDate()
        {
            if (_context.Prognosis.OrderByDescending(p => p.Date).FirstOrDefault() != null)
            {
                return _context.Prognosis.OrderByDescending(p => p.Date).FirstOrDefault().Date.AddDays(1);
            }
            return DateTime.Now;
        }
    }
}
