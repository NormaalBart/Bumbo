using BumboData.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.Index
{
    public class EmployeeListIndexViewModel
    {
        public List<EmployeeListItemViewModel> Employees { get; set; }
        [DisplayName("Toon medewerkers in dienst")]
        public bool IncludeActive { get; set; }
        [DisplayName("Toon medewerkers niet in dients")]
        public bool IncludeInactive { get; set; }
        public string SearchString { get; set; }
        [DisplayName("---")]
        public EmployeeSortingOption CurrentSort { get; set; }

        public List<EmployeeSortingOption> AvailableSortOptions { get; set; }



        public EmployeeListIndexViewModel()
        {
            Employees = new List<EmployeeListItemViewModel>();
            // available sort options fill with all options from enum
            AvailableSortOptions = new List<EmployeeSortingOption>();
            foreach (var option in Enum.GetValues(typeof(EmployeeSortingOption)))
            {
                AvailableSortOptions.Add((EmployeeSortingOption)option);

            }

        }

        public string GetSortingDisplayName(EmployeeSortingOption sortoption)
        {
            return sortoption.GetAttribute<DisplayAttribute>().Name;
        }

    }
}
