namespace Bumbo.Models.BranchController;

public class BranchListViewModel
{
    public BranchListViewModel()
    {
        Branches = new List<ListIndexBranchViewModel>();
    }

    public BranchListViewModel(List<ListIndexBranchViewModel> branches, int page)
    {
        Branches = branches;
        Page = page;
    }

    public int Page { get; set; }
    public List<ListIndexBranchViewModel> Branches { get; set; }
}