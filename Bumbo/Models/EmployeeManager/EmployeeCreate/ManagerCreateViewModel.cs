using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.EmployeeCreate
{
    public class ManagerCreateViewModel : BaseCreateViewModel
    {

        [Required]
        [DisplayName("Van welke branch is deze persoon de manager?")]
        public int? SelectedBranch { get; set; }

        public List<Branch> Branches { get; set; }


        public ManagerCreateViewModel() : base()
        {
            Branches = new List<Branch>();
        }
    }
}
