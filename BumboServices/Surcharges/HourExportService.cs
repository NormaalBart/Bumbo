using BumboData.Models;
using BumboServices.Interface;
using BumboServices.Surcharges.Models;
using BumboServices.Surcharges.SurchargeRules;
using BumboServices.Surcharges.SurchargeRules.Rules;
using BumboServices.Utils;

namespace BumboServices;

public class HourExportService : IHourExportService
{
    private List<ISurchargeRule> _useSurchargesRules;

    public HourExportService()
    {
        // Set rules that the hour export service uses.
        _useSurchargesRules = new List<ISurchargeRule>()
        {
            // Op zon- en feestdagen 100% ( ook voor hulpkrachten)
            new SunOrHolidaySurchargeRule(),
            // Op zaterdag tussen 18.00 en 24.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(18, 00),
                new TimeOnly(23, 59),
                SurchargeType.Surcharge50,
                i => i.StartTime.DayOfWeek == DayOfWeek.Saturday),
            // tussen 21.00 en 24.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(21, 00),
                new TimeOnly(23, 59),
                SurchargeType.Surcharge50),
            // tussen 20.00 en 21.00 uur 33 1/3%
            new BasicSurchargeRule(
                new TimeOnly(20, 00),
                new TimeOnly(21, 00),
                SurchargeType.Surcharge33),
            // tussen 00.00 en 06.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(00, 00),
                new TimeOnly(6, 00),
                SurchargeType.Surcharge50)
        };
    }

    public HourExportModel WorkedShiftsToExportOverview(List<WorkedShift> shifts)
    {
        // Only allow shifts in the same month
        var first = shifts.FirstOrDefault();
        shifts = shifts.Where(s => s.StartTime.Year == first?.StartTime.Year &&
                                   s.StartTime.Month == first?.StartTime.Month).ToList();

        var dict = new Dictionary<SurchargeType, TimeSpan>();

        // Add all with zero value
        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
        {
            dict[surchargeType] = TimeSpan.Zero;
        }

        // Add actual surcharge values for each rule
        if (shifts.Count != 0)
        {
            _useSurchargesRules.ForEach(s =>
            {
                var dictAdd = s.CalculateSurcharges(shifts);
                foreach (var value in dictAdd.Keys)
                {
                    dict[value] = dict.GetValueOrDefault(value) + dictAdd[value];
                }
            });
        }

        return new HourExportModel()
        {
            HoursWorked = shifts.SumTimeSpan(i => (i.EndTime ?? i.StartTime) - i.StartTime),
            HoursSick = shifts.Where(i => i.Sick)
                .SumTimeSpan(i => (i.EndTime ?? i.StartTime) - i.StartTime),
            Surcharges = dict
        };
    }
}