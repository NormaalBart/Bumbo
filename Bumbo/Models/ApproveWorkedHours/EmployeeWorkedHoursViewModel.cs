using Bumbo.Models.RosterManager;
using BumboData.Models;
using Itenso.TimePeriod;
using System.ComponentModel;
using System.Drawing;

namespace Bumbo.Models.ApproveWorkedHours
{
    public class EmployeeWorkedHoursViewModel
    {
        private const string formatTime = "HH:mm";


        public string Id { get; set; }

        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }
        [DisplayName("Achternaam")]
        public string LastName { get; set; }
        [DisplayName("Naam")]
        public string FullName => $"{FirstName} {MiddleName} {LastName}";


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
            TimeSpan totalPlannendTime = new TimeSpan();
            TimeSpan totalWorkedTime = new TimeSpan();
            foreach (var plannedShift in PlannedShifts)
            {
                TimeSpan timeSpan = plannedShift.EndTime - plannedShift.StartTime;
                totalPlannendTime += timeSpan;
            }
            foreach (var workedShift in WorkedShifts)
            {
                TimeSpan timeSpan =  workedShift.EndTime - workedShift.StartTime;
                totalWorkedTime += timeSpan;
            }

            TimeSpan diff = totalWorkedTime - totalPlannendTime;
            return diff.ToString();
        }

        public EmployeeWorkedHoursViewModel()
        {
            PlannedShifts = new List<ShiftViewModel>();
            WorkedShifts = new List<WorkedShiftViewModel>();
        }
    }
}
