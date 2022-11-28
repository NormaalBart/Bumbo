using BumboData.Models;

namespace Bumbo.Models.ApproveWorkedHours
{
    public class WorkedShiftViewModel
    {
        public int Id { get; set; }
        
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Boolean Approved { get; set; }

        public Boolean Sick { get; set; }


    }
}