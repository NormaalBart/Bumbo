using BumboData.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.BranchController
{
    public class BranchListIndexViewModel: PaginatedViewModel
    {
        public List<ListIndexBranchViewModel> Branches { get; set; }
        [DisplayName("Toon actieve filialen")]
        public bool IncludeActive { get; set; }
        [DisplayName("Toon inactieve filialen")]
        public bool IncludeInactive { get; set; }
        public string SearchString { get; set; }

        [DisplayName("Sorteeroptie")]
        public BranchSortingOption CurrentSort { get; set; }

        public List<BranchSortingOption> AvailableSortOptions { get; set; }
        
        public BranchListIndexViewModel()
        {
            Branches = new List<ListIndexBranchViewModel>();
            // available sort options fill with all options from enum
            AvailableSortOptions = new List<BranchSortingOption>();
            foreach (var option in Enum.GetValues(typeof(BranchSortingOption)))
            {
                AvailableSortOptions.Add((BranchSortingOption)option);

            }

        }

        public string GetSortingDisplayName(BranchSortingOption sortoption)
        {
            return sortoption.GetAttribute<DisplayAttribute>().Name;
        }

    }
}
