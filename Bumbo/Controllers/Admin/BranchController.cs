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
            var branches = _branchRepository.GetAll();
            List<BranchuViewModel> result = _mapper.Map<List<BranchuViewModel>>(branches);
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
        public ActionResult Create(BranchuViewModel branchModel)
        {
            if (ModelState.IsValid)
            {
                Branch branch = _mapper.Map<Branch>(branchModel);
                branch.StandardOpeningHours = new List<StandardOpeningHours>();
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Sunday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Monday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Tuesday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Wednesday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Thursday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Friday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                branch.StandardOpeningHours.Add(new StandardOpeningHours { DayOfWeek = DayOfWeek.Saturday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });
                _branchRepository.Add(branch);
                return RedirectToAction(nameof(Index));
            }
            return View(branchModel);
        }

        // GET: BranchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BranchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BranchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
