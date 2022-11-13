namespace Bumbo.Utils;

public static class DateTime_Extensions
{
    public static DateOnly ToDateOnly(this DateTime dateTime)
    {
        return DateOnly.FromDateTime(dateTime);
    }
}