using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class IncomingData
    {
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class ClockInController : Controller
    {
        private readonly MyContext _context;

        public ClockInController(MyContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index([FromForm] IncomingData msgBody)
        {
            Employee employee = _context.Employees.Find(msgBody.EmployeeId);
            Branch branch = _context.Branches.Find(msgBody.BranchId);
            if (employee == null || branch == null)
            {
                return Redirect("ClockIn/Error");
            }
            
            WorkedShift lastWorkedShift = _context.WorkedShift.Where(o => o.Employee == employee && o.EndTime == null)
                       .OrderByDescending(o => o.StartTime)
                       .FirstOrDefault();

            if (lastWorkedShift != null)
            {
                lastWorkedShift.EndTime = DateTime.Now;
                _context.SaveChanges();
                return View(lastWorkedShift);
            }
            else
            {
                WorkedShift newWorkedShift = new WorkedShift();
                newWorkedShift.Employee = employee;
                newWorkedShift.Branch = branch;
                newWorkedShift.StartTime = DateTime.Now;
                newWorkedShift.Sick = false;
                newWorkedShift.Approved = false;
                _context.WorkedShift.Add(newWorkedShift);
                _context.SaveChanges();
                return View(newWorkedShift);
            }
        }

        public IActionResult Error()
        {

            return View();
        }
    }
}
