using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.Common
{
    public abstract class BaseCreateViewModel
    {

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Voornaam")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public string FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public string? Preposition { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Achternaam")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Geboortedatum")]
        [DataType(DataType.Date, ErrorMessage = "Veld is niet valid.")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Is momenteel in dienst")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [EmailAddress(ErrorMessage = "Veld moet een valide email address zijn.")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Het telefoonnummer is verplicht")]
        [DisplayName("Telefoon")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
         ErrorMessage = "Veld moet een valide telefoon nummer zijn.")]
        [Phone(ErrorMessage = "Veld moet een valide telefoon nummer zijn.")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Postcode")]
        [DataType(DataType.PostalCode, ErrorMessage = "Veld moet een valide postcode zijn.")]
        [StringLength(50)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Huisnummer")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DataType(DataType.Date, ErrorMessage = "Veld is niet valid.")]
        [DisplayName("In dienst sinds (De datum waarop deze medewerker in het bedrijf is begonnen)")]
        public DateTime EmployeeJoinedCompany { get; set; }


        public string? EmployeeKey { get; set; }

        public string FullName
        {
            get => $"{LastName}, {FirstName} {Preposition}";
        }
        public BaseCreateViewModel()
        {
            Active = true;
            EmployeeJoinedCompany = DateTime.Now.Date;
            Birthdate = DateTime.Now.AddYears(-18);
        }

    }
}
