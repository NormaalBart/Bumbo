namespace BumboData.Models;

public class StandardOpeningHours
{
    public Branch Branch { get; set; }

    public int BranchId { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly? OpenTime { get; set; }

    public TimeOnly? CloseTime { get; set; }

    public bool IsClosed { get; set; }
}