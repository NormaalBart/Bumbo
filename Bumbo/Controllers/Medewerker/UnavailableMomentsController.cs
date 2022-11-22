using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Medewerker
{
    [Authorize(Roles = "Employee")]
    public class UnavailableMomentsController : Controller
    {
        private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
        private IMapper _mapper;
        private UserManager<Employee> _userManager;

        public UnavailableMomentsController(UserManager<Employee> userManager, IUnavailableMomentsRepository unavailableMomentListRepository, IMapper mapper)
        {
            _userManager = userManager;
            _unavailableMomentsRepository = unavailableMomentListRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<UnavailableMoment> unavailableMoments = new List<UnavailableMoment>();
            var Databaseresult = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User));
            UnavailableMomentsListViewModel unavailableMomentsListViewModel = new UnavailableMomentsListViewModel(_mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(Databaseresult).ToList());
            unavailableMomentsListViewModel.Date = DateTime.Now;
            return View(unavailableMomentsListViewModel);
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
        public async Task<IActionResult> Create(UnavailableMomentsCreateViewModel unavailableMomentViewModel)
        {
            ModelState.Clear();
            TryValidateModel(unavailableMomentViewModel);
            if (ModelState.IsValid)
            {
                var newUnavailableMoment = _mapper.Map<UnavailableMomentsCreateViewModel, UnavailableMoment>(unavailableMomentViewModel);
                newUnavailableMoment.Employee = await _userManager.GetUserAsync(User);
                if (newUnavailableMoment != null && UnavailableMomentValid(newUnavailableMoment))
                {
                    _unavailableMomentsRepository.Create(newUnavailableMoment);
                    return RedirectToAction("Index");
                }
            }

            return View(unavailableMomentViewModel);
        }

        public IActionResult Delete(int id)
        {
            var unavailableMoment = _unavailableMomentsRepository.Get(id);
            if (unavailableMoment == null) { return RedirectToAction("Index"); }
            var unavailableMomentViewModel = _mapper.Map<UnavailableMoment, UnavailableMomentsViewModel>(unavailableMoment);
            return View(unavailableMomentViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(UnavailableMomentsViewModel unavailableMomentViewModel)
        {
            var unavailableMoment = _mapper.Map<UnavailableMoment>(unavailableMomentViewModel);
            _unavailableMomentsRepository.Delete(unavailableMoment);
            return RedirectToAction("Index");
        }
        private bool UnavailableMomentValid(UnavailableMoment unavailableMoment)
        {
            return true;
            // TODO check if the time doesn't overlap with another unavailable moment
            if (unavailableMoment == null) { return false; }
            if (unavailableMoment.StartTime.CompareTo(unavailableMoment.EndTime) < 1) { return false; }
            //if (unavailableMoment.Employee == null) { return false; }
            return true;
        }
    }
}
