using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bumbo.Models.EmployeeManager.Common;
using Bumbo.Models.EmployeeManager.Index;
using BumboData.Models;

namespace Bumbo.Models.EmployeeManager.Employee
{

    public class EmployeeEditViewModel : BaseCreateViewModel
    {

        [DisplayName("Functie")]
        public string? Function { get; set; }

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
