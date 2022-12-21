using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.Index;

public class EmployeeListItemViewModel
{
    public string Id { get; set; }

    [DisplayName("Voornaam")] public string FirstName { get; set; }

    [DisplayName("Tussenvoegsel")] public string? MiddleName { get; set; }

    [DisplayName("Achternaam")] public string LastName { get; set; }

    [DisplayName("Naam")] public string FullName => $"{LastName}, {FirstName} {MiddleName}";

    [DisplayName("Functie")] public string Function { get; set; }

    [DisplayName("GeboorteDatum")]
    [DataType(DataType.Date)]
    public DateTime Birthdate { get; set; }

    [DisplayName("In dienst sinds")]
    [DataType(DataType.Date)]
    public DateTime EmployeeJoinedCompany { get; set; }

    [DisplayName("In dienst")] public bool Active { get; set; }
}