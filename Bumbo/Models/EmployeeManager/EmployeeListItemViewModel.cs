using System.ComponentModel;

namespace Bumbo.Models.EmployeeManager
{
    public class EmployeeListItemViewModel
    {
        public int Id { get; set; }
        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }
        [DisplayName("Achternaam")]
        public string LastName { get; set; }

        [DisplayName("Naam")]
        public string FullName
        {
            get => $"{LastName}, {FirstName} {MiddleName}";
        }

        [DisplayName("Functie")]
        public string Function { get; set; }


        [DisplayName("Regio")]
        public string Region { get; set; }
        
        [DisplayName("In dienst sinds")]
        public DateTime EmployeeJoinedCompany { get; set; }

        [DisplayName("In dienst")]
        public bool IsEmployed { get; set; }



    }
}
