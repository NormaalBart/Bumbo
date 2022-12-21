using BumboData.Models;
using BumboServices.Roster;

namespace BumboServices.Interface;

public interface IRosterService
{
    Task<RosterCreationResponse> GenerateRoster(int branchId, DateOnly day);

    Task<RosterCreationResponse> GenerateRoster(int branchId, DateOnly day, List<PlannedShift> alreadyPlannedShifts);
}