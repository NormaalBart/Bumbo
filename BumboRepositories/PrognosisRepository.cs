using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using Microsoft.EntityFrameworkCore;

namespace BumboRepositories
{
    public class PrognosisRepository : IPrognosisRepository
    {
        private BumboContext _context;
        private IBranchRepository _branchRepository;
        public PrognosisRepository(BumboContext context, IBranchRepository branchRepository)
        {
            _context = context;
            _branchRepository = branchRepository;
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

        public Prognosis GetByDate(DateOnly date)
        {
           
            return _context.Prognoses.FirstOrDefault(p => p.Date == date);
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
        
        public void AddOrUpdateAll(List<Prognosis> list)
        {
            if(list.Count == 0)
            {
                return;
            }
            foreach (var item in list)
            {
                // each prognose has a branch and department prognoses. These Department prognoses
                // contain the amount of hours and employees that are needed for that department.


                // First we check if the prognose already exists, in which case we update it.
                // other wise we add it.
                if (_context.Prognoses.Where(p => p.Date == item.Date).FirstOrDefault() != null)
                {
                    var prognosisDay = _context.Prognoses.Where(p => p.Date == item.Date).Include(p => p.DepartmentPrognoses).FirstOrDefault();
                    prognosisDay.ColiCount = item.ColiCount;
                    prognosisDay.CustomerCount = item.CustomerCount;
                    item.DepartmentPrognoses = this.CalculateDepartmentPrognoses(item).ToList();
                    prognosisDay.DepartmentPrognoses = item.DepartmentPrognoses;
                    

                    _context.Prognoses.Update(prognosisDay);
                }
                else
                {
                    // makes sure that there's no time instance in the date.

                    // get the branch of the item
                    item.Branch = _branchRepository.GetBranchOfUser();
                    item.DepartmentPrognoses = this.CalculateDepartmentPrognoses(item).ToList();
                    _context.Prognoses.Add(item);
                    
                }
            }
            _context.SaveChanges();
        }

        public IEnumerable<Prognosis> GetNextWeek(DateOnly firstDayOfWeek)
        {

            // This method returns the next 7 days from the given date.
            // If there's no prognosis for a week, it will return empty new prognosis days.
            // if there's gaps in the week it will check which days are missing and create a new one for those days.



            var nextWeek = _context.Prognoses.Where(p => p.Date >= firstDayOfWeek && p.Date <= firstDayOfWeek.AddDays(7));
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
                if(temp == null)
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

            var standards = _context.Standards.Where(p => p.Branch.Id == prognosis.Branch.Id);


            foreach (var department in _context.Departments)
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
