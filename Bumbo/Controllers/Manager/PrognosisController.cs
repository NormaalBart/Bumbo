using AutoMapper;
using Bumbo.Models.PrognosisManager;
using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Bumbo.Controllers
{
    [Authorize(Roles = "Manager")]
    public class PrognosisController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IPrognosisRepository _prognosisRepository;

        public PrognosisController(UserManager<Employee> userManager, IMapper mapper, IPrognosisRepository prognosisService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _prognosisRepository = prognosisService;
        }
        
        public IActionResult Index(string? dateInput, bool next)
        {
            // adds 7 because bool next is false by default.
            DateTime currentDate = DateTime.Now.AddDays(7);
            // start of week, calculated by getting the difference between the date and monday.
            // This method should probably be moved to a static class as it is used in multiple places.
            var startOfWeek = currentDate.GetMondayOfTheWeek();
            
            if (dateInput != null)
            {
                startOfWeek = DateTime.Parse(dateInput);
            }

            if (next)
            {
                startOfWeek = startOfWeek.AddDays(7);
            }
            if (!next)
            {
                startOfWeek = startOfWeek.AddDays(-7);
            }


            // Returns the week of prognose days.
            PrognosisListViewModel list = new PrognosisListViewModel();
            list.PrognosisList = _mapper.Map<IEnumerable<PrognosisViewModel>>(_prognosisRepository.GetNextWeek(startOfWeek.ToDateOnly())).ToList();

            return View(list);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexAsync(PrognosisListViewModel list)
        {
            
            if (!ModelState.IsValid)
            {
                return View(list);
            }
            List<Prognosis> result = _mapper.Map<List<Prognosis>>(list.PrognosisList);
            if (result.Count != 0)
            {
                Employee employee = await _userManager.GetUserAsync(User);
                _prognosisRepository.AddOrUpdateAllAsync(employee.DefaultBranch, result);
            }
            return View(list);
        }

        public async Task<IActionResult> ReUsePreviousWeekAsync(string lastWeekString)
        {
            // This method copies the prognosis week from the previous week and adds it to the database for the current week.

            DateOnly lastWeekDate = DateTime.Parse(lastWeekString).ToDateOnly();
            var lastweekPrognoses = _prognosisRepository.GetNextWeek(lastWeekDate).ToList();
            List<Prognosis> updatedNewWeek = new List<Prognosis>();
            foreach (var prognosis in lastweekPrognoses)
            {
                Prognosis newPrognosis = new Prognosis();
                newPrognosis.Date = prognosis.Date.AddDays(7);
                newPrognosis.Branch = prognosis.Branch;
                newPrognosis.CustomerCount = prognosis.CustomerCount;
                newPrognosis.ColiCount = prognosis.ColiCount;
                updatedNewWeek.Add(newPrognosis);
            }
            Employee employee = await _userManager.GetUserAsync(User);
            _prognosisRepository.AddOrUpdateAllAsync(employee.DefaultBranch, updatedNewWeek);

            return RedirectToAction("Index", "Prognosis", new { dateInput = lastWeekString, next = true }) ;
        }
    
    }
}
