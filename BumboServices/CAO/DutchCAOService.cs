using BumboData.Models;
using BumboServices.CAO.Rules;
using BumboServices.Interface;

namespace BumboServices.CAO;

public class DutchCAOService : ICAOService
{
    private readonly List<ICAORule> _appliedRules;
        
    public DutchCAOService()
    {
        // Sets up all CAO rules of the dutch CAO
        // All < 16 year rules
        var below16Rules = new List<ICAORule>()
        {
            // - Maximaal 8 uur werken per dag incl. school
            new MaxWorkHours(ageRange: new Range(0, 15), 8.0, true),
            
        };
        
        // All 16 and 17 year rules
        var otherRules = new List<ICAORule>()
        {
            // - Maximaal 9 uur werken per dag incl. school
            new MaxWorkHours(ageRange:new Range(16, 17), 9.0, true),
                
        };

        var generalRules = new List<ICAORule>()
        {
            // Maximaal 12 uur per dienst
            new MaxWorkHours(ageRange: new Range(0, int.MaxValue), 12.0),
        };

        _appliedRules = below16Rules;
        _appliedRules.AddRange(otherRules);
        _appliedRules.AddRange(generalRules);
    }

    /*
     * Returns shift that causes error, and the rule that the error originates from. If the dictionary is empty the planned shifts are valid according to the CAO rules.
     */
    public Dictionary<PlannedShift, ICAORule> VerifyPlannedShiftsWeek(List<PlannedShift> plannedShifts)
    {
        
        return new Dictionary<PlannedShift, ICAORule>();
    }
}