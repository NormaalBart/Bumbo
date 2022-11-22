﻿using BumboData;
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

        public Prognosis GetByDate(DateOnly date)
        {
            return DbSet.FirstOrDefault(p => p.Date == date);
        }

        public IEnumerable<PlannedShift> GetShiftsOnDayByDate(DateTime date)
        {
            return Context.PlannedShifts.Where(p => p.StartTime.Date == date).Include(p => p.Employee);
        }
        public double GetCassierePrognose(DateTime date)
        {
            Prognosis prognosis = DbSet.Where(o => o.Date == date.ToDateOnly()).Include(o => o.Branch).SingleOrDefault();
            if (prognosis != null)
            {
                Standard standard = Context.Standards.Where(o => o.Branch == prognosis.Branch && o.Key == StandardType.CHECKOUT_EMPLOYEES).SingleOrDefault();
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double cassierePerCustomersPerHour = standard.Value;
                    return customerCount / cassierePerCustomersPerHour;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        public double GetFreshPrognose(DateTime date)
        {
            Prognosis prognosis = DbSet.Where(o => o.Date == date.ToDateOnly()).Include(o => o.Branch).SingleOrDefault();
            if (prognosis != null)
            {
                Standard standard = Context.Standards.Where(o => o.Branch == prognosis.Branch && o.Key == StandardType.FRESH_EMPLOYEES).SingleOrDefault();
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double freshEmployeePerCustomersPerHour = standard.Value;
                    return customerCount / freshEmployeePerCustomersPerHour;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        public double GetStockersPrognose(DateTime date)
        {
            Prognosis prognosis = DbSet.Where(o => o.Date == date.ToDateOnly()).Include(o => o.Branch).SingleOrDefault();
            if (prognosis != null)
            {
                Standard coliUnloadTimeInMin = Context.Standards.Where(o => o.Branch == prognosis.Branch && o.Key == StandardType.COLI_TIME).SingleOrDefault();
                Standard coliStockTimeInMin = Context.Standards.Where(o => o.Branch == prognosis.Branch && o.Key == StandardType.SHELF_STOCKING_TIME).SingleOrDefault();
                Standard shelfArragementTimeInSec = Context.Standards.Where(o => o.Branch == prognosis.Branch && o.Key == StandardType.SHELF_ARRANGEMENT).SingleOrDefault();
                if (coliUnloadTimeInMin != null || coliStockTimeInMin != null || shelfArragementTimeInSec != null)
                {
                    Double timeSpentOnColiInMin = (coliUnloadTimeInMin.Value + coliStockTimeInMin.Value) * prognosis.ColiCount;
                    Double timeSpentOnShelfsInMin = (shelfArragementTimeInSec.Value * prognosis.Branch.ShelvingDistance) / 60;

                    return (timeSpentOnColiInMin + timeSpentOnShelfsInMin) / 60;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
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

        public void AddOrUpdateAll(Branch branch, List<Prognosis> list)
        {
            if (list.Count == 0)
            {
                return;
            }
            foreach (var item in list)
            {
                // each prognose has a branch and department prognoses. These Department prognoses
                // contain the amount of hours and employees that are needed for that department.


                // First we check if the prognose already exists, in which case we update it.
                // other wise we add it.
                if (DbSet.Where(p => p.Date == item.Date).FirstOrDefault() != null)
                {
                    var prognosisDay = DbSet.Where(p => p.Date == item.Date).Include(p => p.DepartmentPrognosis).FirstOrDefault();
                    prognosisDay.ColiCount = item.ColiCount;
                    prognosisDay.CustomerCount = item.CustomerCount;
                    item.DepartmentPrognosis = this.CalculateDepartmentPrognoses(item).ToList();
                    prognosisDay.DepartmentPrognosis = item.DepartmentPrognosis;


                    DbSet.Update(prognosisDay);
                }
                else
                {
                    // makes sure that there's no time instance in the date.

                    // get the branch of the item
                    item.Branch = branch;
                    item.DepartmentPrognosis = this.CalculateDepartmentPrognoses(item).ToList();
                    DbSet.Add(item);

                }
            }
            Context.SaveChanges();
        }

        public IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek)
        {

            // This method returns the next 7 days from the given date.
            // If there's no prognosis for a week, it will return empty new prognosis days.
            // if there's gaps in the week it will check which days are missing and create a new one for those days.



            var nextWeek = DbSet.Where(p => p.Date >= firstDayOfWeek && p.Date <= firstDayOfWeek.AddDays(7));
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
                var temp = this.GetByDate(firstDayOfWeek.AddDays(i));
                if (temp == null)
                {
                    Prognosis prognosis = new Prognosis();
                    prognosis.Date = firstDayOfWeek.AddDays(i);
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

        public IEnumerable<DepartmentPrognosis> CalculateDepartmentPrognoses(Prognosis prognosis)
        {
            // This method calculates the amount of employees and hours needed for each department.
            // This is done using the standard from the database.
            List<DepartmentPrognosis> result = new List<DepartmentPrognosis>();

            // create 3 new department prognoses for each department.
            // with default values

            var standards = Context.Standards.Where(p => p.Branch.Id == prognosis.Branch.Id);


            foreach (var department in Context.Departments)
            {
                DepartmentPrognosis departmentPrognosis = new DepartmentPrognosis();
                departmentPrognosis.Prognosis = prognosis;
                departmentPrognosis.Department = department;

                // calculate using the standard.


                // TODO calculate using the standard.
                departmentPrognosis.RequiredEmployees = 2;
                departmentPrognosis.RequiredHours = 2;


                result.Add(departmentPrognosis);

            }
            return result;
        }

    }
}