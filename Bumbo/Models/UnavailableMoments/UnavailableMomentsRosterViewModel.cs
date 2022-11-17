using BumboData.Models;

namespace Bumbo.Models.RosterManager
{
    public class UnavailableMomentsCreateViewModel
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public UnavailableMomentType Type { get; set; }
    }
}
