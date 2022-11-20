using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BumboData.Enums;

namespace Bumbo.Models.ExportManager;

public class ExportOverviewViewModel
{
    public DateTime SelectedMonth { get; set; }

    public List<DateTime> SelectableMonths { get; set; }

    public string SearchQuery { get; set; }

    public string SearchDepartmentsQuery { get; set; }

    [DisplayName("Sorteren op")]
    public ExportOverviewSortingOption? SortMode { get; set; }

    public List<ExportOverviewListItemViewModel> ExportOverviewListItemViewModels { get; set; }
}