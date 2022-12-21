namespace Bumbo.Models.WorkedHours;

public class EmployeeWorkedHoursListViewModel
{
    public EmployeeWorkedHoursListViewModel()
    {
        employeeWorkedHoursListItemViewModels = new List<EmployeeWorkedHoursListItemViewModel>();
    }

    public List<EmployeeWorkedHoursListItemViewModel> employeeWorkedHoursListItemViewModels { get; set; }
    public DateTime Date { get; set; }
}