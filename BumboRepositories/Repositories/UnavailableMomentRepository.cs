using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;

namespace BumboRepositories.Repositories
{
    public class UnavailableMomentRepository : Repository<UnavailableMoment>, IUnavailableMomentsRepository
    {
        public UnavailableMomentRepository(BumboContext context) : base(context)
        {
        }

        public IEnumerable<UnavailableMoment> GetAll(string employeeId)
        {
            return DbSet.Where(e => e.Employee.Id == employeeId).ToList();
        }
        public IEnumerable<UnavailableMoment> getOverlappingMoments(UnavailableMoment unavailableMoment)
        {
            return DbSet.Where(u=>unavailableMoment.Employee.Id == u.Employee.Id)
                .Where(e => (unavailableMoment.StartTime < e.EndTime &&
                            e.StartTime < unavailableMoment.EndTime)).ToList();
        }

        public bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime)
        {
            // check if employee is unavailable in unavailable moments 
            var unavailableMoments = DbSet.Where(u => u.Employee.Id == employeeId && u.StartTime.Date == startTime.Date)
                .ToList();
            if (unavailableMoments.Count > 0)
            {
                foreach (var moment in unavailableMoments)
                {
                    if (startTime < moment.EndTime && endTime > moment.StartTime)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /*
         * Returns if the employee has any school planned given week.
         */
        public bool EmployeeSchoolWeek(string employee, int year, int week)
        {
            // Tolist is required, weeknumber function can't be converted to SQL.
            return DbSet.ToList().Any(s =>
                s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
                s.Type == UnavailableMomentType.SCHOOL);
        }

        public List<UnavailableMoment> GetSchoolUnavailableMomentsByWeek(string employee, int year, int week)
        {
            return DbSet.ToList().Where(s =>
                s.EmployeeId == employee && s.StartTime.Year == year && s.StartTime.GetWeekNumber() == week &&
                s.Type == UnavailableMomentType.SCHOOL).ToList();
        }

        public List<UnavailableMoment> GetSchoolUnavailableMomentsByDay(string employee, DateOnly day)
        {
            return DbSet.Where(s => s.EmployeeId == employee && s.StartTime.Date.DayOfYear == day.DayOfYear
                                                             && s.StartTime.Date.Year == day.Year).ToList();
        }
    }
}