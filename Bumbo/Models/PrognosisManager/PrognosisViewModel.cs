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
        [Range(0, 100000, ErrorMessage = "Aantal Collies moet tussen 0 en 100.000 liggen")]
        public int AmountOfCollies { get; set; }
        [DisplayName("Aantal Klanten")]
        [Required]
        // range between 0, 2000 with custom error message
        [Range(0, 100000, ErrorMessage = "Aantal klanten moet tussen 0 en 100.000 liggen")]
        public int AmountOfCustomers { get; set; }
        [Required]
        [DisplayName("Datum")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public PrognosisViewModel(DateTime date, int amountOfCollies, int amountOfCustomers)
        {
            this.Date = date;
            this.AmountOfCollies = amountOfCollies;
            this.AmountOfCustomers = amountOfCustomers;
        }

        public PrognosisViewModel()
        {
        }

    }
}
