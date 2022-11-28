using BumboData.Models;

namespace BumboServices.CAO.Rules;

public class MaxConsecutiveHours: ICAORule
{
    private readonly double _maxHours;

    public MaxConsecutiveHours(double maxHours)
    {
        _maxHours = maxHours;
    }

    public List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        return plannedShifts
            .Where(s => (s.EndTime - s.StartTime).TotalHours > _maxHours).ToList();
    }
    
    public bool AppliesTo(Employee employee)
    {
        // Applies to all employees
        return true;
    }

    public string GetErrorMessage()
    {
        return "Te lange shift gepland, dit mag maximaal " + _maxHours + " uur zijn.";
    }
}