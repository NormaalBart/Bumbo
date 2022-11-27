using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.CAO.Rules;
using BumboServices.Interface;

namespace BumboServices.CAO;

public class DutchCAOService : BaseCAOService
{
    public DutchCAOService(IUnavailableMomentsRepository unavailableMomentsRepository,
        IPlannedShiftsRepository plannedShiftsRepository)
    {
        // Sets up all CAO rules of the dutch CAO
        // All < 16 year rules
        var below16Range = new Range(0, 15);
        var below16Rules = new List<ICAORule>()
        {
            // - Maximaal 8 uur werken per dag incl. school
            new MaxWorkHours(below16Range, 8.0, MaxWorkHoursTimeframe.Day, true, unavailableMomentsRepository),
            //  - Maximaal 40 uur per week
            new MaxWorkHours(below16Range, 40.0, MaxWorkHoursTimeframe.Week),
            //  - Maximaal 12 uur per schoolweek
            new MaxWorkHours(below16Range, 12.0, MaxWorkHoursTimeframe.SchoolWeek, false, unavailableMomentsRepository),
            // - Maximaal 5 dagen per week
            new MaxWorkDaysInWeek(below16Range, 5),
            // - Maximaal tot 19:00
            new MaxShiftEndTime(below16Range, new TimeOnly(19, 00))
        };

        // All 16 and 17 year rules
        var otherRange = new Range(16, 17);
        var otherRules = new List<ICAORule>()
        {
            // - Maximaal 9 uur werken per dag incl. school
            new MaxWorkHours(otherRange, 9.0, MaxWorkHoursTimeframe.Day, true, unavailableMomentsRepository),
            // - Niet meer dan 40 uur gemiddeld over een periode van 4 weken.
            // niet meer dan 40 uur gemiddeld per week ???
            // TODO: Navragen
            new AvgWorkHoursWeek(otherRange, 40.0, 4, plannedShiftsRepository)
        };

        var generalRules = new List<ICAORule>()
        {
            // Maximaal 12 uur per dienst
            new MaxConsecutiveHours(12.0),
            // Maximaal 60 uur per week
            new MaxWorkHours(new Range(0, int.MaxValue), 60.0, MaxWorkHoursTimeframe.Week)
        };

        _appliedRules.AddRange(below16Rules);
        _appliedRules.AddRange(otherRules);
        _appliedRules.AddRange(generalRules);
    }
}