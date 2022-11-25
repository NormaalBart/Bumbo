using AutoMapper;
using Bumbo.Models.UnavailableMoments;
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
            var viewModel = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(Databaseresult).ToList();
            var sortedViewModel = viewModel.OrderBy(e => e.StartTime).Where(e => e.EndTime >= DateTime.Now).ToList();
            UnavailableMomentsListViewModel unavailableMomentsListViewModel = new UnavailableMomentsListViewModel(sortedViewModel);
            foreach (UnavailableMomentsViewModel vm in unavailableMomentsListViewModel.UnavailableMoments)
            {
                if (vm.Type.CompareTo(UnavailableMomentType.OTHER.ToString()) == 0)
                {
                    vm.Type = "Anders";
                }
                else
                {
                    vm.Type = "School";
                }
            }
            return View(unavailableMomentsListViewModel);
        }

        public IActionResult Create()
        {
            UnavailableMomentsCreateViewModel unAvailableMoments = new UnavailableMomentsCreateViewModel();
            unAvailableMoments.StartTime = DateTime.Now;
            unAvailableMoments.EndTime = DateTime.Now.AddHours(5);
            unAvailableMoments.UnavailableMomentType = "OTHER";
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
                newUnavailableMoment.Type = (UnavailableMomentType)Enum.Parse(typeof(UnavailableMomentType), unavailableMomentViewModel.UnavailableMomentType);
                newUnavailableMoment.Employee = await _userManager.GetUserAsync(User);
                var errorMesssage = UnavailableMomentValid(newUnavailableMoment);
                if (errorMesssage != null)
                {
                    unavailableMomentViewModel.Error = errorMesssage;
                    return View(unavailableMomentViewModel);
                }
                _unavailableMomentsRepository.Create(newUnavailableMoment);
                return RedirectToAction("Index");
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
        private string? UnavailableMomentValid(UnavailableMoment unavailableMoment)
        {
            // TODO check if the time doesn't overlap with another unavailable moment
            if (unavailableMoment == null) { return "Er is iets fout gegaan, probeer het opnieuw."; }
            if (unavailableMoment.StartTime >= unavailableMoment.EndTime) { return "Start tijd kan niet na de eindtijd zijn."; }
            var lijstje = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User))
                .Where(e => e.StartTime < unavailableMoment.StartTime && e.EndTime > unavailableMoment.StartTime);
            if (lijstje.Count() > 0) { return "Je hebt deze tijd al eerder ingevuld."; }
            return null;
        }
    }
}
