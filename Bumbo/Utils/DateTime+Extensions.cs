using System.Globalization;

namespace Bumbo.Utils;

public static class DateTime_Extensions
{
    public static int GetWeekNumber(this DateTime dateTime)
    {
        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek,
            DayOfWeek.Monday);
    }
}