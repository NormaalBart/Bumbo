using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Bumbo.Models.RosterManager;

public class OverviewItem
{
    [DataType(DataType.Date)] public DateTime Date { get; set; }

    public double PrognosisHours { get; set; }
    public double RosteredHours { get; set; }

    public bool ItemIsToday()
    {
        if (Date == DateTime.Now.Date) return true;
        return false;
    }

    // if the rostered hours are more than the prognosis hours, return true.
    public bool IsSufficientlyRostered()
    {
        return RosteredHours >= PrognosisHours && RosteredHours > 0;
    }
    
    // if there are rostered hours, but it is not enough we return true
    public bool IsInsufficientlyRostered()
    {
        return RosteredHours < PrognosisHours;
    }

    public string GetDayName()
    {
        // Get dutch culture
        return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Date.DayOfWeek);
    }
}