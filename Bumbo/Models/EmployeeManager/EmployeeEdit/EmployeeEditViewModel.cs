using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bumbo.Models.EmployeeManager.EmployeeCreate;
using BumboData.Models;

namespace Bumbo.Models.EmployeeManager
{

    public class EmployeeEditViewModel : BaseEditViewModel
    {

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Functie")]
        [StringLength(50, ErrorMessage = "Veld heeft te veel characters.")]
        public String Function { get; set; }

        public virtual ICollection<Department> AllowedDepartments { get; set; }

        [DisplayName("Kies een of meerdere afdelingen voor deze medewerker.")]
        public List<EmployeeDepartmentViewModel> EmployeeSelectedDepartments { get; set; }

        public EmployeeEditViewModel() : base()
        {
            AllowedDepartments = new List<Department>();
            EmployeeSelectedDepartments = new List<EmployeeDepartmentViewModel>();
        }

    }
}
