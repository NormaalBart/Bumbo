using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.PrognosisManager
{
    public class PrognosisViewModel
    {
        public int Id { get; set; }

        [DisplayName("Aantal Collies")]
        [Required(ErrorMessage = "Dit is een verplicht veld")]
        [Range(0, 100000, ErrorMessage = "Aantal Collies moet tussen 0 en 100.000 liggen")]
        public int ColiCount { get; set; }
        [DisplayName("Aantal Klanten")]
        [Required(ErrorMessage = "Dit is een verplicht veld")]
        [Range(0, 100000, ErrorMessage = "Aantal klanten moet tussen 0 en 100.000 liggen")]
        public int CustomerCount { get; set; }

        [Required]
        [DisplayName("Datum")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
