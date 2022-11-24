using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BumboData.Models;

namespace Bumbo.Models.BranchController
{
    public class ListIndexBranchViewModel
    {

        public int Id { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Managers")]
        public string? Managers { get; set; }

        [Required]
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

        [DisplayName("Adres")]
        public string FormattedStreet
        {
            get => $"{Street} {HouseNumber} te {City}";
        }
    }
}
