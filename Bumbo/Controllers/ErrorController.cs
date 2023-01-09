using System.Diagnostics;
using Bumbo.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers;

public class ErrorController : Controller
{
    public IActionResult Index()
    {
        var errorvm = new ErrorViewModel();
        // get error code 
        var statusCode = HttpContext.Response.StatusCode;
        errorvm.ErrorCode = statusCode;
        // get error message
        var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
        if (exceptionHandlerPathFeature?.Error is not null)
            errorvm.ErrorMessage = exceptionHandlerPathFeature.Error.Message;
        errorvm.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        return View(errorvm);
    }

    public IActionResult PageNotFound()
    {
        return View();
    }
}