namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailableMomentsListViewModel
    {
        public List<UnavailableMomentsViewModel> UnavailableMoments;
        public UnavailableMomentsListViewModel(List<UnavailableMomentsViewModel> unavailableMoments)
        {
            UnavailableMoments = unavailableMoments;
        }

    }
}
