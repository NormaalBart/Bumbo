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

    public RosterService(IPlannedShiftsRepository plannedShiftsRepository, IEmployeeRepository employeeRepository,
        IBranchRepository branchRepository, UserManager<Employee> userManager, IPrognosisRepository prognosisRepository)
    {
        _plannedShiftsRepository = plannedShiftsRepository;
        _employeeRepository = employeeRepository;
        _branchRepository = branchRepository;
        _userManager = userManager;
        _prognosisRepository = prognosisRepository;
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
        var remainingEmployees = _employeeRepository.GetAllEmployeesOfBranch(branchId)
            .Where(e => shiftsGrouped.All(s => s.Key != e.Id)).ToList();

        // Group by employees
        var employees = shiftsGrouped
            .Select(s => (s.Key, s.ToList()
                .SumTimeSpan(s => s.EndTime - s.StartTime).TotalHours))
            .OrderByDescending(s => s.TotalHours).ToList();

        // filter out managers from remaining employees
        // Check if all remaining employees roles
        employees.AddRange(from remainingEmployee in remainingEmployees
            where !_userManager.GetRolesAsync(remainingEmployee).Result.Contains(RoleType.MANAGER.Name)
            select (remainingEmployee.Id, 0.0));

        // Employee now has all the available employees in the branch sorted on how much hours they have worked.

        // Get all department prognosis
        // TODO: Get from prognosis
        var targetPlannedHours = 400;
        
        // TODO: Use open and closing times
        var openTime = new TimeOnly(10, 00);
        var closeTime = new TimeOnly(20, 00);
        
        // Load rest of the week roster days
        var allWeekShifts = _plannedShiftsRepository.GetAllShiftsWeek(branchId, day);
            
            // Cant generate if there are already shifts planned on this day for now
        if (allWeekShifts.Any(s => s.StartTime.Date == day.ToDateTime(new TimeOnly()).Date))
        {
            throw new AlreadyShiftsPlannedInWeekException();
        }

        var currentShifts = new List<PlannedShift>();
        
        
    }
}