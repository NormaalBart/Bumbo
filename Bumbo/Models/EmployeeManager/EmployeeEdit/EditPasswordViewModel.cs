using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.EmployeeManager.EmployeeEdit
{
    public class EditPasswordViewModel
    {

        public string EmployeeKey { get; set; }

        public string? FullName { get; set; }

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
