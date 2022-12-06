using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using BumboServices.Utils;
using Microsoft.AspNetCore.Identity;

namespace BumboServices.Roster;

public class RosterService : IRosterService
{
    private readonly IPlannedShiftsRepository _plannedShiftsRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IBranchRepository _branchRepository;
    private readonly UserManager<Employee> _userManager;
    private readonly IPrognosisRepository _prognosisRepository;
    private readonly ICAOService _caoService;
    private readonly IUnavailableMomentsRepository _unavailableMomentsRepository;
    private readonly Random _random;

    private const int MinShiftDurationHours = 3;

    public RosterService(IPlannedShiftsRepository plannedShiftsRepository, IEmployeeRepository employeeRepository,
        IBranchRepository branchRepository, UserManager<Employee> userManager, IPrognosisRepository prognosisRepository,
        ICAOService caoService, IUnavailableMomentsRepository unavailableMomentsRepository)
    {
        _plannedShiftsRepository = plannedShiftsRepository;
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
        _userManager = userManager;
        _prognosisRepository = prognosisRepository;
        _caoService = caoService;
        _unavailableMomentsRepository = unavailableMomentsRepository;

        _random = new Random();
    }

    public async Task<RosterCreationResponse> GenerateRoster(int branchId, DateOnly day)
    {
        return await GenerateRoster(branchId, day, new List<PlannedShift>());
    }

    public async Task<RosterCreationResponse> GenerateRoster(int branchId, DateOnly day, List<PlannedShift> alreadyPlannedShifts)
    {
        var branch = _branchRepository.Get(branchId);
        if (branch == null)
        {
            return RosterCreationResponse.NoBranch;
        }

        // Get already planned shifts in target month for the branch
        var shifts = _plannedShiftsRepository.GetShiftsByMonth(branchId, day.Year, day.Month);
        var shiftsGrouped = shifts.GroupBy(s => s.EmployeeId).ToList();

        // All employees not yet included in the roster this month.
        var remainingEmployees = _employeeRepository
            .GetAllEmployeesOfBranch(branchId)
            .Where(e => shiftsGrouped.All(s => s.Key != e.Id)).ToList();

        // Group employees and sort them to least worked this month.
        var employees = shiftsGrouped
            .Select(s => (s.Key, s.ToList()
                .SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours))
            .OrderByDescending(s => s.TotalHours).ToList();

        // filter out managers from remaining employees
        // Check if all remaining employees roles
        employees.AddRange(from remainingEmployee in remainingEmployees
            where !_userManager.GetRolesAsync(remainingEmployee).Result.Contains(RoleType.MANAGER.Name)
            select (remainingEmployee.Id, 0.0));

        if (employees.Count == 0)
        {
            return RosterCreationResponse.NoEmployees;
        }

        employees.Reverse();
        // Map so that the employee is now the key instead of the employee id
        var employeesMapped = employees
            .Select(emp => (shifts.Where(s => s.EmployeeId == emp.Key)?.FirstOrDefault()?.Employee
                            ?? remainingEmployees.FirstOrDefault(e => e.Id == emp.Key), emp.TotalHours))
            .ToList();

        // Employee now has all the available employees in the branch sorted on how much hours they have worked.

        // Get all department prognosis
        // TODO: Get from prognosis
        var targetPlannedHours = 400;

        var times = _branchRepository.GetOpenAndCloseTimes(branchId, day);

        // Check if closed
        if (times.Item1 == TimeOnly.MinValue || times.Item2 == TimeOnly.MinValue)
        {
            // Store is closed for the day
            return RosterCreationResponse.ClosedOnDay;
        }

        var openTime = day.ToDateTime(times.Item1);
        var closeTime = day.ToDateTime(times.Item2);

        // Load rest of the week roster days, required when checking for the CAO.
        var allWeekShifts = _plannedShiftsRepository.GetAllShiftsWeek(branchId, day);

        return GenerateRoster(branchId, day, employeesMapped, allWeekShifts, closeTime, openTime, targetPlannedHours,
            alreadyPlannedShifts);
    }

    private RosterCreationResponse GenerateRoster(int branchId, DateOnly day, List<(Employee?, double TotalHours)> employeesMapped,
        List<PlannedShift> allWeekShifts, DateTime closeTime,
        DateTime openTime, int targetPlannedHours, List<PlannedShift> alreadyPlannedShifts)
    {
        // Remove today from allweeksshifts
        allWeekShifts = allWeekShifts.Where(s => s.StartTime.Date.ToDateOnly() != day).ToList();

        // Holds all the shifts on target day.
        var currentShifts = new List<PlannedShift>();
        currentShifts.AddRange(alreadyPlannedShifts);

        // Check if prognosis has already been reached
        // TODO: Change when prognisis is properly implemented.
        if (currentShifts.SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours >= targetPlannedHours)
        {
            return RosterCreationResponse.AlreadyReachedPrognosis;
        }

        // Check if already planned shifts have CAO violations
        var checkCAOBefore = new List<PlannedShift>();
        checkCAOBefore.AddRange(allWeekShifts);
        checkCAOBefore.AddRange(currentShifts);
        if (_caoService.VerifyPlannedShifts(checkCAOBefore, day).Any())
        {
            return RosterCreationResponse.CaoViolationsFound;
        }

        // Loop through all employees that are available, starting with the ones that have worked the least hours this month.
        while (employeesMapped.Count > 1)
        {
            var emp = employeesMapped.First().Item1;
            employeesMapped.RemoveAt(0);

            var suggested = TryGenerateShift(branchId, emp, openTime, closeTime, allWeekShifts, currentShifts, day);
            if (suggested != null)
            {
                currentShifts.Add(suggested);
            }

            // TODO: Check if prognosis already hit with proper prognosis instead of hardcoded values.
            if (currentShifts.SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours >= targetPlannedHours)
            {
                break;
            }
        }

        // Save shifts, only newly generated ones.
        _plannedShiftsRepository.Import(currentShifts.Where(s => !alreadyPlannedShifts.Contains(s)).ToList());

        // Display error if prognosis has not completely been reached.
        return currentShifts.SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours < targetPlannedHours
            ? RosterCreationResponse.Incomplete
            : RosterCreationResponse.Succes;
    }

    /*
     * Tries to generate a shift with given parameters.
     */
    private PlannedShift? TryGenerateShift(int branch, Employee emp, DateTime openTime, DateTime closeTime,
        List<PlannedShift> allWeekShifts, List<PlannedShift> currentShifts, DateOnly day)
    {
        var tempShiftsOrigin = new List<PlannedShift>();
        tempShiftsOrigin.AddRange(allWeekShifts);
        tempShiftsOrigin.AddRange(currentShifts);

        // Calculate preferred start time, where currently the least hours are made.
        var leastPopulatedStartTime = Enumerable.Range(0, (closeTime - openTime).Hours).Select(h =>
        {
            return (h + openTime.Hour,
                currentShifts.Count(s =>
                    s.StartTime.Hour <= h + openTime.Hour && s.EndTime.Hour >= h + openTime.Hour));
        }).ToList();

        // Order so we can take the top values
        leastPopulatedStartTime = leastPopulatedStartTime.OrderBy(s => s.Item2).ToList();

        // For loops shifts start and end times around
        // Little bit of a bruteforce approach, but randomly try 10 times with random start and end times.
        // Initially start + end time is the same as store open and closing time.
        // Prefers longer shifts, and tries to occupy timeslots where the least people are present.
        for (int i = 0; i < 10; i++)
        {
            // Random generated start time
            var startTime = day.ToDateTime(new TimeOnly(
                openTime.Hour + _random.Next(Convert.ToInt32(Math.Floor((closeTime - openTime).TotalHours))), 00));

            // After at least 10 shifts have been made already, try and occupy the least populated times.
            // With a random chance, will overrwrite previous set start time above.
            if (leastPopulatedStartTime.Sum(s => s.Item2) > 10 && _random.Next(2) == 0)
            {
                startTime = day.ToDateTime(new TimeOnly(
                    Math.Min(closeTime.Hour - MinShiftDurationHours,
                        Math.Max(openTime.Hour, leastPopulatedStartTime.FirstOrDefault().Item1 - _random.Next(6))),
                    00));
            }

            // Generate end time using a combination of randomness, also preventing end time being after closing time.
            var endTime =
                day.ToDateTime(new TimeOnly(
                    Math.Min(closeTime.Hour, MinShiftDurationHours + startTime.Hour +
                                             _random.Next(Convert.ToInt32(Math.Floor((closeTime - openTime).TotalHours))) +
                                             _random.Next(5)), 00));

            // Only allow shifts of at least minShiftDurationHours hours
            if ((endTime - startTime).TotalHours < MinShiftDurationHours)
            {
                continue;
            }

            // Prefer longer shifts
            if (_random.Next(Convert.ToInt32((closeTime - openTime).TotalHours) -
                             Convert.ToInt32((endTime - startTime).TotalHours)) >
                ((closeTime - openTime).TotalHours / 2))
            {
                continue;
            }

            // Check for employee availability.
            if (!_unavailableMomentsRepository.IsEmployeeAvailable(emp.Id, startTime, endTime))
            {
                continue;
            }

            // Create list to send to the CAO service
            var tempShifts = new List<PlannedShift>();
            tempShifts.AddRange(tempShiftsOrigin);

            var pending = new PlannedShift()
            {
                Employee = emp,
                EmployeeId = emp.Id,
                StartTime = startTime,
                EndTime = endTime,
                BranchId = branch,
                // TODO: Use proper department.
                DepartmentId = 1,
            };
            tempShifts.Add(pending);

            // Verify if CAO is valid.
            if (_caoService.VerifyPlannedShifts(tempShifts, day).Count == 0)
            {
                // Valid by following CAO
                return pending;
            }
        }

        return null;
    }
}