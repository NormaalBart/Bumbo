using Bumbo.Models.ApproveWorkedHours;
using BumboData.Models;
using System.Globalization;

namespace Bumbo.Models.WorkedHours
{
    public class EmployeeWorkedHoursListViewModel
    {
        public List<EmployeeWorkedHoursListItemViewModel> employeeWorkedHoursListItemViewModels { get; set; }
        public DateTime Date { get; set; }

        public EmployeeWorkedHoursListViewModel()
        {
            employeeWorkedHoursListItemViewModels = new List<EmployeeWorkedHoursListItemViewModel>();
        }
    }
}
