using BumboData;
using BumboData.Models;

namespace BumboRepositories
{
    public class UnavailableMomentRepository : IUnavailableMoments
    {
        private MyContext _context;

        public UnavailableMomentRepository(MyContext context)
        {
            this._context = context;
        }

        public void Add(UnavailableMoment unavailableMoment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UnavailableMoment> GetAll()
        {
            throw new NotImplementedException();
        }

        public UnavailableMoment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsEmployeeAvailable(int employeeId, DateTime startTime, DateTime endTime)
        {
            // check if employee is unavailable in unavailable moments 
            var unavailableMoments = _context.UnavailableMoment.Where(u => u.EmployeeId == employeeId && u.StartTime.Date == startTime.Date).ToList();
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
