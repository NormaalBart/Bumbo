using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Employees;

[Authorize(Roles = "Employee")]
public class UnavailableMomentsController : NotificationController
{
    private readonly IBranchRepository _branchRepository;
    private readonly IMapper _mapper;
    private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
    private readonly UserManager<Employee> _userManager;

    public UnavailableMomentsController(UserManager<Employee> userManager,
        IUnavailableMomentsRepository unavailableMomentListRepository, IMapper mapper,
        IBranchRepository branchRepository)
    {
        _userManager = userManager;
        _unavailableMomentsRepository = unavailableMomentListRepository;
        _mapper = mapper;
        _branchRepository = branchRepository;
    }

    public async Task<IActionResult> Index()
    {
        var unavailableMoments = new List<UnavailableMoment>();
        var Databaseresult = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User));
        var viewModel = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(Databaseresult).ToList();
        var sortedViewModel = viewModel.OrderBy(e => e.StartTime).Where(e => e.EndTime >= DateTime.Now.Date).ToList();
        var unavailableMomentsListViewModel = new UnavailableMomentsListViewModel(sortedViewModel);
        return View(unavailableMomentsListViewModel);
    }

    public IActionResult Create()
    {
        var unAvailableMoments = new UnavailableMomentCreateViewModel();
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
        var newUnavailableMoment = new UnavailableMoment();
        newUnavailableMoment.StartTime =
            unavailableMomentViewModel.StartDate.Add(TimeOnly.Parse(unavailableMomentViewModel.StartHour).ToTimeSpan());
        newUnavailableMoment.EndTime =
            unavailableMomentViewModel.EndDate.Add(TimeOnly.Parse(unavailableMomentViewModel.EndHour).ToTimeSpan());

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
        ShowMessage(MessageType.Success, "Het verzoek is aangemaakt!");
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> GetOpenTime(string dateInput)
    {
        var date = DateTime.Parse(dateInput);
        var employee = await _userManager.GetUserAsync(User);

        // _branchRepository.GetOpeningTimes(employee.DefaultBranchId, date);
        var times = _branchRepository.GetOpenAndCloseTimes((int) employee.DefaultBranchId, date.ToDateOnly());
        var result = new {Open = times.Item1.ToString(), Close = times.Item2.ToString()};
        return Json(result);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var unavailableMoment = _unavailableMomentsRepository.Get(id);
        if (unavailableMoment == null) return RedirectToAction("Index");

        var employee = await _userManager.GetUserAsync(User);
        if (unavailableMoment.EmployeeId != employee.Id)
            return RedirectToAction("AccessDenied", "Account");

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
        ShowMessage(MessageType.Success, "Moment is verwijderd!");
        return RedirectToAction("Index");
    }

    private string? UnavailableMomentValid(UnavailableMoment unavailableMoment)
    {
        if (unavailableMoment == null) return "Er is iets fout gegaan, probeer het opnieuw.";

        if (unavailableMoment.StartTime < DateTime.Now || unavailableMoment.EndTime < DateTime.Now)
            return "Kan geen afwezigheid plannen in het verleden.";

        if (unavailableMoment.StartTime >= unavailableMoment.EndTime) return "Start tijd kan niet na de eindtijd zijn.";

        var overlappingMoments = _unavailableMomentsRepository.GetOverlappingMoments(unavailableMoment);
        if (overlappingMoments.Count() > 0) return "Je hebt deze tijd al eerder ingevuld.";

        return null;
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CopyFromDay(UnavailableMomentsListViewModel unavailableMomentViewModel)
    {
        var newMoments = new List<UnavailableMoment>();
        var oldMoments = _unavailableMomentsRepository.GetAll(_userManager.GetUserId(User))
            .Where(e => e.StartTime.Date == unavailableMomentViewModel.CopyFrom.Date).ToList();
        var diff = unavailableMomentViewModel.CopyTo - unavailableMomentViewModel.CopyFrom;
        var currentEmployee = await _userManager.GetUserAsync(User);
        foreach (var moment in oldMoments)
        {
            var newMoment = new UnavailableMoment();
            DateTime? newStartTime = moment.StartTime + diff;
            if (newStartTime != null) newMoment.StartTime = (DateTime) newStartTime;
            DateTime? newEndTime = moment.EndTime + diff;
            if (newEndTime != null) newMoment.EndTime = (DateTime) newEndTime;
            newMoment.Employee = currentEmployee;
            newMoment.Type = moment.Type;
            newMoment.ReviewStatus = ReviewStatus.Pending;
            newMoments.Add(newMoment);
        }

        // Since there could be multiple Moments on a day
        // We save the error outside the loop, and check after if it is null.
        // If we were to instead show the error inside the loop, it is ovverriden. 
        string? error = null;
        newMoments.ForEach(e =>
        {
            string? er = UnavailableMomentValid(e);
            if (er == null)
            {
                _unavailableMomentsRepository.Create(e);
            }
            else
            {
                error = er;
            }
        });

        if (error != null)
        {
            ShowMessage(MessageType.Warning, error);
        }
        else
        {
            ShowMessage(MessageType.Success, "De data is opgeslagen");
        }

        return RedirectToAction("Index");
    }
}