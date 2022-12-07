using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.Validations
{
    public class CustomPasswordValidation : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string password = value.ToString();

            if (password.Count() < 6)
            {
                return new ValidationResult("Wachtwoord moet minimaal 6 tekens hebben");
            }

            else if (!password.Any(ch => char.IsUpper(ch)))
            {
                return new ValidationResult("Wachtwoord moet minimaal 1 hoofdletter hebben");
            }

            else if (!password.Any(ch => char.IsDigit(ch)))
            {
                return new ValidationResult("Wachtwoord moet minimaal 1 nummer hebben");
            }
            return ValidationResult.Success;
        }

    }
}
