using BumboData.Models;

namespace BumboDutchCAO.Services.Rules;

public class MaxWorkHoursIncludingSchool: CAORuleAppliesToAge
{
    private readonly double _maxHours;
    public MaxWorkHoursIncludingSchool(Range ageRange, double maxHours): base(ageRange)
    {
        _maxHours = maxHours;
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