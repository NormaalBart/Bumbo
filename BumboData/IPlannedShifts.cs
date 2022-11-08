using BumboData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public interface IPlannedShifts
    {
        IEnumerable<PlannedShift> GetAll();
        WorkedShift GetById(int id);
        void Add(PlannedShift plannedShift);
        bool ShiftOverlapsWithOtherShifts(PlannedShift plannedShift);
        double GetHoursPlannedInWorkWeek(int employeeId, DateTime currentDate);

        IEnumerable<PlannedShift> GetShiftsOfEmployeeOnDate(DateTime date, int employeeId);
    }
}
