using AutoMapper;
using Bumbo.Models.PrognosisManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            list.CopyToWeekNumber = startOfWeek.GetWeekNumber();
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
                _prognosisRepository.AddOrUpdateAll(employee.DefaultBranchId, result);
            }
            return View(list);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CopyFromWeekAsync(int copyFromWeekNumber, int copyToWeekNumber, int copyFromYear, int copyToYear)
        {
            // This method copies the prognosis week from a certain week and adds it to another one.
            DateTime copyFromDate = OtherUtils.FirstDateOfWeekISO8601(copyFromYear, copyFromWeekNumber);
            DateTime copyToDate = OtherUtils.FirstDateOfWeekISO8601(copyToYear, copyToWeekNumber);


            var copyFromPrognoses = _prognosisRepository.GetNextWeek(copyFromDate.ToDateOnly()).ToList();
            List<Prognosis> updatedNewWeek = new List<Prognosis>();
            for (int i = 0; i < copyFromPrognoses.Count(); i++)
            {
                Prognosis newPrognosis = new Prognosis();
                newPrognosis.Date = copyToDate.ToDateOnly().AddDays(i);
                newPrognosis.Branch = copyFromPrognoses[i].Branch;
                newPrognosis.CustomerCount = copyFromPrognoses[i].CustomerCount;
                newPrognosis.ColiCount = copyFromPrognoses[i].ColiCount;
                updatedNewWeek.Add(newPrognosis);
            }

            Employee employee = await _userManager.GetUserAsync(User);
            _prognosisRepository.AddOrUpdateAll(employee.DefaultBranchId, updatedNewWeek);

            return RedirectToAction("Index", "Prognosis", new { dateInput = copyToDate.AddDays(-7).ToString(), next = true });
        }
            
        
    
    }
}
