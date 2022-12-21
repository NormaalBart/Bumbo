using System.ComponentModel;
using BumboData.Models;

namespace Bumbo.Models.RosterManager;

public class EmployeeRosterViewModel
{
    public EmployeeRosterViewModel()
    {
        PlannedShifts = new List<ShiftViewModel>();
        UnavailableMoments = new List<UnavailableMomentsRosterViewModel>();
    }

    public string Id { get; set; }

    [DisplayName("Voornaam")] public string FirstName { get; set; }

    [DisplayName("Tussenvoegsel")] public string? MiddleName { get; set; }

    [DisplayName("Achternaam")] public string LastName { get; set; }

    [DisplayName("Naam")] public string FullName => $"{FirstName} {MiddleName} {LastName}";

    public List<ShiftViewModel> PlannedShifts { get; set; }
    public List<UnavailableMomentsRosterViewModel> UnavailableMoments { get; set; }

    public List<Department> AllowedDepartments { get; set; }
}