using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IUnavailableMoments
    {
        IEnumerable<UnavailableMoment> GetAll();
        UnavailableMoment GetById(int id);
        void Add(UnavailableMoment unavailableMoment);
        bool IsEmployeeAvailable(int employeeId, DateTime startTime, DateTime endTime);
    }
}
