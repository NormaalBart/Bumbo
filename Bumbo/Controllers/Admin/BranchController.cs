using AutoMapper;
using Bumbo.Models.BranchController;
using Bumbo.Models.EmployeeManager.Index;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Admin
{

    [Authorize(Roles = "Administrator")]
    public class BranchController : Controller
    {
        private IMapper _mapper;
        private IBranchRepository _branchRepository;

        public BranchController(IMapper mapper, IBranchRepository branchRepository)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
        }

        // GET: BranchController
        public IActionResult Index(string searchString, bool includeInactive, bool includeActive, BranchSortingOption currentSort)
        {

            var resultingListViewModel = new BranchListIndexViewModel();
            var branches = _branchRepository.GetList();

            if (!includeInactive && !includeActive)
            {
                branches = branches.Where(e => !e.Inactive);
                resultingListViewModel.IncludeActive = true;
            }
            else if (!includeInactive && includeActive)
            {
                branches = branches.Where(e => !e.Inactive);
            }
            else if (includeInactive && !includeActive)
            {
                branches = branches.Where(e => e.Inactive);
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

        // GET: BranchController/Create
        public ActionResult Create()
        {
            var viewModel = new BranchCreateViewModel();
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                viewModel.OpeningHours.Add(new OpeningHouersViewModel { DayOfWeek = dayOfWeek, OpenTime = new TimeSpan(8, 00, 00), CloseTime = new TimeSpan(18, 00, 00) });
            }
            return View(viewModel);
        }

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
                foreach(var openingHour in openingHours)
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

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            var branch = _branchRepository.Get(id);
            if (branch == null)
            {
                return RedirectToAction(nameof(Index));
            }
            BranchCreateViewModel branchViewModel = _mapper.Map<BranchCreateViewModel>(branch);
            return View(branchViewModel);
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BranchCreateViewModel branchViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Fout in validatie");
                return View(branchViewModel);
            }
            try
            {
                Branch branch = _mapper.Map<Branch>(branchViewModel);
                _branchRepository.Update(branch);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetInactive(int id, IFormCollection collection)
        {
            _branchRepository.SetInactive(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
