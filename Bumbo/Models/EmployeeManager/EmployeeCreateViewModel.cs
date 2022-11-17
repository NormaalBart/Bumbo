using BumboData.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager
{

    public class EmployeeCreateViewModel
    {


        // These are the values mentioned in the casus:
        //BID,Vn,Tv,An,Geboortedatum,Postcode,Huisnummer,Telefoon,Email,In dienst, Functie, KAS, VERS, VAK


        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Voornaam")]
        [StringLength(50)]
        public String FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        [StringLength(50)]
        public String? Preposition { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Achternaam")]
        [StringLength(50)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Geboortedatum")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Is momenteel in dienst")]
        public Boolean Active { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [EmailAddress]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Het telefoonnummer is verplicht")]
        [DisplayName("Telefoon")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
         ErrorMessage = "Dat is geen valide telefoonnummer")]
        [Phone]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Postcode")]
        [DataType(DataType.PostalCode)]
        [StringLength(50)]
        public String PostalCode { get; set; }
        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Huisnummer")]
        [StringLength(50)]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DataType(DataType.Date)]
        [DisplayName("In dienst sinds (De datum waarop deze medewerker in het bedrijf is begonnen)")]
        public DateTime EmployeeJoinedCompany { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Functie")]
        [StringLength(50)]
        public String Function { get; set; }
        
        [DisplayName("Kies een of meerdere afdelingen voor deze medewerker.")]
        public virtual ICollection<Department> AllowedDepartments { get; set; }

        public List<EmployeeDepartmentViewModel> EmployeeSelectedDepartments { get; set; }

        public string? EmployeeKey { get; set; }


        public EmployeeCreateViewModel()
        {
            this.Active = true;
            this.EmployeeJoinedCompany = DateTime.Now.Date;
            this.Birthdate = DateTime.Now.AddYears(-18);

            AllowedDepartments = new List<Department>();

            EmployeeSelectedDepartments = new List<EmployeeDepartmentViewModel>();

        }
    }
}
