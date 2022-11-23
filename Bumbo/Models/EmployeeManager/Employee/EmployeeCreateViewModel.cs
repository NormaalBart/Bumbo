using Bumbo.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.Employee
{
    public class EmployeeCreateViewModel : EmployeeEditViewModel
    {

        [Required]
        [DataType(DataType.Password)]
        [CustomPasswordValidation]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bevestig wachtwoord")]
        [CustomPasswordValidation]
        [Compare("Password", ErrorMessage = "De wachtwoorden zijn niet gelijk.")]
        public string ConfirmPassword { get; set; }

    }
}
