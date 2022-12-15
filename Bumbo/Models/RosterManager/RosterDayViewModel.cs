using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using BumboData.Models;
using BumboServices.CAO.Rules;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Bumbo.Models.RosterManager
{
    public class RosterDayViewModel
    {

        public int PrognosisDayId { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Kassa afdeling uren")]
        public double CassierePrognoseHours { get; set; }
        [DisplayName("Kassa afdeling medewerkers")]
        public double CassierePrognoseWorkers { get; set; }
        [DisplayName("Vers afdeling uren")]
        public double FreshPrognoseHours { get; set; }
        [DisplayName("Vers afdeling medewerkers")]
        public double FreshPrognoseWorkers { get; set; }
        [DisplayName("Vakken vullers afdeling uren")]
        public double StockersPrognoseHours { get; set; }
        
        // All employees who are already rostered.
        public List<EmployeeRosterViewModel> RosteredEmployees { get; set; }
        // all employees who are available to be chosen when planning a new shift.
        public List<EmployeeRosterViewModel> AvailableEmployees { get; set; }

        // selected stuff for creating a new shift
        public string SelectedEmployeeId { get; set; }
        public int SelectedDepartmentId { get; set; }
        [DataType(DataType.Time)]
        public DateTime SelectedStartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime SelectedEndTime { get; set; }

        public int SelectedShiftId { get; set; }

        public string ErrorMessage { get; set; }

        public Dictionary<ICAORule, List<PlannedShift>> InvalidShifts { get; set; }

        public List<DepartmentRosterViewModel> Departments { get; set; }

        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }

        public int TableMinHour { get; set; }
        public int TableMaxHour { get; set; }



        public RosterDayViewModel()
        {
            RosteredEmployees = new List<EmployeeRosterViewModel>();
            AvailableEmployees = new List<EmployeeRosterViewModel>();
        }

        
        public int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


        public bool IsPlanned(EmployeeRosterViewModel e, int hour)
        {
            if (e.PlannedShifts == null)
            {
                return false;
            }
            List<ShiftViewModel> shifts = e.PlannedShifts.Where(p => p.StartTime.Hour <= hour && p.EndTime.Hour > hour).ToList();
            if (shifts.Count > 0)
            {
                return true;
            }
            return false;
        }
        
        public bool IsUnavailable(EmployeeRosterViewModel employee, int hour)
        {

            List<UnavailableMomentsRosterViewModel> unavailable = employee.UnavailableMoments.Where(u => u.StartTime.Hour <= hour && u.EndTime.Hour > hour).ToList();
            if (unavailable.Count > 0)
            {
                return true;
            }
            return false;
        }

        public Department? GetEmployeeDepartmentShift(EmployeeRosterViewModel employee, int hour)
        {
            if (employee.PlannedShifts == null)
            {
                return null;
            }
            List<ShiftViewModel> shifts = employee.PlannedShifts.Where(p => p.StartTime.Hour <= hour && p.EndTime.Hour > hour).ToList();
            if (shifts.Count > 0)
            {
                return shifts.First().Department;
            }
            return null;
        }


        public void UpdatePrognosis(List<ShiftViewModel> allShifts)
        {
            if (allShifts == null)
            {
                return;
            }
            foreach (var shift in allShifts)
            {
                // TODO Redo code since departments are now stored in db 
                /*if (shift.Department == DepartmentEnum.Cassiere)
                {
                    TimeSpan timespan = shift.EndTime - shift.StartTime;
                    CassierePrognose = CassierePrognose - timespan.TotalHours;
                }
                else if (shift.Department == DepartmentEnum.Fresh)
                {
                    TimeSpan timespan = shift.EndTime - shift.StartTime;
                    FreshPrognose = FreshPrognose - timespan.TotalHours;
                }
                else if (shift.Department == DepartmentEnum.Stocker)
                {
                    TimeSpan timespan = shift.EndTime - shift.StartTime;
                    StockersPrognose = StockersPrognose - timespan.TotalHours;
                }*/
            }
            CassierePrognoseHours = Math.Ceiling(CassierePrognoseHours); 
            FreshPrognoseHours = Math.Ceiling(FreshPrognoseHours); 
            StockersPrognoseHours = Math.Ceiling(StockersPrognoseHours);
            
        }


        public ShiftViewModel? GetShiftOnHourOfEmployee(EmployeeRosterViewModel employee, int hour)
        {
            if (employee.PlannedShifts == null)
            {
                return null;
            }
            List<ShiftViewModel> shifts = employee.PlannedShifts.Where(p => p.StartTime.Hour == hour).ToList();
            if (shifts.Count > 0)
            {
                return shifts.First();
            }
            return null;
        }

        //<summary>
        // Returns the length in amount of hours of the shift of given employee starting on given hour.
        // Returned value does not include minutes. 
        //</summary>
        public int GetShiftHourLength(EmployeeRosterViewModel employee, int hour)
        {
            if (employee.PlannedShifts == null)
            {
                return 0;
            }
            List<ShiftViewModel> shifts = employee.PlannedShifts.Where(p => p.StartTime.Hour == hour).ToList();
            if (shifts.Count > 0)
            {
                return shifts.First().EndTime.Hour - shifts.First().StartTime.Hour;
            }
            return 0;
        }

        public double GetTotalPlannedHoursPerDepartment(string departmentName)
        {
            var allEmployeesOfDepartment = RosteredEmployees.Where(r => r.PlannedShifts.Any(p => p.Department.DepartmentName == departmentName));
            double total = 0;
            foreach (var employee in allEmployeesOfDepartment)
            {
                foreach (var plannedShift in employee.PlannedShifts)
                {
                    total += (plannedShift.EndTime - plannedShift.StartTime).TotalHours;
                }
            }
            return total;
        }

        public int GetTotalPlannedWorkersPerDepartment(string departmentName)
        {
            var allEmployeesOfDepartment = RosteredEmployees.Where(r => r.PlannedShifts.Any(p => p.Department.DepartmentName == departmentName));
            int total = 0;
            foreach (var employee in allEmployeesOfDepartment)
            {
                total++;
            }
            return total;
        }


        // These 2 methods return a percentage of the start and end time so the off set can be set in the frontend
        // there's probably a better way of doing these, possibly by returning a time span
        // and then calculating the percentages in the view. But for now this works perfectly fine
        // No need to overcomplicate this.
        public int GetShiftStartPercentage(EmployeeRosterViewModel employee, int hour)
        {
            if (employee.PlannedShifts == null)
            {
                return 0;
            }
            List<ShiftViewModel> shifts = employee.PlannedShifts.Where(p => p.StartTime.Hour == hour).ToList();
            if (shifts.Count > 0)
            {
                // convert minutes into percentage of hour
                return this.CalculateMinutePercentage(shifts.First().StartTime.Minute);

            }
            return 0;
        }

        public int GetShiftEndPercentage(EmployeeRosterViewModel employee, int hour)
        {
            if (employee.PlannedShifts == null)
            {
                return 0;
            }
            List<ShiftViewModel> shifts = employee.PlannedShifts.Where(p => p.StartTime.Hour == hour).ToList();
            if (shifts.Count > 0)
            {
                // convert minutes into percentage of hour
                return this.CalculateMinutePercentage(shifts.First().EndTime.Minute);

            }
            return 0;
        }

        private int CalculateMinutePercentage(double minute)
        {
            double shiftpercentage = (minute / 60) * 100;
            return (int)Math.Floor(shiftpercentage);
        }

        // It's important that this display time is always the same amount of characters long.
        public string GetHeaderTimeString(int time)
        {
            TimeOnly timeOnly = new TimeOnly(time, 0);
            return timeOnly.ToString();
        }

        public bool IsOutSideOfOpeningTimes(int hour)
        {

            if (hour < OpenTime.Hour || hour >= CloseTime.Hour)
            {
                return true;
            }
            return false;



        }

    }
}
