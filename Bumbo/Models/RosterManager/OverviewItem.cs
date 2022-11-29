using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.RosterManager
{
    public class OverviewItem
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public double PrognosisHours { get; set; }
        public double RosteredHours { get; set; }

    }
}
