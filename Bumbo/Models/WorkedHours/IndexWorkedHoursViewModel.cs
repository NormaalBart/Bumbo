using Bumbo.Models.RosterManager;
using System.Globalization;

namespace Bumbo.Models.ApproveWorkedHours
{
    public class IndexWorkedHoursViewModel
    {
        public DateTime Date { get; set; }
        public List<EmployeeWorkedHoursViewModel> Employees { get; set; }
        
        public IndexWorkedHoursViewModel()
        {
            Employees = new List<EmployeeWorkedHoursViewModel>();
        }

    }
}
