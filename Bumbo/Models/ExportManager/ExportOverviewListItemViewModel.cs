using Bumbo.Utils;
using BumboData.Models;
using BumboServices.Surcharges.Models;
using BumboServices.Surcharges.SurchargeRules;

namespace Bumbo.Models.ExportManager;

public class ExportOverviewListItemViewModel
{
    public Employee Employee { get; set; }
    public HourExportModel? CurrentMonth { get; set; }
    public HourExportModel? PrevMonth { get; set; }

    public HourExportModel? GetDifference()
    {
        // Calculate difference between
        var dict = new Dictionary<SurchargeType, TimeSpan>();
        if (CurrentMonth?.Surcharges != null)
        {
            foreach (var surchargesKey in CurrentMonth.Surcharges.Keys)
            {
                dict[surchargesKey] = CurrentMonth.Surcharges[surchargesKey] -
                                      (PrevMonth?.Surcharges[surchargesKey] ?? TimeSpan.Zero);
            }
        }

        return new HourExportModel()
        {
            HoursWorked = CurrentMonth.HoursWorked - PrevMonth.HoursWorked,
            HoursSick = CurrentMonth.HoursSick - PrevMonth.HoursSick,
            Surcharges = dict
        };
    }
}