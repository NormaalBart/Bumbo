using System.Globalization;
using System.Runtime.CompilerServices;

namespace Bumbo.Utils;

public static class DateTime_Extensions
{
    public static DateOnly ToDateOnly(this DateTime dateTime)
    {
        return DateOnly.FromDateTime(dateTime);
    }

    public static int GetWeekNumber(this DateTime dateTime)
    {
        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
    }

    public static DateTime GetMondayOfTheWeek(this DateTime currentDate)
    {
        // start of week, calculated by getting the difference between the date and monday.
        // This method should probably be moved to a static class as it is used in multiple places.
        int diff = DayOfWeek.Monday - currentDate.DayOfWeek;
        if (diff > 0)
            diff -= 7;
        var startOfWeek = currentDate.AddDays(diff);
        return startOfWeek;
    }
        
}