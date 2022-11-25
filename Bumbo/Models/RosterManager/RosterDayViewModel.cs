using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using BumboData.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Bumbo.Models.RosterManager
{
    public class RosterDayViewModel
    {

        public int PrognosisDayId { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Kassa Afdeling")]
        public double CassierePrognose { get; set; }
        [DisplayName("Vers Afdeling")]
        public double FreshPrognose { get; set; }
        [DisplayName("VakkenVullers Afdeling")]
        public double StockersPrognose { get; set; }
        
        public List<EmployeeRosterViewModel> Employees { get; set; }

        // selected employee in modal for adding new employee
        public int SelectedEmployeeId { get; set; }
        public int SelectedDepartmentId { get; set; }
        [DataType(DataType.Time)]
        public DateTime SelectedStartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime SelectedEndTime { get; set; }

        // business hours
        public int OpeningHour { get; set; }
        public int ClosingHour { get; set; }

        public List<DepartmentRosterViewModel> Departments { get; set; }


        public RosterDayViewModel()
        {
            Employees = new List<EmployeeRosterViewModel>();
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
            CassierePrognose = Math.Round(CassierePrognose,2); //moet dit omhoog afgerond worden? of is dit goed zo?
            FreshPrognose = Math.Round(FreshPrognose,2); //moet dit omhoog afgerond worden? of is dit goed zo?
            StockersPrognose = Math.Round(StockersPrognose, 2);
            
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

        public double GetShiftLength(EmployeeRosterViewModel employee, int hour)
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
                int minute = shifts.First().StartTime.Minute;
                return (minute / 60) * 100;

            }
            return 0;
        }

    }
}
