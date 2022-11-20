using BumboRepositories.Utils;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;

namespace Bumbo.Models.EmployeeRoster
{
    public class EmployeeShiftsListViewModel
    {
        public DateOnly Date { get; set; }

        public List<EmployeeShiftViewModel> shifts { get; set; }

        // returns the day name of the number of the week
        public string GetDay(int dayNumber)
        {
            // We add 1 because it defaults to american culture for some reason where it's different.
            dayNumber++;
            if(dayNumber == 7)
            {
                return "zo";
            }
            return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)dayNumber).Substring(0, 2);
        }

        public bool DayIsSelected(int dayNumber)
        {
            dayNumber++;
            if (dayNumber == 7)
            {
                dayNumber = 0;
            }
            return ((int)Date.DayOfWeek) == dayNumber;
        }

        public bool IsToday(int dayNumber)
        {
            if(DateTime.Now.Month != Date.Month || DateTime.Now.Year != Date.Year)
            {
               return false;
            }
            dayNumber++;
            if (dayNumber == 7)
            {
                dayNumber = 0;
            }
            return ((int)DateTime.Today.DayOfWeek) == dayNumber;
        }

        public DateTime GetDayDate(int dayNumber)
        {
            // returns the date of the specific DayOfTheWeek number
            DateTime monday = Date.ToDateTime(new TimeOnly(0,0,0)).GetMondayOfTheWeek();
            return monday.AddDays(dayNumber);
        }

        
    }
}
