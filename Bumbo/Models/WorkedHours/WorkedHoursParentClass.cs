using Bumbo.Models.ApproveWorkedHours;
using Bumbo.Models.RosterManager;
using BumboServices.Utils;

namespace Bumbo.Models.WorkedHours
{
    public class WorkedHoursParentClass
    {
        private const string formatTime = "HH:mm";
        public List<ShiftViewModel> PlannedShifts { get; set; }
        public List<WorkedShiftViewModel> WorkedShifts { get; set; }


        //These 2 methods need to become one but I dont know how :(
        public string PlannedShiftsToString()
        {
            List<String> shifts = new List<String>();
            foreach (var plannedShift in PlannedShifts)
            {
                shifts.Add(plannedShift.StartTime.ToString(formatTime) + " - " + plannedShift.EndTime.ToString(formatTime));
            }
            if (shifts.Count == 0)
            {
                return "Geen Info";
            }
            else
            {
                return string.Join(",", shifts);
            }
        }

        public string WorkedShiftsToString()
        {
            List<String> shifts = new List<String>();
            foreach (var workedShifts in WorkedShifts)
            {
                shifts.Add(workedShifts.StartTime.ToString(formatTime) + " - " + workedShifts.EndTime.ToString(formatTime));
            }
            if (shifts.Count == 0)
            {
                return "Geen Info";
            }
            else
            {
                return string.Join(",", shifts);
            }
        }

        public string CalculateDifference()
        {
            TimeSpan totalPlannedTime = PlannedShifts.SumTimeSpan(s => s.EndTime - s.StartTime);
            TimeSpan totalWorkedTime = WorkedShifts.SumTimeSpan(s => s.EndTime - s.StartTime);
            TimeSpan diff = totalWorkedTime - totalPlannedTime;
            return diff.ToString();
        }

        public WorkedHoursParentClass()
        {
            PlannedShifts = new List<ShiftViewModel>();
            WorkedShifts = new List<WorkedShiftViewModel>();
        }
    }
}
