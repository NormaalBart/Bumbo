using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;

namespace BumboRepositories.Repositories
{
    public class UnavailableMomentRepository : Repository<UnavailableMoment>, IUnavailableMomentsRepository
    {
        public UnavailableMomentRepository(BumboContext context): base(context)
        {
        }

        public bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime)
        {
            // check if employee is unavailable in unavailable moments 
            var unavailableMoments = DbSet.Where(u => u.Employee.Id == employeeId && u.StartTime.Date == startTime.Date).ToList();
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
    }
}
