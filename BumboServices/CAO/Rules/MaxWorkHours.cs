using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Utils;

namespace BumboServices.CAO.Rules;

public enum MaxWorkHoursTimeframe
{
    Day,
    Week,
    SchoolWeek
}

public class MaxWorkHours : CAORuleAppliesToAge
{
    private readonly bool _includeSchool;
    private readonly double _maxHours;
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
        if (includeSchool && unavailableMomentsRepository == null) throw new NullReferenceException();

        // If the timeframe is school week, require unavailable moment repository to be present as well.
        if (timeFrame == MaxWorkHoursTimeframe.SchoolWeek && unavailableMomentsRepository == null)
            throw new NullReferenceException();
    }

    public override List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        if (plannedShifts.Count == 0) return new List<PlannedShift>();

        return _timeframe switch
        {
            MaxWorkHoursTimeframe.Day => DayImplementation(plannedShifts),
            MaxWorkHoursTimeframe.Week => WeekImplementation(plannedShifts),
            MaxWorkHoursTimeframe.SchoolWeek => SchoolWeekImplementation(plannedShifts),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private List<PlannedShift> DayImplementation(List<PlannedShift> plannedShifts)
    {
        var employId = plannedShifts.First().EmployeeId;

        return plannedShifts.GroupBy(s => s.StartTime.Date).Where(group =>
        {
            var schoolHours = 0.0;

            if (_includeSchool)
                // Get school hours for that day
                schoolHours = _unavailableMoments.GetSchoolUnavailableMomentsByDay(employId, group.Key.ToDateOnly())
                    .SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours;

            return group.ToList().SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours + schoolHours > _maxHours;
        }).SelectMany(s => s.ToList()).ToList();
    }

    private List<PlannedShift> WeekImplementation(List<PlannedShift> plannedShifts)
    {
        var schoolHours = 0.0;

        if (_includeSchool)
        {
            var employId = plannedShifts.First().EmployeeId;
            var date = plannedShifts.First().StartTime;

            schoolHours = _unavailableMoments
                .GetSchoolUnavailableMomentsByWeek(employId, date.Year, date.GetWeekNumber())
                .SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours;
        }

        // Check if all the shifts given (since the list is always 1 week worth of shifts) don't exceed the max hours.
        if (plannedShifts.SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours + schoolHours > _maxHours)
            // And if it exceeds, all shifts are thus invalid.
            return plannedShifts;

        return new List<PlannedShift>();
    }

    private List<PlannedShift> SchoolWeekImplementation(List<PlannedShift> plannedShifts)
    {
        var employId = plannedShifts.First().EmployeeId;

        // Check if all employees are the same, and if not throw error
        if (plannedShifts.Any(s => s.EmployeeId != employId)) throw new InvalidDataException();

        // First check if current week has any school scheduled.
        var date = plannedShifts.First().StartTime;
        var schoolWeek = _unavailableMoments.EmployeeSchoolWeek(employId, date.Year, date.GetWeekNumber());

        if (schoolWeek)
            // This implementation only applies to when the employee has a school week,
            // it behaves just like the normal week implementation.
            return WeekImplementation(plannedShifts);

        return new List<PlannedShift>();
    }

    public override string GetErrorMessage()
    {
        var timeframe = _timeframe switch
        {
            MaxWorkHoursTimeframe.Day => "dag",
            MaxWorkHoursTimeframe.Week => "week",
            MaxWorkHoursTimeframe.SchoolWeek => "schoolweek",
            _ => throw new ArgumentOutOfRangeException()
        };

        return
            $"Overschreven maximaal aantal uren per {timeframe} is {_maxHours} uur{(_includeSchool ? " inclusief school." : ".")}";
    }
}