using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class BranchCreateViewModel
    {

        public int Id { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Mannagers")]
        public string? Managers { get; set; }

        [DisplayName("Aantal medewerkers")]
        public int Employees { get; set; }

        [Required]
        [DisplayName("Stad")]
        public String City { get; set; }

        [Required]
        [DisplayName("Huisnummer")]
        public String HouseNumber { get; set; }

        [Required]
        [DisplayName("Straat")]
        public String Street { get; set; }

        [Required]
        [DisplayName("Spiegelmeters")]
        public int ShelvingDistance { get; set; }

        [Required]
        public List<OpeningHouersViewModel> OpeningHours { get; set; }

        [DisplayName("Adres")]
        public string FormattedStreet
        {
            get => $"{Street} {HouseNumber} te {City}";
        }

        public BranchCreateViewModel()
        {
            OpeningHours = new List<OpeningHouersViewModel>();
        }
    }
}
