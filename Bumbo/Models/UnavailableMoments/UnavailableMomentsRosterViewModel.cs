using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.RosterManager
{
    public class UnavailableMomentsCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Start tijd (Vanaf wanneer de medewerker niet kan werken.)")]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayName("Eind tijd (Tot wanneer de medewerker niet kan werken.)")]
        public DateTime EndTime { get; set; }

        [Required]
        public UnavailableMomentType Type { get; set; }
    }
}
