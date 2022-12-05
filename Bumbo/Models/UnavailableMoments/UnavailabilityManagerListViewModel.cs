namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailabilityManagerListViewModel
    {
        public List<UnavailableMomentsViewModel> UnavailableMoments { get; set; }

        public DateTime Date { get; set; }
        
        public string SearchString { get; set; }

        public List<int> Ids { get; set; }

        public UnavailabilityManagerListViewModel()
        {
            UnavailableMoments = new List<UnavailableMomentsViewModel>();
        }
        
        
    }
}
