using System.ComponentModel.DataAnnotations;
using Bumbo.Models.Validations;

namespace Bumbo.Models.EmployeeManager.Common;

public class EditPasswordViewModel
{
    public string EmployeeKey { get; set; }

    public string? FullName { get; set; }

    [Required(ErrorMessage = "Dit veld is verplicht")]
    [DataType(DataType.Password)]
    [CustomPasswordValidation]
    [Display(Name = "Wachtwoord")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Bevestig wachtwoord")]
    [Required(ErrorMessage = "Dit veld is verplicht")]
    [CustomPasswordValidation]
    [Compare("Password", ErrorMessage = "De wachtwoorden zijn niet gelijk.")]
    public string ConfirmPassword { get; set; }
}