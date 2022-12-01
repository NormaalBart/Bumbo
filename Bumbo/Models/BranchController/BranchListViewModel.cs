namespace Bumbo.Models.BranchController
{
    public class BranchListViewModel
    {
        public int Page { get; set; }
        public List<BranchViewModel> Branches { get; set; }

        public BranchListViewModel() { Branches = new List<BranchViewModel>(); }
        public BranchListViewModel(List<BranchViewModel> branches, int page)
        {
            Branches = branches;
            Page = page;
        }
    }
}
