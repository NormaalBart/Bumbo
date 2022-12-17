namespace Bumbo.Models.EmployeeRoster
{
    public class EmployeeShiftsListViewModel
    {
        public DateOnly Date { get; set; }

        public List<EmployeeShiftViewModel> shifts { get; set; }

    }
}
