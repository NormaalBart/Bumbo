using BumboServices.Surcharges.SurchargeRules;

namespace BumboServices.Surcharges.Models;

public class HourExportModel
{
    public TimeSpan HoursWorked { get; set; }
    
    public Dictionary<SurchargeType, TimeSpan> Surcharges { get; set; }
}