using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Utils;

namespace BumboServices.CAO.Rules;

public class AvgWorkHoursWeek : CAORuleAppliesToAge
{
    private readonly double _maxAvg;
    private readonly int _amountOfPrevWeeks;
    private readonly IWorkedShiftRepository _workedShiftRepository;

    public AvgWorkHoursWeek(Range ageRange, double maxWeekAvg, int lookAtAmountOfPrevWeeks, IWorkedShiftRepository workedShiftRepository) :
        base(ageRange)
    {
        _maxAvg = maxWeekAvg;
        _workedShiftRepository = workedShiftRepository;
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
        
        // Last shift, from there on we need to subtract the amount of weeks which we are going to look at.
        var lastShiftDate = plannedShifts.Max(s => s.StartTime.Date);
        // The date from which we will start calculating the average worked hours
        var startAvgDate = lastShiftDate.AddDays((_amountOfPrevWeeks * 7) * -1);

        var allWorkedShiftsInTimeframe = _workedShiftRepository.GetWorkedShiftsInBetween(branchId, employId, startAvgDate, lastShiftDate);

        if (allWorkedShiftsInTimeframe.Count == 0)
        {
            return new List<PlannedShift>();
        };
        
        // Group by week num first, from there on sum up the weekly totals. And calculate the average from that.
        var weeklyAverage = allWorkedShiftsInTimeframe.GroupBy(s => s.StartTime.Date.GetWeekNumber())
            .Select(s => s.ToList()
                .SumTimeSpan(s => (s.EndTime ?? s.StartTime) - s.StartTime))
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
        throw new NotImplementedException();
    }
}