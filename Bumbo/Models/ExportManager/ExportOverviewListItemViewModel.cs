using Bumbo.Utils;
using BumboData.Models;
using BumboRepositories;

namespace Bumbo.Models.ExportManager;

public class ExportOverviewListItemViewModel
{
    public Employee Employee { get; set; }
    public ExportOverviewMonthInfo CurrentMonth { get; set; }
    public ExportOverviewMonthInfo PrevMonth { get; set; }

    public ExportOverviewMonthInfo GetDifference()
    {
        return new ExportOverviewMonthInfo()
        {
            Month = null,
            HoursWorked = CurrentMonth.HoursWorked - PrevMonth.HoursWorked,
            HoursSick = CurrentMonth.HoursSick - PrevMonth.HoursSick,
            SurchargesHoliday = CurrentMonth.SurchargesHoliday - PrevMonth.SurchargesHoliday,
            Surcharges50 = CurrentMonth.Surcharges50 - PrevMonth.Surcharges50,
            Surcharges33 = CurrentMonth.Surcharges33 - PrevMonth.Surcharges33,
        };
    }
    
    public static ExportOverviewListItemViewModel FromWorkedShifts(
        Employee employee,
        List<WorkedShift> workedShiftsCurrentMonth, 
        List<WorkedShift> prevMonthWorkedShifts)
    {
        return new ExportOverviewListItemViewModel()
        {
            Employee = employee,
            CurrentMonth = FromWorkedShiftsToExportOverview(workedShiftsCurrentMonth),
            PrevMonth = FromWorkedShiftsToExportOverview(workedShiftsCurrentMonth),
        };
    }

    private static ExportOverviewMonthInfo FromWorkedShiftsToExportOverview(List<WorkedShift> shifts)
    {
        // Only allow shifts in the same month
        var first = shifts.FirstOrDefault();
        shifts = shifts.Where(s => s.StartTime.Year == first?.StartTime.Year && 
                                   s.StartTime.Month == first?.StartTime.Month).ToList();
        
        return new ExportOverviewMonthInfo()
        {
            HoursWorked = shifts.SumTimeSpan(i=> (i.EndTime ?? i.StartTime) - i.StartTime).TotalHours,
            HoursSick = shifts.Where(i=>i.Sick)
                .SumTimeSpan(i=> (i.EndTime ?? i.StartTime) - i.StartTime).TotalHours
        };
    }
}

public class ExportOverviewMonthInfo
{
    public DateTime? Month { get; set; }
    
    public double HoursWorked { get; set; }

    public double HoursSick { get; set; }

    public double SurchargesHoliday { get; set; }

    public double Surcharges50 { get; set; }

    public double Surcharges33 { get; set; }
}