using System.Collections;
using System.Globalization;
using Bumbo.Models.ExportManager;
using Bumbo.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Bumbo.Controllers;

public class ExportController: Controller
{
    public IActionResult Overview(String? SelectedMonth, String? SearchQuery, String? SearchDepartmentsQuery)
    {
        var model = new ExportOverviewViewModel();

        var selectableMonths = new List<DateTime>();
        
        // Temp
        foreach (var i in Enumerable.Range(0, 12))
        {
            selectableMonths.Add(DateTime.Now.Subtract(TimeSpan.FromDays(i * 30)));
        }

        model.SelectableMonths = selectableMonths;
        model.SelectedMonth = SelectedMonth == null ? DateTime.Now : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);
        
        
        return View(model);
    }
}