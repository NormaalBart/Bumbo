using AutoMapper;
using Bumbo.Models.EmployeeRoster;
using Bumbo.Models.RosterManager;
using Bumbo.Utils;
using BumboData;
using BumboData.Models;
using BumboRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{

    [Authorize(Roles = "Manager")]
    public class RosterManagerController : Controller
    {
        private IMapper _mapper;
        private IEmployeeRepository _employeeRepository;
        private IPrognosisRepository _prognosisRepository;
        private IPlannedShiftsRepository _shiftRepository;
        private IUnavailableMomentsRepository _unavailableRepository;
        public RosterManagerController(IMapper mapper, IEmployeeRepository employee, IPrognosisRepository prognosis, IPlannedShiftsRepository plannedShifts, IUnavailableMomentsRepository unavailableMoments)
        {
            _mapper = mapper;
            _employeeRepository = employee;
            _prognosisRepository = prognosis;
            _shiftRepository = plannedShifts;
            _unavailableRepository = unavailableMoments;
        }
            
            
        public IActionResult Index(string? dateInput)
        {

            if (dateInput == null)
            {
                dateInput = DateTime.Today.ToString();
            }
            DateTime date = DateTime.Parse(dateInput);
            RosterDayViewModel viewModel = new RosterDayViewModel();
            viewModel.Date = date;
            var employeeList = _employeeRepository.GetAll();
            var e = _mapper.Map<IEnumerable<EmployeeRosterViewModel>>(employeeList);
            viewModel.Employees = e.ToList();

            foreach (var emp in viewModel.Employees)
            {
                emp.PlannedShifts = _mapper.Map<IEnumerable<ShiftViewModel>>(_shiftRepository.GetWeekOfShiftsAfterDateForEmployee(date, emp.Id)).ToList();
            }
            

            viewModel.CassierePrognose = _prognosisRepository.GetCassierePrognose(date);
            viewModel.StockersPrognose = _prognosisRepository.GetStockersPrognose(date);
            viewModel.FreshPrognose = _prognosisRepository.GetFreshPrognose(date);
            var shiftsOnDay = _mapper.Map<IEnumerable<ShiftViewModel>>(_prognosisRepository.GetShiftsOnDayByDate(date)).ToList();
            viewModel.UpdatePrognosis(shiftsOnDay);
            viewModel.PrognosisDayId = _prognosisRepository.GetIdByDate(date);
            return View(viewModel);
        }
        
        
        public IActionResult Create(string employeeId, string dateInput, int prognosisId)
        {
            RosterShiftCreateViewModel viewModel = new RosterShiftCreateViewModel();
            viewModel.Date = DateTime.Parse(dateInput);
            viewModel.StartTime = viewModel.Date.AddHours(8);
            viewModel.EndTime = viewModel.Date.AddHours(16);
            viewModel.PrognosisId = prognosisId;
            viewModel.DepartmentsList = _employeeRepository.GetById(employeeId).AllowedDepartments.ToList();
            
            return View(viewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RosterShiftCreateViewModel newShift)
        {
            int maxHoursInWeekAllowed = 40; // DEFAULT 40 TODO 
            
            newShift.DepartmentsList = _employeeRepository.GetById(newShift.EmployeeId).AllowedDepartments.ToList();

            // since starttime and endtime seem to only save the timestamps, we need to add the date to it
            newShift.StartTime = newShift.Date.AddHours(newShift.StartTime.Hour);
            newShift.EndTime = newShift.Date.AddHours(newShift.EndTime.Hour);

            //check if the endtime is after starttime
            if (newShift.EndTime < newShift.StartTime)
            {
                ModelState.AddModelError("EndTime", "Eindtijd moet na starttijd komen.");
                return View(newShift);
            }
            
            if (ModelState.IsValid)
            {
                var shift = _mapper.Map<PlannedShift>(newShift);


                // overlapping shifts
                if (_shiftRepository.ShiftOverlapsWithOtherShifts(shift))
                {
                    ModelState.AddModelError("StartTime", "Medewerker is al ingepland for deze tijden.");
                    ModelState.AddModelError("EndTime", "Medewerker is al ingepland for deze tijden.");
                    return View(newShift);
                }
                // check availability employee
                if (!_unavailableRepository.IsEmployeeAvailable(shift.Employee.Id, shift.StartTime, shift.EndTime))
                {
                    ModelState.AddModelError("StartTime", "Medewerker is niet beschikbaar voor deze tijd.");
                    ModelState.AddModelError("EndTime", "Medewerker is niet beschikbaar voor deze tijd.");
                }
                // check if CAO rules are met.
                if(_shiftRepository.GetHoursPlannedInWorkWeek(shift.Employee.Id, shift.StartTime.Date) + (shift.EndTime - shift.StartTime).TotalHours > maxHoursInWeekAllowed)
                {
                    ModelState.AddModelError("StartTime", "Medewerker heeft al te veel gewerkt deze week.");
                    ModelState.AddModelError("EndTime", "Medewerker heeft al te veel gewerkt deze week.");
                    return View(newShift);
                }
                
                
                _shiftRepository.Add(shift);
                return RedirectToAction("Index", new RouteValueDictionary(
                    new { controller = "RosterManager", action = "Index", dateInput = newShift.StartTime.Date.ToString()}));
            }
            return View(newShift);
        }


        public IActionResult EmployeeRoster(string? dateInput)
        {
            // requested date 
            DateTime date = DateTime.Today;
            if (dateInput != null)
            {
                date = DateTime.Parse(dateInput);
            }

            // id of the employee logged in currently.
            string employeeId = _employeeRepository.GetIdOfEmployeeLoggedIn();
            


            EmployeeShiftsListViewModel shiftsVM = new EmployeeShiftsListViewModel();
            shiftsVM.Date = date.ToDateOnly();
            var dbshifts = _shiftRepository.GetWeekOfShiftsAfterDateForEmployee(date, employeeId);
            shiftsVM.shifts = _mapper.Map<IEnumerable<EmployeeShiftViewModel>>(dbshifts).ToList();

            return View(shiftsVM);
        }
    }
    
}
