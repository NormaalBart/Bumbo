using BumboData.Enums;

namespace Bumbo.Models.RosterManager
{
    public class UnavailableMomentsRosterViewModel
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
