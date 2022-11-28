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

        public int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
