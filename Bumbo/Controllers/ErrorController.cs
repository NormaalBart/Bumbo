using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bumbo.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
