using Bumbo.Models.RosterManager;
using Bumbo.Models.WorkedHours;
using BumboData.Models;
using Itenso.TimePeriod;
using System.ComponentModel;
using System.Drawing;

namespace Bumbo.Models.ApproveWorkedHours
{
    public class EmployeeWorkedHoursViewModel : WorkedHoursParentClass
    {


        public string Id { get; set; }

        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }
        [DisplayName("Achternaam")]
        public string LastName { get; set; }
        [DisplayName("Naam")]
        public string FullName => $"{FirstName} {MiddleName} {LastName}";

    }
}
