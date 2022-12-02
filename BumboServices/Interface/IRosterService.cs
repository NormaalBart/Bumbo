namespace BumboServices.Interface;

public interface IRosterService
{
    void GenerateRoster(int branchId, DateOnly day);
}