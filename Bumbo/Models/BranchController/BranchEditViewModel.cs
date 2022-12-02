namespace Bumbo.Models.BranchController
{
    public class BranchEditViewModel : BranchCreateViewModel
    {

        public List<OpeningHoursOverrideViewModel> SpecialOpeningHours { get; set; }

        public BranchEditViewModel() : base()
        {
            SpecialOpeningHours = new List<OpeningHoursOverrideViewModel>();
        }
    }
}
