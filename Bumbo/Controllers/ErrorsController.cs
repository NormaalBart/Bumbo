using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bumbo.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult Index()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult NotFound([FromServices] IHostEnvironment hostEnvironment)
        {
            ErrorViewModel error = new ErrorViewModel();
            error.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }
            return View(error);
        }
    }
}
