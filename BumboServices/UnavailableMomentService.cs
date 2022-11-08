using BumboData;
using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboServices
{
    public class UnavailableMomentService : IUnavailableMoments
    {
        private MyContext _context;

        public UnavailableMomentService(MyContext context)
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
