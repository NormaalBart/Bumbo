using System.ComponentModel;
using System.Globalization;
using BumboData.Models;

namespace Bumbo.Models.RosterManager
{
    public class RosterDayViewModel
    {
        //[DisplayName("Kassa Afdeling")]
        //public double? UpdatedCassiereDepartment => Math.Round((double)(PrognosisDay.CassiereDepartment - this.UpdatePrognosisWithoutPlannedHours(DepartmentEnum.Cassiere)), 2);
        //[DisplayName("Vers Afdeling")]
        //public double? UpdatedFreshDepartment => Math.Round((double)(PrognosisDay.FreshDepartment - this.UpdatePrognosisWithoutPlannedHours(DepartmentEnum.Fresh)), 2);
        //[DisplayName("VakkenVullers Afdeling")]
        //public double? UpdatedStockersDepartment => Math.Round((double)(PrognosisDay.StockersDepartment - UpdatePrognosisWithoutPlannedHours(DepartmentEnum.Stocker)), 2);

        public int PrognosisDayId { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Kassa Afdeling")]
        public double CassierePrognose { get; set; }
        [DisplayName("Vers Afdeling")]
        public double FreshPrognose { get; set; }
        [DisplayName("VakkenVullers Afdeling")]
        public double StockersPrognose { get; set; }
        
        public List<EmployeeRosterViewModel> Employees { get; set; }

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
            CassierePrognose = Math.Round(CassierePrognose,2);
            FreshPrognose = Math.Round(FreshPrognose,2);
            StockersPrognose = Math.Round(StockersPrognose, 2);
            
        }

    }
}
