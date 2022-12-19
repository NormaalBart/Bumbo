using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using System.Data;

namespace Bumbo.Controllers.Manager
{
    [Authorize(Roles = "Manager")]
    public class UnavailabilityManagerController : NotificationController
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;

        public UnavailabilityManagerController(UserManager<Employee> userManager, IMapper mapper, IUnavailableMomentsRepository unavailableMomentsRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _unavailableMomentsRepository = unavailableMomentsRepository;
        }


        public async Task<IActionResult> Index(string? searchString)
        {

            var manager = await _userManager.GetUserAsync(User);
            // Returns all unavailability moments that haven't been approved yet.

            var unavailabilityMoments = _unavailableMomentsRepository.GetAllUnavailabilityMomentsByReviewStatus(manager.DefaultBranchId ?? -1, BumboData.Enums.ReviewStatus.Pending, searchString);

            UnavailabilityManagerListViewModel viewModel = new UnavailabilityManagerListViewModel();
            viewModel.UnavailableMoments = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(unavailabilityMoments).ToList();
            viewModel.SearchString = searchString;

            var selectedids = viewModel.UnavailableMoments.Select(u => u.Id).ToList();
            viewModel.Ids = selectedids;
            return View(viewModel);
        }

        public async Task<IActionResult> MonthlyOverview(string? dateInput, string? searchString)
        {
            DateTime inputtedDate = DateTime.Now;
            if (dateInput != null)
            {
                inputtedDate = DateTime.Parse(dateInput);
            }
            DateTime firstDateOfMonth = new DateTime(inputtedDate.Year, inputtedDate.Month, 1);

            var manager = await _userManager.GetUserAsync(User);
            // Returns all unavailability moments that haven't been approved yet.

            var unavailabilityMoments = _unavailableMomentsRepository.GetAllMomentsFromMonth(manager.DefaultBranchId ?? -1, firstDateOfMonth, searchString);

            UnavailabilityManagerListViewModel viewModel = new UnavailabilityManagerListViewModel();
            viewModel.UnavailableMoments = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(unavailabilityMoments).ToList();
            viewModel.Date = firstDateOfMonth;
            viewModel.SearchString = searchString;
            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Review(int id, bool isApproved)
        {

            var unavailabilityMoment = _unavailableMomentsRepository.Get(id);
            if (unavailabilityMoment == null)
            {
                ShowMessage(MessageType.Error, "Er is iets fout gegaan");
                return NotFound();
            }

            if (unavailabilityMoment.ReviewStatus != BumboData.Enums.ReviewStatus.Pending)
            {
                ShowMessage(MessageType.Error, "Afwezigheidsverzoek is al geupdate");
                return BadRequest();
            }

            if (isApproved)
            {
                unavailabilityMoment.ReviewStatus = BumboData.Enums.ReviewStatus.Approved;
                ShowMessage(MessageType.Success, "Afwezigheidsverzoek goedgekeurd");
            }
            else
            {
                unavailabilityMoment.ReviewStatus = BumboData.Enums.ReviewStatus.Rejected;
                ShowMessage(MessageType.Success, "Afwezigheidsverzoek afgekeurd");
            }
            _unavailableMomentsRepository.Update(unavailabilityMoment);
            return RedirectToAction(nameof(Index));
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> ReviewAll(bool isApproved, List<int> ids)
        {
            // This method recieves a 'isApproved' bool to indicate if it is approved or reject.
            // Currently there's only a button to approve all, as I am not sure if a reject all is neccesesary.
            // I still made this method work for a reject all button incase it is ever requested in the future. 
            // But there's almost no situation in which a manager would use such a button.

            var manager = await _userManager.GetUserAsync(User);

            // We set the status of each moment in the list to the given status
            ReviewStatus newStatus = ReviewStatus.Approved;
            if (!isApproved)
            {
                newStatus = ReviewStatus.Rejected;
            }


            _unavailableMomentsRepository.UpdateRange(newStatus, ids);
            ShowMessage(MessageType.Success, "Afwezigheidsverzoeken geupdate");
            return RedirectToAction(nameof(Index));
        }


    }
}
