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
        private IEmployee _employeeRepository;

        public AccountController(SignInManager<Employee> signInManager, IEmployee employeeRepository)
        {
            _signInManager = signInManager;
            _employeeRepository = employeeRepository;
        }

        public IActionResult Login()
        {
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

            if(user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Onbekend account");
            return View(loginModel);
        }
    }
}
