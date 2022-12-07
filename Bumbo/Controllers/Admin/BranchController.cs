using AutoMapper;
using Bumbo.Models.BranchController;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Admin
{

    [Authorize(Roles = "Administrator,Manager")]
    public class BranchController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private IMapper _mapper;
        private IBranchRepository _branchRepository;
        private const int ItemsPerPage = 25;

        public BranchController(UserManager<Employee> userManager, IMapper mapper, IBranchRepository branchRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _branchRepository = branchRepository;
        }

        [Authorize(Roles = "Administrator")]
        // GET: BranchController
        /*
                public ActionResult Index(int page = 1)
                {
                    if (page < 1) { page = 1; }
                    List<BranchViewModel> result = new List<BranchViewModel>();
                    while (result.Count == 0)
                    {
                        var branches = _branchRepository.GetAllActiveBranches((page - 1) * ItemsPerPage, ItemsPerPage);
                        result = _mapper.Map<List<BranchViewModel>>(branches);
                        if (result.Count == 0 && page > 1)
                        {
                            page--;
                            branches = _branchRepository.GetAllActiveBranches((page - 1) * ItemsPerPage, ItemsPerPage);
                            result = _mapper.Map<List<BranchViewModel>>(branches);
                            break;
                        }
                    }
                    BranchListViewModel viewModel = new BranchListViewModel(result, page);
                    return View(viewModel);
        */
        public IActionResult Index(string searchString, bool includeInactive, bool includeActive, BranchSortingOption currentSort, int page = 1)
        {

            if (page < 1) { page = 1; }


            var resultingListViewModel = new BranchListIndexViewModel();

            var branches = _branchRepository.GetList((page - 1) * ItemsPerPage, ItemsPerPage);

            while (branches.Count() == 0 && page > 1)
            {
                page--;
                branches = _branchRepository.GetList((page - 1) * ItemsPerPage, ItemsPerPage);
            }


            if (!includeInactive && !includeActive)
            {
                branches = branches.Where(e => !e.Inactive).ToList();
                resultingListViewModel.IncludeActive = true;
            }
            else if (!includeInactive && includeActive)
            {
                branches = branches.Where(e => !e.Inactive).ToList();
            }
            else if (includeInactive && !includeActive)
            {
                branches = branches.Where(e => e.Inactive).ToList();
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                // search in branches if any of the columns contains the searchstring
                resultingListViewModel.SearchString = searchString;
                searchString = searchString.ToLower();
                branches = branches.Where(e => e.Name.ToLower().StartsWith(searchString));
            }

            switch (currentSort)
            {
                // case for each sortingoption, with asc and desc
                case BranchSortingOption.Name_Asc:
                    branches = branches.OrderBy(e => e.Name);
                    break;
                case BranchSortingOption.Name_Desc:
                    branches = branches.OrderByDescending(e => e.Name);
                    break;
                case BranchSortingOption.Employees_Asc:
                    branches = branches.OrderBy(e => e.DefaultEmployees.Count());
                    break;
                case BranchSortingOption.Employees_Desc:
                    branches = branches.OrderByDescending(e => e.DefaultEmployees.Count());
                    break;
                default:
                    branches = branches.OrderBy(e => e.Name);
                    break;
            }

            resultingListViewModel.Branches = _mapper.Map<IEnumerable<ListIndexBranchViewModel>>(branches).ToList();
            return View(resultingListViewModel);
        }

        [Authorize(Roles = "Administrator")]
        // GET: BranchController/Create
        public ActionResult Create()
        {
            var viewModel = new BranchCreateViewModel();
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                viewModel.OpeningHours.Add(new OpeningHoursViewModel { DayOfWeek = dayOfWeek, OpenTime = new TimeSpan(8, 00, 00), CloseTime = new TimeSpan(18, 00, 00) });
            }
            return View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        // POST: BranchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BranchCreateViewModel branchModel)
        {
            if (ModelState.IsValid)
            {
                var branch = _mapper.Map<Branch>(branchModel);
                var openingHours = branch.StandardOpeningHours;
                branch.StandardOpeningHours = new List<StandardOpeningHours>();
                branch = _branchRepository.Create(branch);
                foreach (var openingHour in openingHours)
                {
                    openingHour.Branch = branch;
                    openingHour.BranchId = branch.Id;
                }
                branch.StandardOpeningHours = openingHours;
                _branchRepository.Update(branch);
                return RedirectToAction(nameof(Index));
            }
            return View(branchModel);
        }

        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> EditManager()
        {
            var manager = await _userManager.GetUserAsync(User);
            return RedirectToAction(nameof(Edit), new { Id = manager.DefaultBranchId });
        }

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            var branch = _branchRepository.Get(id);
            if (branch == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var branchViewModel = _mapper.Map<BranchEditViewModel>(branch);
            return View(branchViewModel);
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BranchEditViewModel branchViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Fout in validatie");
                return View(branchViewModel);
            }
            try
            {
                var branch = _branchRepository.Get(branchViewModel.Id);
                _mapper.Map<BranchEditViewModel, Branch>(branchViewModel, branch);
                _branchRepository.Update(branch);
                if (User.IsInRole(RoleType.ADMINISTRATOR.Name))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult SetInactive(int id)
        {
            var branch = _branchRepository.Get(id);
            if (branch == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var branchViewModel = _mapper.Map<BranchCreateViewModel>(branch);
            return View(branchViewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetInactive(int id, IFormCollection collection)
        {
            _branchRepository.SetInactive(id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult SetActive(int id)
        {
            var branch = _branchRepository.Get(id);
            if (branch == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var branchViewModel = _mapper.Map<BranchCreateViewModel>(branch);
            return View(branchViewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetActive(int id, IFormCollection collection)
        {
            _branchRepository.SetActive(id);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult AddSpecialOpeningHour(int id)
        {
            var viewModel = new OpeningHoursOverrideViewModel { BranchId = id };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSpecialOpeningHour(OpeningHoursOverrideViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var branch = _branchRepository.Get(viewModel.BranchId);
            if (branch == null)
            {
                // We have no idea what the branch of the user is. Let accountcontroller figure it out and redirect him.
                return RedirectToAction("Login", "Account");
            }
            var openingHour = _mapper.Map<OpeningHoursOverride>(viewModel);
            branch.OpeningHoursOverrides.Add(openingHour);
            _branchRepository.Update(branch);
            return RedirectToAction(nameof(Edit), new { Id = viewModel.BranchId });
        }

        public ActionResult DeleteSpecialOpeningHour(DateTime date, int id)
        {
            _branchRepository.RemoveSpecialOpeningHour(id, DateOnly.FromDateTime(date));
            return RedirectToAction(nameof(Edit), new { Id = id });
        }
    }
}
