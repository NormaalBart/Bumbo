using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
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
    }

    public async void GenerateRoster(int branchId, DateOnly day)
    {
        var branch = _branchRepository.Get(branchId);
        if (branch == null)
        {
            return;
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
            return;
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

        // TODO: Use open and closing times
        var openTime = day.ToDateTime(new TimeOnly(8, 00));
        var closeTime = day.ToDateTime(new TimeOnly(22, 00));

        // Load rest of the week roster days
        var allWeekShifts = _plannedShiftsRepository.GetAllShiftsWeek(branchId, day);

        // Cant generate if there are already shifts planned on this day for now
        if (allWeekShifts.Any(s => s.StartTime.Date == day.ToDateTime(new TimeOnly()).Date))
        {
            return;
        }

        GenerateRoster(branchId, day, employeesMapped, allWeekShifts, closeTime, openTime, targetPlannedHours);
    }

    private void GenerateRoster(int branchId, DateOnly day, List<(Employee?, double TotalHours)> employeesMapped, List<PlannedShift> allWeekShifts, DateTime closeTime,
        DateTime openTime, int targetPlannedHours)
    {
        var currentShifts = new List<PlannedShift>();
        var rnd = new Random();

        while (employeesMapped.Count > 1)
        {
            var emp = employeesMapped.First().Item1;
            employeesMapped.RemoveAt(0);

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

            // For loops shifts start and end times arround
            // Little bit of a bruteforce approach, but randomly try 10 times with random start and end times.
            // Initially start + end time is the same as store open and closing time.
            for (int i = 0; i < 10; i++)
            {
                var startTime = day.ToDateTime(new TimeOnly(
                    openTime.Hour + rnd.Next(Convert.ToInt32(Math.Floor((closeTime - openTime).TotalHours))), 00));

                // After at least 10 shifts have been made already, try and occupy the least populated times.
                // With a random chance
                if (leastPopulatedStartTime.Sum(s => s.Item2) > 10 && rnd.Next(2) == 0)
                {
                    startTime = day.ToDateTime(new TimeOnly(
                        Math.Min(closeTime.Hour - 3,
                            Math.Max(openTime.Hour, leastPopulatedStartTime.FirstOrDefault().Item1 - rnd.Next(6))), 00));
                }

                // Generate end time using a combination of randomness
                var endTime =
                    day.ToDateTime(new TimeOnly(
                        Math.Min(closeTime.Hour, 3 + startTime.Hour +
                                                 rnd.Next(Convert.ToInt32(Math.Floor((closeTime - openTime).TotalHours))) +
                                                 rnd.Next(5)), 00));

                // Only allow shifts of at least 3 hours
                if ((endTime - startTime).TotalHours < 3)
                {
                    continue;
                }

                // Prefer longer shifts
                if (rnd.Next(Convert.ToInt32((closeTime - openTime).TotalHours) -
                             Convert.ToInt32((endTime - startTime).TotalHours)) > ((closeTime - openTime).TotalHours / 2))
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
                    BranchId = branchId,
                    // TODO: Use proper department.
                    DepartmentId = 1,
                };
                tempShifts.Add(pending);

                // Verify if CAO is valid.
                if (_caoService.VerifyPlannedShiftsWeek(tempShifts).Count == 0)
                {
                    // Valid by following CAO
                    currentShifts.Add(pending);
                    break;
                }
            }

            // TODO: Check if prognosis already hit
            if (currentShifts.SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours >= targetPlannedHours)
            {
                break;
            }
            else
            {
                // TODO: Restart this loop once more.
                
            }
        }
        // Commit shifts

        _plannedShiftsRepository.Import(currentShifts);
    }
}