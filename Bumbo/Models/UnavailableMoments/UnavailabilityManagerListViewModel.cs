namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailabilityManagerListViewModel
    {
        public List<UnavailableMomentsViewModel> UnavailableMoments { get; set; }

        public bool IncludeApproved { get; set; }
        public bool IncludePending { get; set; }
        public bool IncludeRejected { get; set; }

        public UnavailabilityManagerListViewModel()
        {
            UnavailableMoments = new List<UnavailableMomentsViewModel>();
        }
        
        
    }
}
