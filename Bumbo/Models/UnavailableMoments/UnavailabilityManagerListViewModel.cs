using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BumboData.Enums;

namespace Bumbo.Models.UnavailableMoments;

public class UnavailabilityManagerListViewModel : PaginatedViewModel
{
    public UnavailabilityManagerListViewModel()
    {
        UnavailableMoments = new List<UnavailableMomentsViewModel>();
        AvailableSortOptions = new List<UnavailabilitySortingOption>();
        foreach (var option in Enum.GetValues(typeof(UnavailabilitySortingOption)))
            AvailableSortOptions.Add((UnavailabilitySortingOption) option);
    }

    public List<UnavailableMomentsViewModel> UnavailableMoments { get; set; }

    public DateTime Date { get; set; }

    public string SearchString { get; set; }

    [DisplayName("Afgewerkte aanvragen weergeven")]
    public bool IncludeAccepted { get; set; }

    [DisplayName("Sorteeroptie")] public UnavailabilitySortingOption SortingOption { get; set; }

    public List<UnavailabilitySortingOption> AvailableSortOptions { get; set; }

    public List<int> Ids { get; set; }

    public string GetSortingDisplayName(UnavailabilitySortingOption sortoption)
    {
        return sortoption.GetAttribute<DisplayAttribute>().Name;
    }
}