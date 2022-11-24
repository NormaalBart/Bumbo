using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboServices.CAO.Rules;
using BumboServices.Interface;

namespace BumboServices.CAO;

public class DutchCAOService : ICAOService
{
    private readonly List<ICAORule> _appliedRules;
        
    public DutchCAOService(IUnavailableMomentsRepository unavailableMomentsRepository)
    {
        // Sets up all CAO rules of the dutch CAO
        // All < 16 year rules
        var below16Range = new Range(0, 15);
        var below16Rules = new List<ICAORule>()
        {
            // - Maximaal 8 uur werken per dag incl. school
            new MaxWorkHours(below16Range, 8.0, MaxWorkHoursTimeframe.Day, true, unavailableMomentsRepository),
            //  - Maximaal 40 uur per week
            new MaxWorkHours(below16Range, 40.0, MaxWorkHoursTimeframe.Week),
            //  - Maximaal 12 uur per schoolweek
            new MaxWorkHours(below16Range, 12.0, MaxWorkHoursTimeframe.SchoolWeek, false, unavailableMomentsRepository)
            
        };
        
        // All 16 and 17 year rules
        var otherRules = new List<ICAORule>()
        {
            // - Maximaal 9 uur werken per dag incl. school
            new MaxWorkHours(ageRange:new Range(16, 17), 9.0, MaxWorkHoursTimeframe.Day, true, unavailableMomentsRepository),
                
        };

        var generalRules = new List<ICAORule>()
        {
            // Maximaal 12 uur per dienst
            new MaxConsecutiveHours(12.0),
            // Maximaal 60 uur per week
            new MaxWorkHours(ageRange: new Range(0, int.MaxValue), 60.0, MaxWorkHoursTimeframe.Week)
        };

        _appliedRules = below16Rules;
        _appliedRules.AddRange(otherRules);
        _appliedRules.AddRange(generalRules);
    }

    /*
     * Returns shift that causes error, and the rule that the error originates from. If the dictionary is empty the planned shifts are valid according to the CAO rules.
     */
    public Dictionary<ICAORule, IEnumerable<PlannedShift>> VerifyPlannedShiftsWeek(List<PlannedShift> plannedShifts)
    {
        // The given shifts should be all in the same month.
        // TODO: Throw error otherwise
        var grouped = plannedShifts.GroupBy(s => s.Employee).ToList();
        
        // Sum up all rule invalid shifts
        var res = grouped.SelectMany(g=>
        {
            // For each employee, go through all rules.
            return _appliedRules.Where(r => r.AppliesTo(g.Key))
                .Select(r => (r.GetInvalidShifts(g.ToList()), r))
                .Where(s=>s.Item1.Count != 0).ToList();
        }).ToList();

        // Convert to dictionary for easy readability.
        return res.GroupBy(s => s.r)
            .Select(g=>(g.Key, g.SelectMany(g=>g.Item1)))
            .ToDictionary(s=>s.Key, s=>s.Item2);
    }
}