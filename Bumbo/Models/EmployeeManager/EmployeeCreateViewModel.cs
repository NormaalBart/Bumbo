﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager
{

    public class EmployeeCreateViewModel
    {


        // These are the values mentioned in the casus:
        // BID	Vn	Tv	An	Geboortedatum	Leeftijd	Postcode	Huisnummer	Telefoon	Email	In dienst sinds 	
        // Functie	Schaal	KAS	VER	VAK	SER

        [Required]
        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }
        [Required]
        [DisplayName("Achternaam")]
        public string LastName { get; set; }


        [Required]
        [DisplayName("Geboortedatum")]
        public DateTime BirthDate { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DisplayName("Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Regio")]
        public string Region { get; set; }
        [Required]
        [DisplayName("Huisnummer")]
        public int HouseNumber { get; set; }
        

        [Required]
        [DisplayName("Functie")]
        public string Function { get; set; }

        [Required]
        [DisplayName("In dienst sinds")]
        public DateTime EmployeeJoinedCompany { get; set; }

        [Required]
        [DisplayName("In dienst")]
        public bool IsEmployed { get; set; }
        
        [DisplayName("kassa afdeling")]
        public bool InCassiereDep { get; set; }
        [DisplayName("Vers afdeling")]
        public bool InFreshDep { get; set; }
        [DisplayName("VakkenVullers afdeling")]
        public bool InStockersDep { get; set; }

        public EmployeeCreateViewModel()
        {
            this.IsEmployed = true;
        }
    }
}
