using System.Collections;
using System.Globalization;
using Bumbo.Models.ExportManager;
using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using BumboRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Bumbo.Controllers;

public class ExportController: Controller
{

    private readonly IEmployee _employeeRepository;
    private readonly IBranchRepository _branchRepository;
    private readonly IWorkedShiftRepository _workedShiftRepository;
    
    public ExportController(IEmployee employeeRepository, 
        IBranchRepository branchRepository, 
        IWorkedShiftRepository workedShiftRepository)
    {
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
        _workedShiftRepository = workedShiftRepository;
    }
    
    public IActionResult Overview(String? SelectedMonth, String? SearchQuery)
    {
        var monthSelected = SelectedMonth == null ? DateTime.Now : DateTime.ParseExact(SelectedMonth, "yyyy-MM", CultureInfo.CurrentCulture);
            
        var model = new ExportOverviewViewModel();

        var selectableMonths = new List<DateTime>();
        
        // Temp
        foreach (var i in Enumerable.Range(0, 24))
        {
            selectableMonths.Add(DateTime.Now.Subtract(TimeSpan.FromDays(i * 30)));
        }

        model.SelectableMonths = selectableMonths;
        model.SelectedMonth = monthSelected;
        model.SearchQuery = SearchQuery;

        var workedShiftsInMonth = _workedShiftRepository.GetWorkedShiftsInMonth(monthSelected.Year, monthSelected.Month);

        if (SearchQuery != null && SearchQuery.Trim().Length != 0)
        {
            workedShiftsInMonth = workedShiftsInMonth.Where(s =>
                s.Employee.FullName().Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        var prevMonth = new DateTime(monthSelected.Ticks).AddMonths(-1);
        
        // Get all employees that have worked in this month, and get all worked shifts for each employee.
        model.ExportOverviewListItemViewModels = workedShiftsInMonth.GroupBy(i => i.Employee)
            .Select(e => ExportOverviewListItemViewModel.FromWorkedShifts(e.Key,e.ToList(),
                _workedShiftRepository.GetWorkedShiftsInMonth(prevMonth.Year, prevMonth.Month))).ToList();

        return View(model);
    }

    // For debug only
    public IActionResult Seed()
    {
        // Add branch
        _branchRepository.Add(new Branch()
        {
            City = "Nijmegen",
            Street = "test",
            HouseNumber = "12a",
            ShelvingDistance = 123
        });
        
        var branch = _branchRepository.GetAll().First();
        
        // Add employees
        foreach (var i in Enumerable.Range(0, 50))
        {
            var employee = new Employee()
            {
                FirstName = "Test" + i,
                LastName = "Account",
                Birthdate = DateTime.Now.AddYears(-20).ToDateOnly(),
                Active = true,
                Postalcode = "0611AC",
                Housenumber = "11a",
                EmployeeSince = DateTime.Now.ToDateOnly(),
                Function = "onbekend",
                DefaultBranch = branch
            };
            _employeeRepository.Add(employee);
        }

        var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        
        var random = new Random();

        var cur = DateTime.Now;

        // Add worked shifts
        foreach (var employee in _employeeRepository.GetAll().ToList())
        {
            // Add shift for each day of month
            foreach (var day in Enumerable.Range(firstDayOfMonth.Day, DateTime.Today.Day))
            {
                var startTime = new DateTime(cur.Year, cur.Month, day, random.Next(20), random.Next(59), 0);

                var endTime = DateTime.MinValue;
                while (startTime > endTime)
                {
                    endTime = new DateTime(cur.Year, cur.Month, day, random.Next(23), random.Next(59), 0);
                }

                var workedShift = new WorkedShift()
                {
                    Approved = true,
                    Branch = branch,
                    Employee = employee,
                    Sick = random.Next(100) <= 5,
                    StartTime = startTime,
                    EndTime = endTime
                };
                _workedShiftRepository.Add(workedShift);
            }
        }

        return Ok();
    }
}