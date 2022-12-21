namespace Bumbo.Models.ApproveWorkedHours;

public class IndexWorkedHoursViewModel
{
    public IndexWorkedHoursViewModel()
    {
        Employees = new List<EmployeeWorkedHoursViewModel>();
    }

    public DateTime Date { get; set; }
    public List<EmployeeWorkedHoursViewModel> Employees { get; set; }
}