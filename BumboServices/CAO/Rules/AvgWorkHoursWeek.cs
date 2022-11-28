using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Utils;

namespace BumboServices.CAO.Rules;

public class AvgWorkHoursWeek : CAORuleAppliesToAge
{
    private readonly double _maxAvg;
    private readonly int _amountOfPrevWeeks;
    private readonly IPlannedShiftsRepository _plannedShiftsRepository;

    public AvgWorkHoursWeek(Range ageRange, double maxWeekAvg, int lookAtAmountOfPrevWeeks, IPlannedShiftsRepository plannedShiftsRepository) :
        base(ageRange)
    {
        _maxAvg = maxWeekAvg;
        _plannedShiftsRepository = plannedShiftsRepository;
        _amountOfPrevWeeks = lookAtAmountOfPrevWeeks;
    }

    public override List<PlannedShift> GetInvalidShifts(List<PlannedShift> plannedShifts)
    {
        if (plannedShifts.Count == 0)
        {
            return new List<PlannedShift>();
        }

        var employId = plannedShifts.First().EmployeeId;
        var branchId = plannedShifts.First().BranchId;

        if (plannedShifts.Any(s => s.BranchId != branchId) ||
            plannedShifts.Any(s => s.EmployeeId != employId))
        {
            // Should in theory never happen, but added check just in case.
            throw new InvalidDataException();
        }
        
        // Last shift, from there on we need to subtract the amount of weeks which we are going to look at.
        var firstShiftDateInGivenList = plannedShifts.Min(s => s.StartTime.Date);
        // The date from which we will start calculating the average worked hours
        var startAvgDate = firstShiftDateInGivenList.AddDays((_amountOfPrevWeeks * 7) * -1);

        // Get already planned planned shifts from weeks prior
        var allWorkedShiftsInTimeframe = _plannedShiftsRepository.GetPlannedShiftsInBetween(branchId, employId, startAvgDate, firstShiftDateInGivenList);

        // Add all planned shifts sent along
        allWorkedShiftsInTimeframe.AddRange(plannedShifts);
        
        if (allWorkedShiftsInTimeframe.Count == 0)
        {
            return new List<PlannedShift>();
        };
        
        // Group by week num first, from there on sum up the weekly totals. And calculate the average from that.
        var weeklyAverage = allWorkedShiftsInTimeframe.GroupBy(s => s.StartTime.Date.GetWeekNumber())
            .Select(s => s.ToList()
                .SumTimeSpan(s => s.EndTime - s.StartTime))
            .Average(s => s.TotalHours);

        if (weeklyAverage > _maxAvg)
        {
            // All shifts are invalid, since they all cause the average to be over the limit.
            return plannedShifts;
        }
        
        return new List<PlannedShift>();
    }

    public override string GetErrorMessage()
    {
        return "Gemiddeld aantal uren gewerkt in de afgelopen " + _amountOfPrevWeeks + " weken overschreven, dit mag maximaal " + _maxAvg + " uur zijn.";
    }
}