using BumboData.Models;

namespace Bumbo.Models.RosterManager
{
    public class ShiftViewModel
    {
        
        public int Id { get; set; }
        public Department Department { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        
    }
}
