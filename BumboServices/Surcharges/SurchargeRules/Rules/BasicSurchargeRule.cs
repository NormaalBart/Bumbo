using System.Linq.Expressions;
using BumboData.Models;
using Itenso.TimePeriod;

namespace BumboServices.Surcharges.SurchargeRules.Rules;

public class BasicSurchargeRule : ISurchargeRule
{
    private readonly TimeOnly _startTime;
    private readonly TimeOnly _endTime;
    private readonly SurchargeType _surchargeType;
    private readonly Expression<Func<WorkedShift, bool>>? _additionalPredicate;

    public BasicSurchargeRule(TimeOnly startTime, TimeOnly endTime, SurchargeType surchargeType,
        Expression<Func<WorkedShift, bool>>? additionalPredicate = null)
    {
        _startTime = startTime;
        _endTime = endTime;
        _surchargeType = surchargeType;
        _additionalPredicate = additionalPredicate;
    }

    public Dictionary<SurchargeType, TimeSpan> CalculateSurcharges(List<WorkedShift> workedShifts)
    {
        if (_additionalPredicate != null)
        {
            // Apply predicate first
            workedShifts = workedShifts.AsQueryable().Where(_additionalPredicate).ToList();
        }
        
        // Calculate intersecting times
        var sum = (from workedShift in workedShifts.Where(s => s.EndTime != null).ToList()
            let date = workedShift.StartTime
            // Range of the surcharge
            let range =
                new TimeRange(
                    new DateTime(date.Year, date.Month, date.Day, _startTime.Hour, _startTime.Minute, 0),
                    new DateTime(date.Year, date.Month, date.Day, _endTime.Hour, _endTime.Minute, 0))
            // Range of worked time
            let workedRange = new TimeRange(workedShift.StartTime, workedShift.EndTime ?? workedShift.StartTime)
            // Intersect those 2 ranges, and sum up the durations.
            select (workedRange.GetIntersection(range)?.Duration.TotalHours ?? 0)).Sum();

        return new Dictionary<SurchargeType, TimeSpan>()
        {
            {_surchargeType, TimeSpan.FromHours(sum)}
        };
    }
}