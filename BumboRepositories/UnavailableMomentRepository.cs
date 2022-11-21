using BumboData;
using BumboData.Models;
using BumboRepositories.Interfaces;

namespace BumboRepositories
{
    public class UnavailableMomentRepository : IUnavailableMomentsRepository
    {
        private BumboContext _context;

        public UnavailableMomentRepository(BumboContext context)
        {
            this._context = context;
        }

        public void Add(WorkedShift workedShift)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkedShift> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkedShift GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsEmployeeAvailable(string employeeId, DateTime startTime, DateTime endTime)
        {
            // check if employee is unavailable in unavailable moments 
            var unavailableMoments = _context.UnavailableMoments.Where(u => u.Employee.Id == employeeId && u.StartTime.Date == startTime.Date).ToList();
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
