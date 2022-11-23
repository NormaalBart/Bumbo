using Bumbo.Models.EmployeeManager.Common;
using BumboData.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.Manager
{
    public class ManagerEditViewModel : BaseCreateViewModel
    {

        [Required]
        [DisplayName("Van welke branch is deze persoon de manager?")]
        public int SelectedBranch { get; set; }

        public List<Branch> Branches { get; set; }


        public ManagerEditViewModel() : base()
        {
            Branches = new List<Branch>();
        }
    }
}
