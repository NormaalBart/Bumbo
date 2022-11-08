using System.ComponentModel;

namespace Bumbo.Models.RosterManager
{
    public class EmployeeRosterViewModel
    {
        public int Id { get; set; }

        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }
        [DisplayName("Achternaam")]
        public string LastName { get; set; }
        [DisplayName("Naam")]
        public string FullName => $"{FirstName} {MiddleName} {LastName}";


        public List<ShiftViewModel> PlannedShifts { get; set; }
        public List<UnavailableMomentsRosterViewModel> UnavailableMoments { get; set; }

        public EmployeeRosterViewModel()
        {
            PlannedShifts = new List<ShiftViewModel>();
            UnavailableMoments = new List<UnavailableMomentsRosterViewModel>();
        }
    }
}
