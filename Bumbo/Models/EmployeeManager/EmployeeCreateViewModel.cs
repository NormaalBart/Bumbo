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


        [Required]
        [DisplayName("Voornaam")]
        public String FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        public String? Preposition { get; set; }

        [Required]
        [DisplayName("Achternaam")]
        public String LastName { get; set; }

        [Required]
        [DisplayName("Geboortedatum")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        [DisplayName("Is momenteel in dienst")]
        public Boolean Active { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Telefoon")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Postcode")]
        public String PostalCode { get; set; }
        [Required]
        [DisplayName("Huisnummer")]
        public string HouseNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("In dienst sinds (De datum waarop deze medewerker in het bedrijf is begonnen)")]
        public DateTime EmployeeJoinedCompany { get; set; }

        [Required]
        [DisplayName("Functie")]
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
