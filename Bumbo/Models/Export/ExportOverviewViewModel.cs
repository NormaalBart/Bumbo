using System.ComponentModel;
using BumboData.Enums;

namespace Bumbo.Models.ExportManager;

public class ExportOverviewViewModel: PaginatedViewModel
{
    public DateTime SelectedMonth { get; set; }

    public List<DateTime> SelectableMonths { get; set; }
    public List<int> SelectableYears { get; set; }

    public string SearchQuery { get; set; }

    public string SearchDepartmentsQuery { get; set; }

    public List<ExportOverviewListItemViewModel> ExportOverviewListItemViewModels { get; set; }

    public string? SelectedMonthUrlFormatted()
    {
        return SelectedMonth.ToString("yyyy-MM");
    }
}