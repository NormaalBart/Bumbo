
using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
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
        private readonly IBranchRepository _branchRepository;

        public UnavailableMomentsController(UserManager<Employee> userManager,
            IUnavailableMomentsRepository unavailableMomentListRepository, IMapper mapper, IBranchRepository branchRepository)
        {
            _userManager = userManager;
            _unavailableMomentsRepository = unavailableMomentListRepository;
            _mapper = mapper;
            _branchRepository = branchRepository;
        }

        public async Task<IActionResult> Index()
        {
            List<UnavailableMoment> unavailableMoments = new List<UnavailableMoment>();
            var Databaseresult = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User));
            var viewModel = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(Databaseresult).ToList();
            var sortedViewModel = viewModel.OrderBy(e => e.StartTime).Where(e => e.EndTime >= DateTime.Now).ToList();
            UnavailableMomentsListViewModel unavailableMomentsListViewModel = new UnavailableMomentsListViewModel(sortedViewModel);
            return View(unavailableMomentsListViewModel);
        }

        public IActionResult Create()
        {
            UnavailableMomentCreateViewModel unAvailableMoments = new UnavailableMomentCreateViewModel();
            unAvailableMoments.StartDate = DateTime.Now.AddDays(1);
            unAvailableMoments.EndDate = DateTime.Now.AddDays(1);
            unAvailableMoments.StartHour = "08:00";
            unAvailableMoments.EndHour = "16:00";
            unAvailableMoments.Type = UnavailableMomentType.Other;
            return View(unAvailableMoments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UnavailableMomentCreateViewModel unavailableMomentViewModel)
        {
            UnavailableMoment newUnavailableMoment = new UnavailableMoment();
            newUnavailableMoment.StartTime = unavailableMomentViewModel.StartDate.Add(TimeOnly.Parse(unavailableMomentViewModel.StartHour).ToTimeSpan());
            newUnavailableMoment.EndTime = unavailableMomentViewModel.EndDate.Add(TimeOnly.Parse(unavailableMomentViewModel.EndHour).ToTimeSpan());
           
            newUnavailableMoment.Type = unavailableMomentViewModel.Type;
            newUnavailableMoment.Employee = await _userManager.GetUserAsync(User);

            var errorMesssage = UnavailableMomentValid(newUnavailableMoment);
            if (errorMesssage != null)
            {
                ModelState.AddModelError("Invalid Moment", errorMesssage);
                return View(unavailableMomentViewModel);
            }

            newUnavailableMoment.ReviewStatus = ReviewStatus.Pending;
            _unavailableMomentsRepository.Create(newUnavailableMoment);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetOpenTime(string dateInput)
        {
            DateTime date = DateTime.Parse(dateInput);
            var employee = await _userManager.GetUserAsync(User);


            // _branchRepository.GetOpeningTimes(employee.DefaultBranchId, date);
            var times = _branchRepository.GetOpenAndCloseTimesOnDay(date.ToDateOnly(), (int)employee.DefaultBranchId);
            var result = new { Open = times[0], Close = times[1] };
            return Json(result);

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
            foreach (var moment in oldMoments)
            {
                var newMoment = new UnavailableMoment();
                DateTime? newStartTime = moment.StartTime + diff;
                if (newStartTime != null) newMoment.StartTime = (DateTime) newStartTime;
                DateTime? newEndTime = moment.EndTime + diff;
                if (newEndTime != null) newMoment.EndTime = (DateTime) newEndTime;
                newMoment.Employee = await _userManager.GetUserAsync(User);
                newMoment.Type = moment.Type;
                newMoment.ReviewStatus = ReviewStatus.Pending;
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