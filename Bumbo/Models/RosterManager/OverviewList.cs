namespace Bumbo.Models.RosterManager;

public class OverviewList
{
    public OverviewList()
    {
        Days = new List<OverviewItem>();
    }

    public DateTime Date { get; set; }
    public List<OverviewItem> Days { get; set; }

    public OverviewItem? GetDayByIndex(int dayIndex)
    {
        return Days.FirstOrDefault(s => s.Date.Day == dayIndex + 1);
    }

    // returns total number of items that are not sufficiently rostered.
    public int GetTotalNumberOfItemsNotSufficientlyRostered()
    {
        return Days.Sum(d => !d.IsSufficientlyRostered() && d.RosteredHours != 0 ? 1 : 0);
    }

    // returns total number of items that are without roster
    public int GetTotalNumberOfItemsWithoutRoster()
    {
        return Days.Sum(d => d.RosteredHours == 0 ? 1 : 0);
    }

    // returns total number of items that sufficiently roster
    public int GetTotalNumberOfItemsSufficientlyRostered()
    {
        return Days.Sum(d => d.IsSufficientlyRostered() ? 1 : 0);
    }
}