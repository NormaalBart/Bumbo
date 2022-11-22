using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bumbo.Models.EmployeeManager.EmployeeCreate;
using BumboData.Models;

namespace Bumbo.Models.EmployeeManager
{

    public class EmployeeCreateViewModel : BaseCreateViewModel
    {

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Functie")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public String Function { get; set; }

        [DisplayName("Kies een of meerdere afdelingen voor deze medewerker.")]
        public virtual ICollection<Department> AllowedDepartments { get; set; }

        public List<EmployeeDepartmentViewModel> EmployeeSelectedDepartments { get; set; }

        public EmployeeCreateViewModel() : base()
        {
            AllowedDepartments = new List<Department>();
            EmployeeSelectedDepartments = new List<EmployeeDepartmentViewModel>();
        }

    }
}
