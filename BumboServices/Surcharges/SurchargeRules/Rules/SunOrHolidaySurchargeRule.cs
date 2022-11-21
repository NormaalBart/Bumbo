using BumboData.Models;
using BumboServices.Utils;
using PublicHoliday;

namespace BumboServices.Surcharges.SurchargeRules.Rules;

public class SunOrHolidaySurchargeRule: ISurchargeRule
{
    public Dictionary<SurchargeType, TimeSpan> CalculateSurcharges(List<WorkedShift> workedShifts)
    {
        // If the shift is done on a holiday or sunday, HOLIDAY surcharge is given.
        var holidayHelper = new DutchPublicHoliday();
        
        return new Dictionary<SurchargeType, TimeSpan>()
        {
            { SurchargeType.Holiday, workedShifts.Where(i =>
                    holidayHelper.IsPublicHoliday(i.StartTime) || i.StartTime.DayOfWeek == DayOfWeek.Sunday)
                .SumTimeSpan(i => (i.EndTime ?? i.StartTime) - i.StartTime) }
        };
    }
}