using BumboData.Models;

namespace BumboServices.CAO.Rules;

public class MaxWorkHours: CAORuleAppliesToAge
{
    private readonly double _maxHours;
    private readonly bool _includeSchool;
    
    public MaxWorkHours(Range ageRange, double maxHours, bool includeSchool = false): base(ageRange)
    {
        _maxHours = maxHours;
        _includeSchool = includeSchool;
    }

    public override bool IsValid(List<PlannedShift> plannedShifts)
    {
        throw new NotImplementedException();
    }

    public override string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}