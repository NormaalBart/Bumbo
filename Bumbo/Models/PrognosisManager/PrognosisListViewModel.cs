namespace Bumbo.Models.PrognosisManager;

public class PrognosisListViewModel
{
    public PrognosisListViewModel()
    {
        PrognosisList = new List<PrognosisViewModel>();
    }

    public List<PrognosisViewModel> PrognosisList { get; set; }

    public int CopyFromWeekNumber { get; set; }
    public int CopyToWeekNumber { get; set; }

    public int CopyFromYear { get; set; }
    public int CopyToYear { get; set; }
}