using AutoMapper;
using Bumbo.Models.BranchController;
using BumboData;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public ActionResult Index()
        {
            var branches = _branchRepository.GetAllActiveBranches();
            List<BranchViewModel> result = _mapper.Map<List<BranchViewModel>>(branches);
            return View(result);
        }

        // GET: BranchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BranchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BranchViewModel branchModel)
        {
            if (ModelState.IsValid)
            {
                Branch branch = _mapper.Map<Branch>(branchModel);
                branch.StandardOpeningHours = new List<StandardOpeningHours>();
                foreach (var day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>())
                {
                    branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = day, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                }
                _branchRepository.Add(branch);
                return RedirectToAction(nameof(Index));
            }
            return View(branchModel);
        }

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            var branch = _branchRepository.GetById(id);
            if (branch == null)
            {
                return RedirectToAction("Index");
            }
            BranchViewModel branchViewModel = _mapper.Map<BranchViewModel>(branch);
            return View(branchViewModel);
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BranchViewModel branchViewModel)
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
            var branch = _branchRepository.GetById(id);
            if (branch == null)
            {
                return RedirectToAction("Index");
            }
            BranchViewModel branchViewModel = _mapper.Map<BranchViewModel>(branch);
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
