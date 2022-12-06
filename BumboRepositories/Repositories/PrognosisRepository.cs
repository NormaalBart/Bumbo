using BumboData;
using BumboData.Interfaces;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories.Repositories
{
    public class PrognosisRepository : Repository<Prognosis>, IPrognosisRepository
    {
        public PrognosisRepository(BumboContext context): base(context)
        {
        }

        public Prognosis GetByDate(DateOnly date, int branchId)
        {
            return DbSet.Include(o => o.Branch).FirstOrDefault(p => p.Date == date && p.BranchId == branchId);
        }

        public IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date)
        {
            return Context.PlannedShifts.Where(p => p.StartTime.Date == date).Include(p => p.Employee);
        }
        


        public int GetIdByDate(DateTime date)
        {
            return DbSet.Where(p => p.Date == date.ToDateOnly()).Select(p => p.Id).FirstOrDefault();
        }

        public DateOnly GetNextEmptyPrognosisDate()
        {
            if (DbSet.OrderByDescending(p => p.Date).FirstOrDefault() != null)
            {
                return DbSet.OrderByDescending(p => p.Date).FirstOrDefault().Date.AddDays(1);
            }
            return DateOnly.FromDateTime(DateTime.Now);
        }

        public void AddOrUpdateAll(int branchId, List<Prognosis> list)
        {
            if (list.Count == 0)
            {
                return;
            }
            foreach (var item in list)
            {

                // First we check if the prognose already exists, in which case we update it.
                // other wise we add it.
                if (DbSet.Where(p => p.Date == item.Date && p.BranchId == branchId).FirstOrDefault() != null)
                {
                    var prognosisDay = DbSet.Where(p => p.Date == item.Date && p.BranchId == branchId).FirstOrDefault();
                    prognosisDay.ColiCount = item.ColiCount;
                    prognosisDay.CustomerCount = item.CustomerCount;

                    DbSet.Update(prognosisDay);

                }
                else
                {
                    // get the branch of the item
                    item.BranchId = branchId;
                    DbSet.Add(item);

                }
            }
            Context.SaveChanges();
        }

        public IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek , int branchId)
        {

            // This method returns the next 7 days from the given date.
            // If there's no prognosis for a week, it will return empty new prognosis days.
            // if there's gaps in the week it will check which days are missing and create a new one for those days.



            var nextWeek = DbSet.Where(p => p.Date >= firstDayOfWeek && p.Date <= firstDayOfWeek.AddDays(7) && p.BranchId == branchId);
            if (nextWeek.Count() == 7)
            {
                // prevent very rare case scenario where the database has 7 days in a row, but is also somehow wrong or not starting correctly. 
                if (nextWeek.FirstOrDefault().Date == firstDayOfWeek)
                {
                    return nextWeek;
                }
            }


            var resultList = new List<Prognosis>();
            // if the database does not have any days for the week, we return default values.
            if (nextWeek.Count() == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    Prognosis prognosis = new Prognosis();
                    prognosis.Date = firstDayOfWeek.AddDays(i);
                    prognosis.BranchId = branchId;
                    prognosis.CustomerCount = 0;
                    prognosis.ColiCount = 0;
                    resultList.Add(prognosis);
                }
                return resultList;
            }


            // in the very rare case scenario which should not happen, where there's
            // days missing in a week where it shouldn't be missing
            // we check which ones are missing and add default values for those days in the return list.

            for (int i = 0; i < 7; i++)
            {
                var temp = this.GetByDate(firstDayOfWeek.AddDays(i),branchId);
                if (temp == null)
                {
                    Prognosis prognosis = new Prognosis();
                    prognosis.Date = firstDayOfWeek.AddDays(i);
                    prognosis.BranchId = branchId;
                    prognosis.CustomerCount = 0;
                    prognosis.ColiCount = 0;
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
