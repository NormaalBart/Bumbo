using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.CAO.Rules;
using BumboServices.Interface;

namespace BumboServices.CAO;

public abstract class BaseCAOService : ICAOService
{
    protected readonly List<ICAORule> _appliedRules = new();

    /*
     * Returns shift that causes error, and the rule that the error originates from. If the dictionary is empty the planned shifts are valid according to the CAO rules.
     */
    public Dictionary<ICAORule, List<PlannedShift>> VerifyPlannedShifts(List<PlannedShift> plannedShifts,
        DateOnly forDay)
    {
        if (plannedShifts.Count == 0) return new Dictionary<ICAORule, List<PlannedShift>>();

        // The given shifts should be all in the same week.
        var weekNum = plannedShifts.First().StartTime.GetWeekNumber();
        if (plannedShifts.Any(w => w.StartTime.GetWeekNumber() != weekNum))
            // Not all shifts given are in the same week, this is not supported.
            throw new InvalidDataException();

        // Group shifts by employee
        var grouped = plannedShifts.GroupBy(s => s.Employee).ToList();

        // Sum up all rule invalid shifts
        var res = grouped.SelectMany(g =>
        {
            // For each employee, go through all rules.
            return _appliedRules.Where(r => r.AppliesTo(g.Key))
                .Select(r => (r.GetInvalidShifts(g.ToList()), r))
                .Where(s => s.Item1.Count != 0).ToList();
        }).ToList();

        // Convert to dictionary for easy readability.
        var resp = res.GroupBy(s => s.r)
            .Select(g => (g.Key, g.SelectMany(g => g.Item1)))
            .ToDictionary(s => s.Key, s => s.Item2);

        // Convert so it returns the issues for the target day only.
        return resp
            .Select(s => (s.Key, s.Value.Where(s => s.StartTime.Day == forDay.Day &&
                                                    s.StartTime.Year == forDay.Year &&
                                                    s.StartTime.Month == forDay.Month).ToList()))
            // Filter our empty rule violations
            .Where(s => s.Item2.Any())
            .ToDictionary(d => d.Key, d => d.Item2);
    }
}