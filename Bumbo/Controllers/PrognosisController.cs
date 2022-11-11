using AutoMapper;
using Bumbo.Models.PrognosisManager;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;

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
        
        public IActionResult Index()
        {
            var prognosis = _prognosisRepository.GetAll();
            PrognosisListViewModel list = new PrognosisListViewModel();
            list.PrognosisList = _mapper.Map<IEnumerable<PrognosisViewModel>>(prognosis).ToList();

            return View(list);

        }

        public IActionResult Create()
        {
            PrognosisViewModel prognosis = new PrognosisViewModel();
            prognosis.AmountOfCustomers = 1000;
            prognosis.AmountOfCollies = 100;


            prognosis.Date = _prognosisRepository.GetNextEmptyPrognosisDate();
            return View(prognosis);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PrognosisViewModel prognosis)
        {

            if (!ModelState.IsValid)
            {
                return View(prognosis);
            }
            var prognosisDay = _mapper.Map<Prognosis>(prognosis);
            _prognosisRepository.Add(prognosisDay);
            return RedirectToAction("Index");
        }
    }
}
