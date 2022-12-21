using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using BumboData.Enums;
using BumboData.Models;
using BumboServices.CAO.Rules;

namespace Bumbo.Models.RosterManager;

public class RosterDayViewModel
{
    public RosterDayViewModel()
    {
        RosteredEmployees = new List<EmployeeRosterViewModel>();
        AvailableEmployees = new List<EmployeeRosterViewModel>();
    }

    public int PrognosisDayId { get; set; }
    public DateTime Date { get; set; }

    [DisplayName("Kassa afdeling uren")] public double CassierePrognoseHours { get; set; }

    [DisplayName("Kassa afdeling medewerkers")]
    public double CassierePrognoseWorkers { get; set; }

    [DisplayName("Vers afdeling uren")] public double FreshPrognoseHours { get; set; }

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

    [DataType(DataType.Text)] public DateTime SelectedStartTime { get; set; }

    [DataType(DataType.Text)] public DateTime SelectedEndTime { get; set; }

    public int SelectedShiftId { get; set; }

    public string ErrorMessage { get; set; }

    public Dictionary<ICAORule, List<PlannedShift>> InvalidShifts { get; set; }

    public List<DepartmentRosterViewModel> Departments { get; set; }

    [DataType(DataType.Date)] public DateTime CopyFrom { get; set; }

    [DataType(DataType.Date)] public DateTime CopyTo { get; set; }

    public int CopiedShifts { get; set; }

    public TimeOnly OpenTime { get; set; }
    public TimeOnly CloseTime { get; set; }

    public int TableMinHour { get; set; }
    public int TableMaxHour { get; set; }

    public int GetWeekNumber(DateTime date)
    {
        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek,
            DayOfWeek.Monday);
    }

    public bool IsPlanned(EmployeeRosterViewModel e, int hour)
    {
        return e.PlannedShifts != null && e.PlannedShifts.Any(p => p.StartTime.Hour <= hour && p.EndTime.Hour > hour);
    }

    public ShiftViewModel? GetShiftOnHourOfEmployee(EmployeeRosterViewModel employee, int hour)
    {
        if (employee.PlannedShifts == null) return null;

        return employee.PlannedShifts.FirstOrDefault(p => p.StartTime.Hour == hour);
    }

    //<summary>
    // Returns the length in amount of hours of the shift of given employee starting on given hour.
    // Returned value does not include minutes. 
    //</summary>
    public int GetShiftHourLength(EmployeeRosterViewModel employee, int hour)
    {
        var s = GetShiftOnHourOfEmployee(employee, hour);
        if (s != null) return s.EndTime.Hour - s.StartTime.Hour;
        return 0;
    }

    public double GetTotalPlannedHoursPerDepartment(DepartmentType department)
    {
        var allEmployeesOfDepartment =
            RosteredEmployees.Where(r => r.PlannedShifts.Any(p => p.Department.DepartmentName == department.Name));
        return allEmployeesOfDepartment.Sum(employee =>
            employee.PlannedShifts.Sum(plannedShift => (plannedShift.EndTime - plannedShift.StartTime).TotalHours));
    }

    public int GetTotalPlannedWorkersPerDepartment(DepartmentType department)
    {
        var allEmployeesOfDepartment =
            RosteredEmployees.Where(r => r.PlannedShifts.Any(p => p.Department.DepartmentName == department.Name));
        return allEmployeesOfDepartment.Count();
    }

    // These 2 methods return a percentage of the start and end time so the off set can be set in the frontend
    // there's probably a better way of doing these, possibly by returning a time span
    // and then calculating the percentages in the view. But for now this works perfectly fine
    // No need to overcomplicate this.
    public int GetShiftStartPercentage(EmployeeRosterViewModel employee, int hour)
    {
        if (employee.PlannedShifts == null) return 0;
        var shift = GetShiftOnHourOfEmployee(employee, hour);

        return shift != null ? CalculateMinutePercentage(shift.StartTime.Minute) : 0;
    }

    public int GetShiftEndPercentage(EmployeeRosterViewModel employee, int hour)
    {
        if (employee.PlannedShifts == null) return 0;
        var shift = GetShiftOnHourOfEmployee(employee, hour);

        return shift != null ? CalculateMinutePercentage(shift.EndTime.Minute) : 0;
    }

    private int CalculateMinutePercentage(double minute)
    {
        var shiftpercentage = minute / 60 * 100;
        return (int) Math.Floor(shiftpercentage);
    }

    // It's important that this display time is always the same amount of characters long.
    public string GetHeaderTimeString(int time)
    {
        var timeOnly = new TimeOnly(time, 0);
        return timeOnly.ToString();
    }

    public bool IsOutSideOfOpeningTimes(int hour)
    {
        return hour < OpenTime.Hour || hour >= CloseTime.Hour;
    }
}