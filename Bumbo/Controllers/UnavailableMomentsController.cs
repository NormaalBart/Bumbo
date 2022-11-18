using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class UnavailableMomentsController : Controller
    {
        private readonly IUnavailableMomentsCreate _createRepository;
        private IMapper _mapper;

        public UnavailableMomentsController(IUnavailableMomentsCreate unavailableMomentRepository, IMapper mapper)
        {
            _createRepository = unavailableMomentRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //UnavailableMomentsRosterViewModel resultingListViewModel = new UnavailableMomentsRosterViewModel();
            return RedirectToAction("Create");
            //return View(resultingListViewModel);
        }

        public IActionResult Create()
        {
            UnavailableMomentsCreateViewModel unAvailableMoments = new UnavailableMomentsCreateViewModel();
            unAvailableMoments.StartTime = DateTime.Now;
            unAvailableMoments.EndTime = DateTime.Now.AddHours(5);
            return View(unAvailableMoments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UnavailableMomentsCreateViewModel unavailableMomentViewModel)
        {
            ModelState.Clear();
            TryValidateModel(unavailableMomentViewModel);
            if (ModelState.IsValid)
            {
                var newUnavailableMoment = _mapper.Map<UnavailableMomentsCreateViewModel, UnavailableMoment>(unavailableMomentViewModel);
                _createRepository.AddEmployeeToUnavailableMoment(newUnavailableMoment);
                if (newUnavailableMoment != null && UnavailableMomentValid(newUnavailableMoment))
                {
                    _createRepository.Add(newUnavailableMoment);
                    return RedirectToAction("Index");
                }
            }

            return View(unavailableMomentViewModel);
        }

        private bool UnavailableMomentValid(UnavailableMoment unavailableMoment)
        {
            // TODO check if the time doesn't overlap with another unavailable moment
            if (unavailableMoment == null) { return false; }
            if (unavailableMoment.StartTime.CompareTo(unavailableMoment.EndTime) < 1) { return false; }
            if (unavailableMoment.Employee == null) { return false; }
            return true;
        }
    }
}
