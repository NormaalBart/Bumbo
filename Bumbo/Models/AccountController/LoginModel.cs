using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.AccountController
{
    public class LoginModel
    {

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }    

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }    
    }
}
