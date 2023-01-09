using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using BumboServices.Utils;

namespace Bumbo.Models.WorkedHours;

public class WorkedHoursParentClass
{
    private const string formatTime = "HH:mm";

    public WorkedHoursParentClass()
    {
        PlannedShifts = new List<ShiftViewModel>();
        WorkedShifts = new List<WorkedShiftViewModel>();
    }

    public List<ShiftViewModel> PlannedShifts { get; set; }
    public List<WorkedShiftViewModel> WorkedShifts { get; set; }

    //These 2 methods need to become one but I dont know how :(
    public string PlannedShiftsToString()
    {
        var shifts = new List<string>();
        foreach (var plannedShift in PlannedShifts)
            shifts.Add(plannedShift.StartTime.ToString(formatTime) + " - " + plannedShift.EndTime.ToString(formatTime));
        if (shifts.Count == 0)
            return "Geen Info";
        return string.Join(",", shifts);
    }

    public string WorkedShiftsToString()
    {
        var shifts = new List<string>();
        foreach (var workedShifts in WorkedShifts)
            shifts.Add(workedShifts.StartTime.ToString(formatTime) + " - " + workedShifts.EndTime.ToString(formatTime));
        if (shifts.Count == 0)
            return "Geen Info";
        return string.Join(",", shifts);
    }

    public string CalculateDifference()
    {
        var totalPlannedTime = PlannedShifts.SumTimeSpan(s => s.EndTime - s.StartTime);
        var totalWorkedTime = WorkedShifts.SumTimeSpan(s => s.EndTime - s.StartTime);
        var diff = totalWorkedTime - totalPlannedTime;
        return diff.ToString("hh\\:mm");
    }
}