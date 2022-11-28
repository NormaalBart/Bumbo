using BumboData.Models;

namespace BumboServices.CAO.Rules;

public class MaxShiftEndTime : CAORuleAppliesToAge
{
    private readonly TimeOnly _maxShiftEndTime;

    public MaxShiftEndTime(Range ageRange, TimeOnly maxShiftEndTime) :
        base(ageRange)
    {
        _maxShiftEndTime = maxShiftEndTime;
    }

    public override List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        // Check if the end time is after allowed shift end time.
        return plannedShifts.Where(s => TimeOnly.FromDateTime(s.EndTime) > _maxShiftEndTime).ToList();
    }

    public override string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}