using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager;

[Authorize(Roles = "Manager")]
public class UnavailabilityManagerController : NotificationController
{
    private const int _pageSize = 20;
    private readonly IMapper _mapper;
    private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
    private readonly UserManager<Employee> _userManager;

    public UnavailabilityManagerController(UserManager<Employee> userManager, IMapper mapper,
        IUnavailableMomentsRepository unavailableMomentsRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _unavailableMomentsRepository = unavailableMomentsRepository;
    }

    public async Task<IActionResult> Index(string? searchString = "", bool includeAccepted = false,
        UnavailabilitySortingOption sortingOption = UnavailabilitySortingOption.Status_Todo, int? Page = 1)
    {
        if (string.IsNullOrEmpty(searchString)) searchString = "";
        if (Page <= 1) Page = 1;
        var viewModel = new UnavailabilityManagerListViewModel();
        var manager = await _userManager.GetUserAsync(User);
        var total = _unavailableMomentsRepository.GetTotalMoments(manager.DefaultBranchId, searchString,
            includeAccepted);
        var unavailabilityMoments = _unavailableMomentsRepository.GetAllMoments(manager.DefaultBranchId, searchString,
            includeAccepted, sortingOption, Page, _pageSize);

        viewModel.UnavailableMoments =
            _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(unavailabilityMoments).ToList();
        viewModel.SearchString = searchString;
        viewModel.MaxPage = (total + _pageSize - 1) / _pageSize;
        viewModel.Page = Page ?? 1;
        viewModel.IncludeAccepted = includeAccepted;
        viewModel.SortingOption = sortingOption;
        viewModel.Ids = viewModel.UnavailableMoments.Select(u => u.Id).ToList();
        return View(viewModel);
    }

    [ValidateAntiForgeryToken]
    [HttpPost]
    public IActionResult Review(int id, bool isApproved, string? searchString = "", bool includeAccepted = false,
        UnavailabilitySortingOption sortingOption = UnavailabilitySortingOption.Status_Todo, int? Page = 1)
    {
        var unavailabilityMoment = _unavailableMomentsRepository.Get(id);
        if (unavailabilityMoment == null)
        {
            ShowMessage(MessageType.Error, "Er is iets fout gegaan");
            return NotFound();
        }

        if (unavailabilityMoment.ReviewStatus != ReviewStatus.Pending)
        {
            ShowMessage(MessageType.Error, "Afwezigheidsverzoek is al geupdate");
            return BadRequest();
        }

        if (isApproved)
        {
            unavailabilityMoment.ReviewStatus = ReviewStatus.Approved;
            ShowMessage(MessageType.Success, "Afwezigheidsverzoek goedgekeurd");
        }
        else
        {
            unavailabilityMoment.ReviewStatus = ReviewStatus.Rejected;
            ShowMessage(MessageType.Success, "Afwezigheidsverzoek afgekeurd");
        }

        _unavailableMomentsRepository.Update(unavailabilityMoment);
        return RedirectToAction(nameof(Index), new {searchString, includeAccepted, sortingOption, Page});
    }

    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<IActionResult> ReviewAll(bool isApproved, List<int> ids, string? searchString = "",
        bool includeAccepted = false,
        UnavailabilitySortingOption sortingOption = UnavailabilitySortingOption.Status_Todo, int? Page = 1)
    {
        // This method recieves a 'isApproved' bool to indicate if it is approved or reject.
        // Currently there's only a button to approve all, as I am not sure if a reject all is neccesesary.
        // I still made this method work for a reject all button incase it is ever requested in the future. 
        // But there's almost no situation in which a manager would use such a button.

        var manager = await _userManager.GetUserAsync(User);

        // We set the status of each moment in the list to the given status
        var newStatus = ReviewStatus.Approved;
        if (!isApproved) newStatus = ReviewStatus.Rejected;

        _unavailableMomentsRepository.UpdateRange(newStatus, ids);
        ShowMessage(MessageType.Success, "Afwezigheidsverzoeken geupdate");
        return RedirectToAction(nameof(Index), new {searchString, includeAccepted, sortingOption, Page});
    }
}