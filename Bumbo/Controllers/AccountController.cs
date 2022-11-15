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
        private IEmployeeRepository _employeeRepository;

        public AccountController(SignInManager<Employee> signInManager, IEmployeeRepository employeeRepository)
        {
            _signInManager = signInManager;
            _employeeRepository = employeeRepository;
        }

        public async Task<IActionResult> Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                //TODO this doesnt work!?
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
                    if (User.IsInRole("Administrator"))
                    {
                        return Redirect("AdminHome/Index");
                    }
                    else if (User.IsInRole("Manager"))
                    {
                        return Redirect("EmployeeManager/Index");
                    }
                    else if (User.IsInRole("Medewerker"))
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
