using BumboData.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailabilityManagerListViewModel
    {
        public List<UnavailableMomentsViewModel> UnavailableMoments { get; set; }

        public DateTime Date { get; set; }
        
        public string SearchString { get; set; }

        [DisplayName("Afgewerkte aanvragen weergeven")]
        public bool IncludeAccepted { get; set; }

        [DisplayName("Sorteeroptie")]
        public UnavailabilitySortingOption SortingOption { get; set; }

        public List<UnavailabilitySortingOption> AvailableSortOptions { get; set; }

        public List<int> Ids { get; set; }

        public int Page { get; set; }

        public int MaxPage { get; set; }

        public UnavailabilityManagerListViewModel()
        {
            UnavailableMoments = new List<UnavailableMomentsViewModel>();
            AvailableSortOptions = new List<UnavailabilitySortingOption>();
            foreach (var option in Enum.GetValues(typeof(UnavailabilitySortingOption)))
            {
                AvailableSortOptions.Add((UnavailabilitySortingOption)option);
            }
        }
        public string GetSortingDisplayName(UnavailabilitySortingOption sortoption)
        {
            return sortoption.GetAttribute<DisplayAttribute>().Name;
        }
    }
}
