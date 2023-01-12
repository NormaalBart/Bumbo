using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bumbo.Models.EmployeeManager.Common;
using BumboData.Models;

namespace Bumbo.Models.EmployeeManager.Manager;

public class ManagerEditViewModel : BaseCreateViewModel
{
    public ManagerEditViewModel()
    {
        Branches = new List<Branch>();
    }

    [Required]
    [DisplayName("Van welke filiaal is deze persoon de manager?")]
    public int SelectedBranch { get; set; }

    public List<Branch> Branches { get; set; }
}