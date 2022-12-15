using BumboData.Enums;
using System.ComponentModel;

namespace Bumbo.Models.EmployeeRoster
{
    public class EmployeeShiftViewModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DepartmentName { get; set; }
        
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }


        public virtual UnavailableMomentType? Type { get; set; }

        public virtual ReviewStatus? ReviewStatus { get; set; }

        public string GetLengthDays()
        {
            if (StartTime.Date == EndTime.Date)
            {
                TimeSpan time = EndTime - StartTime;
                return "Duurt " + time + " uren";
            }
            TimeSpan days = EndTime - StartTime;
            if (days.Days == 1)
            {
                return "Duurt " + days.Days + " dag";
            }
            return "Duurt " + days.Days + " dagen";


        }
    }
}
