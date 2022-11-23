using BumboData.Interfaces.Repositories;
using BumboData.Models;

namespace BumboServices.CAO.Rules;

public enum MaxWorkHoursTimeframe
{
    Day,
    Week,
    Month,
    SchoolWeek
}

public class MaxWorkHours : CAORuleAppliesToAge
{
    private readonly double _maxHours;
    private readonly bool _includeSchool;
    private readonly MaxWorkHoursTimeframe _timeframe;
    private readonly IUnavailableMomentsRepository? _unavailableMoments;

    public MaxWorkHours(Range ageRange, double maxHours, MaxWorkHoursTimeframe timeFrame, bool includeSchool = false,
        IUnavailableMomentsRepository? unavailableMomentsRepository = null) :
        base(ageRange)
    {
        _maxHours = maxHours;
        _includeSchool = includeSchool;
        _timeframe = timeFrame;
        _unavailableMoments = unavailableMomentsRepository;

        // Need the repository for include school to function.
        if (includeSchool && unavailableMomentsRepository == null)
        {
            throw new NullReferenceException();
        }

        // If the timeframe is school week, require unavailable moment repository to be present as well.
        if (timeFrame == MaxWorkHoursTimeframe.SchoolWeek && unavailableMomentsRepository == null)
        {
            throw new NullReferenceException();
        }
    }

    public override List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        return _timeframe switch
        {
            MaxWorkHoursTimeframe.Day => DayImplementation(plannedShifts),
            MaxWorkHoursTimeframe.Week => WeekImplementation(plannedShifts),
            MaxWorkHoursTimeframe.Month => MonthImplementation(plannedShifts),
            MaxWorkHoursTimeframe.SchoolWeek => SchoolWeekImplementation(plannedShifts),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private List<PlannedShift> DayImplementation(List<PlannedShift> plannedShifts)
    {
        return new List<PlannedShift>();
        // return plannedShifts.GroupBy(s=>s.StartTime.Date).
    }
    
    private List<PlannedShift> MonthImplementation(List<PlannedShift> plannedShifts)
    {
        return new List<PlannedShift>();
    }
    
    private List<PlannedShift> WeekImplementation(List<PlannedShift> plannedShifts)
    {
        return new List<PlannedShift>();
    }
    
    private List<PlannedShift> SchoolWeekImplementation(List<PlannedShift> plannedShifts)
    {
        return new List<PlannedShift>();
    }
    
    public override string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}