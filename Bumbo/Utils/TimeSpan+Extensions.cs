namespace Bumbo.Utils;

public static class TimeSpan_Extensions
{
    public static TimeSpan SumTimeSpan<TSource>(this IEnumerable<TSource> source, Func<TSource, TimeSpan> selector)
    {
        return source.Select(selector).Aggregate(TimeSpan.Zero, (t1, t2) => t1 + t2);
    }
}