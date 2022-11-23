using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.AccountController
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Er moet een email worden opgegeven.")]
        [EmailAddress]
        [DisplayName("Email")]
        public string EmailAddress { get; set; }    

        [Required(ErrorMessage = "Er moet een wachtwoord worden opgegeven.")]
        [DataType(DataType.Password)]
        [DisplayName("Wachtwoord")]
        public string Password { get; set; }    
    }
}
