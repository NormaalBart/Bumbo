using Bumbo.Models.AccountController;
using BumboData;
using BumboData.Enums;
using BumboData.Models;
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
                Employee employee = await _userManager.GetUserAsync(User);
                return await RedirectToPageAsync(employee);
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

            var employee = _employeeRepository.GetByEmail(loginModel.EmailAddress);

            if (employee != null)
            {
                var result = await _signInManager.PasswordSignInAsync(employee, loginModel.Password, false, false);
                if (result.Succeeded)
                {
                    return await RedirectToPageAsync(employee);
                }
            }

            ModelState.AddModelError(string.Empty, "Onbekend account");
            return View(loginModel);
        }

        private async Task<IActionResult> RedirectToPageAsync(Employee employee)
        {
            //User does not have roles yet assigned, so have to get from database.
            var roles = await _userManager.GetRolesAsync(employee);
            if (roles.Contains(RoleType.ADMINISTRATOR.Name))
            {
                return RedirectToAction("Index", "Branch");
            }
            else if (roles.Contains(RoleType.MANAGER.Name))
            {
                return RedirectToAction("Index", "EmployeeManager");
            }
            else if (roles.Contains(RoleType.EMPLOYEE.Name))
            {
                return RedirectToAction("Index", "Employee");
            }
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
