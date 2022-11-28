using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using BumboData.Models;
using System.Globalization;

namespace Bumbo.Models.WorkedHours
{
    public class EmployeeWorkedHoursListItemViewModel : WorkedHoursParrentClass
    {
        public DateTime Date { get; set; }

        public int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}