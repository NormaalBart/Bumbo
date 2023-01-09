namespace Bumbo.Models.ApproveWorkedHours;

public class WorkedShiftViewModel
{
    public int Id { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public bool Approved { get; set; }

    public bool Sick { get; set; }
}