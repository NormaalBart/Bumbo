using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController;

public class BranchCreateViewModel
{
    public BranchCreateViewModel()
    {
        OpeningHours = new List<OpeningHoursViewModel>();
    }

    public int Id { get; set; }

    [DisplayName("Naam")] public string Name { get; set; }

    [DisplayName("Managers")] public string? Managers { get; set; }

    [DisplayName("Aantal medewerkers")] public int Employees { get; set; }

    [Required] [DisplayName("Stad")] public string City { get; set; }

    [Required] [DisplayName("Huisnummer")] public string HouseNumber { get; set; }

    [Required] [DisplayName("Straat")] public string Street { get; set; }

    [Required] public List<OpeningHoursViewModel> OpeningHours { get; set; }

    [DisplayName("Adres")] public string FormattedStreet => $"{Street} {HouseNumber} te {City}";
}