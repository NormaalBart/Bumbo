using BumboData.Models;

namespace BumboServices.CAO.Rules;

public class MaxWorkDaysInWeek : CAORuleAppliesToAge
{
    private readonly int _maxWorkDays;

    public MaxWorkDaysInWeek(Range ageRange, int maxWorkDays) :
        base(ageRange)
    {
        _maxWorkDays = maxWorkDays;
    }

    public override List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        var workDays = plannedShifts.GroupBy(s => s.StartTime.Date).Count();

        if (workDays > _maxWorkDays)
        {
            // Return the shifts that need to be excluded for this rule to pass.
            var ret = plannedShifts.OrderByDescending(s => s.StartTime.Date)
                .Take(_maxWorkDays).ToList();
            return ret;
        }
        
        return new List<PlannedShift>();
    }

    public override string GetErrorMessage()
    {
        return "Medewerker is voor te veel dagen in de week ingepland, dit mag maximaal " + _maxWorkDays +
               " dagen zijn.";
    }
}