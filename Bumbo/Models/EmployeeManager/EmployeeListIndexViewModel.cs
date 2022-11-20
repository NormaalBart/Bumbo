using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BumboData.Enums;

namespace Bumbo.Models.EmployeeManager
{
    public class EmployeeListIndexViewModel
    {
        public List<EmployeeListItemViewModel> Employees { get; set; }
        [DisplayName("Toon medewerkers in dienst")]
        public bool IncludeActive { get; set; }
        [DisplayName("Toon medewerkers niet in dients")]
        public bool IncludeInactive { get; set; }
        public string SearchString { get; set; }

        public SortingOption CurrentSort { get; set; }
        
        public List<SortingOption> AvailableSortOptions { get; set; }



        public EmployeeListIndexViewModel()
        {
            Employees = new List<EmployeeListItemViewModel>();
            // available sort options fill with all options from enum
            AvailableSortOptions = new List<SortingOption>();
            foreach (var option in Enum.GetValues(typeof(SortingOption)))
            {
                AvailableSortOptions.Add((SortingOption)option);
                
            }
           
        }

        public string GetSortingDisplayName(SortingOption sortoption)
        {
            return sortoption.GetAttribute<DisplayAttribute>().Name;
        }

    }
}
