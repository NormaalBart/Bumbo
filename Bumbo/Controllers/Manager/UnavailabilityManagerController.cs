using AutoMapper;
using Bumbo.Models.UnavailableMoments;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Bumbo.Controllers.Manager
{
    [Authorize(Roles = "Manager")]
    public class UnavailabilityManagerController : Controller
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


        public async Task<IActionResult> Index()
        {
            var manager = await _userManager.GetUserAsync(User);
            // Returns all unavailability moments that haven't been approved yet.

            var unavailabilityMoments = _unavailableMomentsRepository.GetAllUnavailabilityMomentsByReviewStatus(manager.DefaultBranchId ?? -1, BumboData.Enums.ReviewStatus.Pending);

            UnavailabilityManagerListViewModel viewModel = new UnavailabilityManagerListViewModel();
            viewModel.UnavailableMoments = _mapper.Map<IEnumerable<UnavailableMomentsViewModel>>(unavailabilityMoments).ToList();  
            return View(viewModel);
        }


    }
}
