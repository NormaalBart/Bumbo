namespace Bumbo.Models.BranchController;

public class BranchEditViewModel : BranchCreateViewModel
{
    public BranchEditViewModel()
    {
        SpecialOpeningHours = new List<OpeningHoursOverrideViewModel>();
    }

    public List<OpeningHoursOverrideViewModel> SpecialOpeningHours { get; set; }
}