using System.Globalization;

namespace BumboRepositories.Utils;

public static class DateTime_Extensions
{
    public static DateOnly ToDateOnly(this DateTime dateTime)
    {
        return DateOnly.FromDateTime(dateTime);
    }

    public static int GetWeekNumber(this DateTime dateTime)
    {
        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek,
            DayOfWeek.Monday);
    }

    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }

    public static DateTime LastDayOfWeek(this DateTime date)
    {
        var ldowDate = StartOfWeek(date, DayOfWeek.Monday).AddDays(6);
        return ldowDate;
    }

    public static DateTime GetMondayOfTheWeek(this DateTime currentDate)
    {
        // start of week, calculated by getting the difference between the date and monday.
        // This method should probably be moved to a static class as it is used in multiple places.
        var diff = DayOfWeek.Monday - currentDate.DayOfWeek;
        if (diff > 0)
            diff -= 7;
        var startOfWeek = currentDate.AddDays(diff);
        return startOfWeek;
    }
}

public static class OtherUtils
{
    public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
    {
        var jan1 = new DateTime(year, 1, 1);
        var daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

        // Use first Thursday in January to get first week of the year as
        // it will never be in Week 52/53
        var firstThursday = jan1.AddDays(daysOffset);
        var cal = CultureInfo.CurrentCulture.Calendar;
        var firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        var weekNum = weekOfYear;
        // As we're adding days to a date in Week 1,
        // we need to subtract 1 in order to get the right date for week #1
        if (firstWeek == 1) weekNum -= 1;

        // Using the first Thursday as starting week ensures that we are starting in the right year
        // then we add number of weeks multiplied with days
        var result = firstThursday.AddDays(weekNum * 7);

        // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
        return result.AddDays(-3);
    }
}