using AutoMapper;
using Bumbo.Models.Standard;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers.Manager
{

    [Authorize(Roles = "Manager")]
    public class StandardController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly IStandardRepository _standardRepository;

        public StandardController(UserManager<Employee> userManager, IMapper mapper, IStandardRepository standardRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _standardRepository = standardRepository;
        }
        public async Task<IActionResult> IndexAsync()
        {
            Employee employee = await _userManager.GetUserAsync(User);
            var standards = _standardRepository.Get(employee.DefaultBranchId);
            var viewModel = _mapper.Map<List<StandardViewModel>>(standards);
            return View(new StandardIndexViewModel() { Standard = viewModel });
        }
    }
}
