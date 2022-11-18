﻿using AutoMapper;
using Bumbo.Models.PrognosisManager;
using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CopyFromWeek(int copyFromWeekNumber, int copyToWeekNumber, int copyFromYear, int copyToYear)
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
            
            _prognosisRepository.AddOrUpdateAll(updatedNewWeek);

            return RedirectToAction("Index", "Prognosis", new { dateInput = copyToDate.AddDays(-7).ToString(), next = true });
        }
            
        
    
    }
}
