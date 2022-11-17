using AutoMapper;
using Bumbo.Models.RosterManager;
using BumboData.Models;
using BumboRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class UnavailableMomentsController : Controller
    {
        private readonly UnavailableMomentCreateRepository _createRepository;
        private IMapper _mapper;
        public UnavailableMomentsController(UnavailableMomentCreateRepository unavailableMomentRepository, IMapper mapper)
        {
            _createRepository = unavailableMomentRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            UnavailableMomentsRosterViewModel resultingListViewModel = new UnavailableMomentsRosterViewModel();
            return RedirectToAction("Create");
            return View(resultingListViewModel);
        }

        public IActionResult Create()
        {
            UnavailableMomentsCreateViewModel unAvailableMoments = new UnavailableMomentsCreateViewModel();
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
                _createRepository.Add(newUnavailableMoment);
                return RedirectToAction("Index");
            }

            return View(unavailableMomentViewModel);
        }
    }
}
