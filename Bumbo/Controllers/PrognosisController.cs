using AutoMapper;
using Bumbo.Models.PrognosisManager;
using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Bumbo.Controllers
{
    public class PrognosisController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPrognosis _prognosisRepository;

        public PrognosisController(IMapper mapper, IPrognosis prognosisService)
        {
            _mapper = mapper;
            _prognosisRepository = prognosisService;
        }
        
        public IActionResult Index(string? dateInput, string? direction)
        {
            DateTime currentDate = DateTime.Now;
            // start of week, calculated by getting the difference between the date and monday.
            // This method should probably be moved to a static class as it is used in multiple places.
            int diff = DayOfWeek.Monday - currentDate.DayOfWeek;
            if (diff > 0)
                diff -= 7;
            var startOfWeek = currentDate.AddDays(diff);
            
            if (dateInput != null)
            {
                startOfWeek = DateTime.Parse(dateInput);
            }
            if(direction != null)
            {
                if (direction.Equals("next"))
                {
                    startOfWeek = startOfWeek.AddDays(7);
                }
                if (direction.Equals("previous"))
                {
                    startOfWeek = startOfWeek.AddDays(-7);
                }
            }

            // Returns the week of prognose days.
            PrognosisListViewModel list = new PrognosisListViewModel();
            var prognosisDb = _prognosisRepository.GetNextWeek(startOfWeek.ToDateOnly());
            list.PrognosisList = _mapper.Map<IEnumerable<PrognosisViewModel>>(prognosisDb).ToList();


            return View(list);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PrognosisListViewModel list)
        {
            
            if (!ModelState.IsValid)
            {
                return View(list);
            }
            List<Prognosis> result = _mapper.Map<List<Prognosis>>(list.PrognosisList);
            if (result.Count != 0)
            {
                _prognosisRepository.AddOrUpdateAll(result);
            }
            return View(list);
        }
    
    }
}
