using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.EmployeeCreate
{
    public abstract class BaseCreateViewModel
    {

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Voornaam")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public String FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public String? Preposition { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Achternaam")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Geboortedatum")]
        [DataType(DataType.Date, ErrorMessage = "Veld is niet valid.")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Is momenteel in dienst")]
        public Boolean Active { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [EmailAddress(ErrorMessage = "Veld moet een valide email address zijn.")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Wachtwoord")]
        [DataType(DataType.Password, ErrorMessage = "Geen valide wachtwoord.")]
        public String Password { get; set; }

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
        public String PostalCode { get; set; }

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
            this.Active = true;
            this.EmployeeJoinedCompany = DateTime.Now.Date;
            this.Birthdate = DateTime.Now.AddYears(-18);
        }

    }
}
