namespace Bumbo.Models.ExportManager;

public class ExportOverviewViewModel
{
    public DateTime SelectedMonth { get; set; }

    public List<DateTime> SelectableMonths { get; set; }

    public string SearchQuery { get; set; }

    public string SearchDepartmentsQuery { get; set; }

    public List<ExportOverviewListItemViewModel> ExportOverviewListItemViewModels { get; set; }
}