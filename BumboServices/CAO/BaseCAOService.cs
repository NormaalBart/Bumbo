using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.CAO.Rules;
using BumboServices.Interface;

namespace BumboServices.CAO;

public abstract class BaseCAOService: ICAOService
{
    protected readonly List<ICAORule> _appliedRules = new List<ICAORule>();

    /*
     * Returns shift that causes error, and the rule that the error originates from. If the dictionary is empty the planned shifts are valid according to the CAO rules.
     */
    public Dictionary<ICAORule, IEnumerable<PlannedShift>> VerifyPlannedShiftsWeek(List<PlannedShift> plannedShifts)
    {
        // The given shifts should be all in the same month.
        if (plannedShifts.Count == 0)
        {
            return new Dictionary<ICAORule, IEnumerable<PlannedShift>>();
        }
        
        var weekNum = plannedShifts.First().StartTime.GetWeekNumber();
        if (plannedShifts.Any(w => w.StartTime.GetWeekNumber() != weekNum))
        {
            // Not all shifts given are in the same week, this is not supported.
            throw new InvalidDataException();
        }

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
        return res.GroupBy(s => s.r)
            .Select(g => (g.Key, g.SelectMany(g => g.Item1)))
            .ToDictionary(s => s.Key, s => s.Item2);
    }
}