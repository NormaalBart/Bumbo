using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime Date { get; set; }
    }
}
