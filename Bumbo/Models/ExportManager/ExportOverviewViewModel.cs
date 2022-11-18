namespace Bumbo.Models.ExportManager;

public class ExportOverviewViewModel
{
    public DateTime SelectedMonth { get; set; }

    public List<DateTime> SelectableMonths { get; set; }

    public String SearchQuery { get; set; }

    public String SearchDepartmentsQuery { get; set; }

    public List<ExportOverviewListItemViewModel> ExportOverviewListItemViewModels { get; set; }

    public ExportOverviewViewModel()
    {
        
    }
}