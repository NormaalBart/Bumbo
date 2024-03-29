﻿using AutoMapper;
using Bumbo.Models.PrognosisManager;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager;

[Authorize(Roles = "Manager")]
public class PrognosisController : NotificationController
{
    private readonly IMapper _mapper;
    private readonly IPrognosisRepository _prognosisRepository;
    private readonly UserManager<Employee> _userManager;

    public PrognosisController(UserManager<Employee> userManager, IMapper mapper, IPrognosisRepository prognosisService)
    {
        _userManager = userManager;
        _mapper = mapper;
        _prognosisRepository = prognosisService;
    }

    public async Task<IActionResult> IndexAsync(string? dateInput, bool next)
    {
        // adds 7 because bool next is false by default.
        var currentDate = DateTime.Now.AddDays(7);
        // start of week, calculated by getting the difference between the date and monday.
        // This method should probably be moved to a static class as it is used in multiple places.
        var startOfWeek = currentDate.GetMondayOfTheWeek();

        if (dateInput != null) startOfWeek = DateTime.Parse(dateInput);

        if (next) startOfWeek = startOfWeek.AddDays(7);
        if (!next) startOfWeek = startOfWeek.AddDays(-7);

        // Returns the week of prognose days.
        var list = new PrognosisListViewModel();
        var employee = await _userManager.GetUserAsync(User);
        list.PrognosisList = _mapper
            .Map<IEnumerable<PrognosisViewModel>>(_prognosisRepository.GetNextWeek(startOfWeek.ToDateOnly(),
                employee.DefaultBranchId ?? -1)).ToList();
        list.CopyToWeekNumber = startOfWeek.GetWeekNumber();
        return View(list);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> IndexAsync(PrognosisListViewModel list)
    {
        if (!ModelState.IsValid) return View(list);

        var result = _mapper.Map<List<Prognosis>>(list.PrognosisList);
        if (result.Count != 0)
        {
            var employee = await _userManager.GetUserAsync(User);
            ShowMessage(MessageType.Success, "De data is opgeslagen");
            _prognosisRepository.AddOrUpdateAll(employee.DefaultBranchId ?? -1, result);
        }

        return View(list);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CopyFromWeekAsync(int copyFromWeekNumber, int copyToWeekNumber, int copyFromYear,
        int copyToYear)
    {
        // This method copies the prognosis week from a certain week and adds it to another one.
        var copyFromDate = OtherUtils.FirstDateOfWeekISO8601(copyFromYear, copyFromWeekNumber);
        var copyToDate = OtherUtils.FirstDateOfWeekISO8601(copyToYear, copyToWeekNumber);

        var employee = await _userManager.GetUserAsync(User);
        var copyFromPrognoses = _prognosisRepository
            .GetNextWeek(copyFromDate.ToDateOnly(), employee.DefaultBranchId ?? -1).ToList();

        if (copyFromPrognoses.All(prognose => prognose.CustomerCount == 0 && prognose.ColiCount == 0))
        {
            ShowMessage(MessageType.Error, "Deze week heeft geen prognose. Niks is veranderd");
            return RedirectToAction(nameof(Index));
        }

        var updatedNewWeek = new List<Prognosis>();
        for (var i = 0; i < copyFromPrognoses.Count(); i++)
        {
            var newPrognosis = new Prognosis();
            newPrognosis.Date = copyToDate.ToDateOnly().AddDays(i);
            newPrognosis.Branch = copyFromPrognoses[i].Branch;
            newPrognosis.CustomerCount = copyFromPrognoses[i].CustomerCount;
            newPrognosis.ColiCount = copyFromPrognoses[i].ColiCount;
            updatedNewWeek.Add(newPrognosis);
        }

        ShowMessage(MessageType.Success, "De data is opgeslagen");
        _prognosisRepository.AddOrUpdateAll(employee.DefaultBranchId ?? -1, updatedNewWeek);
        return RedirectToAction("Index", "Prognosis", new {dateInput = copyToDate.AddDays(-7).ToString(), next = true});
    }
}