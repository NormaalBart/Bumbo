﻿using AutoMapper;
using Bumbo.Models.Converters;
using Bumbo.Models.Standard;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager;

[Authorize(Roles = "Manager")]
public class StandardController : NotificationController
{
    private readonly IBranchRepository _branchRepository;
    private readonly IMapper _mapper;
    private readonly IStandardRepository _standardRepository;
    private readonly UserManager<Employee> _userManager;

    public StandardController(UserManager<Employee> userManager, IMapper mapper, IStandardRepository standardRepository,
        IBranchRepository branchRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _standardRepository = standardRepository;
        _branchRepository = branchRepository;
    }

    public async Task<IActionResult> Index()
    {
        var employee = await _userManager.GetUserAsync(User);
        var standards = _standardRepository.Get(employee.DefaultBranchId ?? -1);
        var viewModel = _mapper.Map<StandardViewModel>(standards);
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(StandardViewModel viewModel)
    {
        if (!ModelState.IsValid) return View(viewModel);

        var standards = StandardViewModelConverter.Convert(viewModel).ToList();
        var employee = await _userManager.GetUserAsync(User);
        var branch = _branchRepository.Get(employee.DefaultBranchId ?? -1);

        if (branch == null) return View(viewModel);
        var existingStandard = _standardRepository.Get(branch.Id);

        foreach (var standard in standards)
        {
            if (existingStandard.Any(s => s.Key == standard.Key))
            {
                // Update existing standard
                var existing = existingStandard.First(s => s.Key == standard.Key);
                existing.Value = standard.Value;
                _standardRepository.Update(existing);
            }
            else
            {
                // Add new
                standard.Branch = branch;
                _standardRepository.Update(standard);
            }
        }
        
        ShowMessage(MessageType.Success, "De data is opgeslagen");
        return RedirectToAction(nameof(Index));
    }
}