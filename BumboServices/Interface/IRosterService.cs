namespace BumboServices.Interface;

public interface IRosterService
{
    Task<string?> GenerateRoster(int branchId, DateOnly day);
}