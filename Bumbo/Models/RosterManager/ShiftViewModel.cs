using BumboData.Models;
using BumboServices.CAO.Rules;

namespace Bumbo.Models.RosterManager
{
    public class ShiftViewModel
    {
        
        public int Id { get; set; }
        public Department Department { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public List<ICAORule> ViolatedRules { get; set; }

        public bool Sick { get; set; }

        public ShiftViewModel()
        {
            ViolatedRules = new List<ICAORule>();
        }

    }
}
