using Bumbo.Models.AccountController;
using BumboData;
using BumboData.Models;
using BumboRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<Employee> _signInManager;
        private UserManager<Employee> _userManager;
        private IEmployeeRepository _employeeRepository;

        public AccountController(SignInManager<Employee> signInManager, UserManager<Employee> userManager, IEmployeeRepository employeeRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _employeeRepository = employeeRepository;
        }

        public async Task<IActionResult> Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                await _signInManager.SignOutAsync();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var user = _employeeRepository.GetByEmail(loginModel.EmailAddress);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                if (result.Succeeded)
                {
                    //User does not have roles yet assigned, so have to get from database.
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains("Administrator"))
                    {
                        return Redirect("Branch/Index");
                    }
                    else if (roles.Contains("Manager"))
                    {
                        return Redirect("EmployeeManager/Index");
                    }
                    else if (roles.Contains("Medewerker"))
                    {
                        return Redirect("Employee/Index");
                    }
                }
            }

            ModelState.AddModelError(string.Empty, "Onbekend account");
            return View(loginModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
