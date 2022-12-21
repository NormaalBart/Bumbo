using System.Globalization;
using BumboRepositories.Utils;

namespace Bumbo.Models.EmployeeRoster;

public class EmployeeShiftsListViewModel
{
    public DateOnly Date { get; set; }

    public List<EmployeeShiftViewModel> shifts { get; set; }

    public string GetDay(int dayNumber)
    {
        // We add 1 because it defaults to american culture for some reason where it's different.
        dayNumber++;
        if (dayNumber == 7) return "zo";
        return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek) dayNumber).Substring(0, 2);
    }

    public bool DayIsSelected(int dayNumber)
    {
        dayNumber++;
        if (dayNumber == 7) dayNumber = 0;
        return (int) Date.DayOfWeek == dayNumber;
    }

    public bool IsToday(int i)
    {
        var date = Date.ToDateTime(new TimeOnly(0, 0, 0)).GetMondayOfTheWeek();
        date = date.AddDays(i);
        if (DateTime.Now.Month != Date.Month || DateTime.Now.Year != Date.Year) return false;
        if (date == DateTime.Today.Date) return true;
        return false;
    }

    public DateTime GetDayDate(int dayNumber)
    {
        // returns the date of the specific DayOfTheWeek number
        var monday = Date.ToDateTime(new TimeOnly(0, 0, 0)).GetMondayOfTheWeek();
        return monday.AddDays(dayNumber);
    }
}