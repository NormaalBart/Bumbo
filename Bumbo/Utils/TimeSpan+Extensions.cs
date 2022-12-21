namespace Bumbo.Utils;

public static class TimeSpan_Extensions
{
    public static string FormatTotalHourMinutes(this TimeSpan span)
    {
        return Math.Floor(span.TotalHours) + ":" + span.ToString(@"mm");
    }
}