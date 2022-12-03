using BumboData.Models;

namespace BumboServices.Interface;

public interface IRosterService
{
    Task<string?> GenerateRoster(int branchId, DateOnly day);
    
    Task<string?> GenerateRoster(int branchId, DateOnly day, List<PlannedShift> alreadyPlannedShifts);

}