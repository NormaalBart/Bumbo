using BumboData.Enums;
using System.ComponentModel;

namespace Bumbo.Models.RosterManager
{
    public class ShiftViewModel
    {
        
        public int Id { get; set; }
        public DepartmentEnum Department { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        
    }
}
