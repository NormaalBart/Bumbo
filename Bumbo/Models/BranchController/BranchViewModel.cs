using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class BranchViewModel
    {

        public int Id { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Mannager")]
        public Employee? Manager { get; set; }

        [Required]
        [DisplayName("Spiegelmeters")]
        public int ShelvingDistance { get; set; }

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
