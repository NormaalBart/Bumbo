using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Employees
{
    [Authorize(Roles = "Employee")]
    public class UnavailableMomentsController : Controller
    {
        private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
        private IMapper _mapper;
        private UserManager<Employee> _userManager;

        public UnavailableMomentsController(UserManager<Employee> userManager,
            IUnavailableMomentsRepository unavailableMomentListRepository, IMapper mapper)
        {
            _userManager = userManager;
            _unavailableMomentsRepository = unavailableMomentListRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<UnavailableMoment> unavailableMoments = new List<UnavailableMoment>();
            var Databaseresult = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User));
            var viewModel = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(Databaseresult).ToList();
            var sortedViewModel = viewModel.OrderBy(e => e.StartTime).Where(e => e.EndTime >= DateTime.Now).ToList();
            UnavailableMomentsListViewModel unavailableMomentsListViewModel =
                new UnavailableMomentsListViewModel(sortedViewModel);
            return View(unavailableMomentsListViewModel);
        }

        public IActionResult Create()
        {
            UnavailableMomentsViewModel unAvailableMoments = new UnavailableMomentsViewModel();
            unAvailableMoments.StartTime = DateTime.Now;
            unAvailableMoments.EndTime = DateTime.Now.AddHours(5);
            unAvailableMoments.Type = UnavailableMomentType.Other;
            return View(unAvailableMoments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UnavailableMomentsViewModel unavailableMomentViewModel)
        {
            var newUnavailableMoment =
                _mapper.Map<UnavailableMomentsViewModel, UnavailableMoment>(unavailableMomentViewModel);
            newUnavailableMoment.Type = unavailableMomentViewModel.Type;
            newUnavailableMoment.Employee = await _userManager.GetUserAsync(User);
            var errorMesssage = UnavailableMomentValid(newUnavailableMoment);
            if (errorMesssage != null)
            {
                ModelState.AddModelError("Invalid Moment", errorMesssage);
                return View(unavailableMomentViewModel);
            }

            _unavailableMomentsRepository.Create(newUnavailableMoment);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var unavailableMoment = _unavailableMomentsRepository.Get(id);
            if (unavailableMoment == null)
            {
                return RedirectToAction("Index");
            }

            var unavailableMomentViewModel =
                _mapper.Map<UnavailableMoment, UnavailableMomentsViewModel>(unavailableMoment);
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

        private string? UnavailableMomentValid(UnavailableMoment unavailableMoment)
        {
            if (unavailableMoment == null)
            {
                return "Er is iets fout gegaan, probeer het opnieuw.";
            }

            if (unavailableMoment.StartTime < DateTime.Now || unavailableMoment.EndTime < DateTime.Now)
            {
                return "Kan geen afwezigheid plannen in het verleden.";
            }

            if (unavailableMoment.StartTime >= unavailableMoment.EndTime)
            {
                return "Start tijd kan niet na de eindtijd zijn.";
            }

            var overlappingMoments = _unavailableMomentsRepository.GetOverlappingMoments(unavailableMoment);
            if (overlappingMoments.Count() > 0)
            {
                return "Je hebt deze tijd al eerder ingevuld.";
            }

            return null;
        }

        public async Task<IActionResult> CopyFromDay(UnavailableMomentsListViewModel unavailableMomentViewModel)
        {
            List<UnavailableMoment> newMoments = new List<UnavailableMoment>();
            var oldMoments = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User))
                .Where(e => e.StartTime.Date == unavailableMomentViewModel.CopyFrom.Date).ToList();
            var diff = unavailableMomentViewModel.CopyTo - unavailableMomentViewModel.CopyFrom;
            var currentEmployee = await _userManager.GetUserAsync(User);
            foreach (var moment in oldMoments)
            {
                var newMoment = new UnavailableMoment();
                DateTime? newStartTime = moment.StartTime + diff;
                if (newStartTime != null) newMoment.StartTime = (DateTime)newStartTime;
                DateTime? newEndTime = moment.EndTime + diff;
                if (newEndTime != null) newMoment.EndTime = (DateTime)newEndTime;
                newMoment.Employee = currentEmployee;
                newMoment.Type = moment.Type;
                newMoments.Add(newMoment);
            }

            newMoments.ForEach(e =>
            {
                if (UnavailableMomentValid(e) == null) _unavailableMomentsRepository.Create(e);
            });

            return RedirectToAction("Index");
        }
    }
}