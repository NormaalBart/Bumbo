using Bumbo.Models.AccountController;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

public class AccountController : Controller
{
    private readonly IBranchRepository _branchRepository;
    private readonly IEmployeeRepository _employeeRepository;

    private readonly SignInManager<Employee> _signInManager;
    private readonly UserManager<Employee> _userManager;

    public AccountController(SignInManager<Employee> signInManager, UserManager<Employee> userManager,
        IEmployeeRepository employeeRepository, IBranchRepository branchRepository)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
    }

    public async Task<IActionResult> Login()
    {
        if (User != null && _signInManager.IsSignedIn(User))
        {
            var employee = await _userManager.GetUserAsync(User);
            if (employee != null) return await RedirectToPageAsync(employee);
        }

        if (TempData["InactiveBranch"] is not null)
        {
            ModelState.AddModelError("InactiveBranch", (string) TempData["InactiveBranch"]);
            TempData["InactiveBranch"] = null;
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        if (!ModelState.IsValid) return View(loginModel);

        var employee = _employeeRepository.GetByEmail(loginModel.EmailAddress);
        if (employee != null)
        {
            var result = await _signInManager.PasswordSignInAsync(employee, loginModel.Password, false, false);
            if (result.Succeeded) return await RedirectToPageAsync(employee);
            // Return invalid password
            ModelState.AddModelError("Password", "Verkeerde email en wachtwoord combinatie, probeer opnieuw.");
            return View(loginModel);
        }

        ModelState.AddModelError("EmailAddress", "Account is niet gevonden");
        return View(loginModel);
    }

    private async Task<IActionResult> RedirectToPageAsync(Employee employee)
    {
        var branch = employee.DefaultBranch == null
            ? _branchRepository.Get(employee.DefaultBranchId ?? -1)
            : employee.DefaultBranch;
        //User does not have roles yet assigned, so have to get from database.
        var roles = await _userManager.GetRolesAsync(employee);

        if (!roles.Contains(RoleType.ADMINISTRATOR.Name) && (branch == null || branch.Inactive))
        {
            await _signInManager.SignOutAsync();
            TempData["InactiveBranch"] = "Deze branch is inactief";
            return RedirectToAction(nameof(Login));
        }

        if (roles.Contains(RoleType.ADMINISTRATOR.Name))
            return RedirectToAction("Index", "Branch");
        if (roles.Contains(RoleType.MANAGER.Name))
            return RedirectToAction("Index", "RosterManager",
                new {dateInput = DateTime.Today.ToString(), errormessage = string.Empty});
        if (roles.Contains(RoleType.EMPLOYEE.Name)) return RedirectToAction("Index", "EmployeeRoster");
        return BadRequest();
    }

    public IActionResult AccessDenied()
    {
        return View("~/Views/Error/AccessDenied.cshtml");
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }
}