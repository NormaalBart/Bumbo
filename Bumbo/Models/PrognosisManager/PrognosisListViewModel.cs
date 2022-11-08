namespace Bumbo.Models.PrognosisManager
{
    public class PrognosisListViewModel
    {
        public List<PrognosisViewModel> PrognosisList { get; set; }

        public PrognosisListViewModel()
        {
            PrognosisList = new List<PrognosisViewModel>();
        }
    }
}
