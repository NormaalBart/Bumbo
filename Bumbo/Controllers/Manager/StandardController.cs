using AutoMapper;
using Bumbo.Models.Converters;
using Bumbo.Models.Standard;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager
{

    [Authorize(Roles = "Manager")]
    public class StandardController : NotificationController
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IStandardRepository _standardRepository;
        private readonly IBranchRepository _branchRepository;

        public StandardController(UserManager<Employee> userManager, IMapper mapper, IStandardRepository standardRepository, IBranchRepository branchRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _standardRepository = standardRepository;
            _branchRepository = branchRepository;
        }
        public async Task<IActionResult> Index()
        {
            Employee employee = await _userManager.GetUserAsync(User);
            var standards = _standardRepository.Get(employee.DefaultBranchId);
            var viewModel = _mapper.Map<StandardViewModel>(standards);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(StandardViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var standards = StandardViewModelConverter.Convert(viewModel).ToList();
            Employee employee = await _userManager.GetUserAsync(User);
            Branch branch = _branchRepository.Get(employee.DefaultBranchId);
            
            if(branch == null)
            {
                return View(viewModel);
            }

            foreach(var standard in standards)
            {
                standard.BranchId = branch.Id;
            }

            branch.Standards = standards;
            _branchRepository.Update(branch);
            ShowMessage(MessageType.Success, "De data is opgeslagen");
            return RedirectToAction(nameof(Index));
        }
    }
}
