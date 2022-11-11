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
            return _context.Prognosis.Where(p => p.Date == date.Date).Include(p => p.PlannedShiftsOnDay).FirstOrDefault();
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

        public void AddOrUpdateAll(List<PrognosisDay> list)
        {
            if(list.Count == 0)
            {
                return;
            }
            foreach (var item in list)
            {
                // if item already exists, update it otherwise add.
                if (_context.Prognosis.Where(p => p.Date.Date == item.Date.Date).FirstOrDefault() != null)
                {
                    var prognosisDay = _context.Prognosis.Where(p => p.Date == item.Date).FirstOrDefault();
                    prognosisDay.AmountOfCollies = item.AmountOfCollies;
                    prognosisDay.AmountOfCustomers = item.AmountOfCustomers;
                    prognosisDay.updatePrognosis();
                    _context.Prognosis.Update(prognosisDay);
                }
                else
                {
                    // makes sure that there's no time instance in the date.
                    item.Date = item.Date.Date;
                    _context.Prognosis.Add(item);
                }
            }
            _context.SaveChanges();
        }

        public IEnumerable<PrognosisDay> GetNextWeek(DateTime firstDayOfWeek)
        {

            // This method returns the next 7 days from the given date.
            // If there's no prognosis for a week, it will return empty new prognosis days.
            // if there's gaps in the week it will check which days are missing and create a new one for those days.

            // However, since the manager can only add 7 days at a time now, this should not be a problem in the future.
            // As long as the manager cannot add specific days without adding the entire week it will be fine. 


            var nextWeek = _context.Prognosis.Where(p => p.Date >= firstDayOfWeek && p.Date <= firstDayOfWeek.AddDays(7));
            if (nextWeek.Count() == 7)
            {
                // prevent very rare case scenario where the database has 7 days in a row, but is also somehow wrong or not starting correctly. 
                if (nextWeek.FirstOrDefault().Date == firstDayOfWeek)
                {
                    return nextWeek;
                }
            }

            
            var resultList = new List<PrognosisDay>();
            // if the database does not have any days for the week, we add them with default values. 
            // this does not mean adding them to the database, but adding them to the resulting list which returns.
            if (nextWeek.Count() == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    PrognosisDay prognosis = new PrognosisDay();
                    prognosis.Date = firstDayOfWeek.AddDays(i);
                    prognosis.AmountOfCustomers = 0;
                    prognosis.AmountOfCollies = 0;
                    resultList.Add(prognosis);
                }
                return resultList;
            }


            // in the very rare case scenario which should not happen, where there's
            // days missing in a week where it shouldn't be missing
            // we check which ones are missing and add default values for those days in the return list.

            for (int i = 0; i < 7; i++)
            {
                var temp = this.GetByDate(firstDayOfWeek.AddDays(i));
                if(temp == null)
                {
                    PrognosisDay prognosis = new PrognosisDay();
                    prognosis.Date = firstDayOfWeek.AddDays(i);
                    prognosis.AmountOfCustomers = 0;
                    prognosis.AmountOfCollies = 0;
                    resultList.Add(prognosis);
                }
                else
                {
                    resultList.Add(temp);
                }
            }
            return resultList;
        }
    }
}
