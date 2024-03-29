﻿using BumboData.Models;
using BumboServices.Surcharges.Models;
using BumboServices.Surcharges.SurchargeRules;

namespace Bumbo.Models.ExportManager;

public class ExportOverviewListItemViewModel
{
    public Employee Employee { get; set; }
    public HourExportModel? CurrentMonth { get; set; }
    public HourExportModel? PrevMonth { get; set; }

    public List<WorkedShift>? UnapprovedShifts { get; set; }

    public HourExportModel? GetDifference()
    {
        // Calculate difference between
        var dict = new Dictionary<SurchargeType, TimeSpan>();
        if (CurrentMonth?.Surcharges != null)
            foreach (var surchargesKey in CurrentMonth.Surcharges.Keys)
                dict[surchargesKey] = CurrentMonth.Surcharges[surchargesKey] -
                                      (PrevMonth?.Surcharges[surchargesKey] ?? TimeSpan.Zero);

        return new HourExportModel
        {
            HoursWorked = CurrentMonth.HoursWorked - PrevMonth.HoursWorked,
            Surcharges = dict
        };
    }
}