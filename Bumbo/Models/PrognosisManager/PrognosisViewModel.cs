using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.PrognosisManager
{
    public class PrognosisViewModel
    {
        public int Id { get; set; }
 
        [DisplayName("Aantal Collies")]
        [Required]
        public int AmountOfCollies { get; set; }
        [DisplayName("Aantal Klanten")]
        [Required]
        public int AmountOfCustomers { get; set; }
        [Required]
        [DisplayName("Datum")]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }
    }
}
