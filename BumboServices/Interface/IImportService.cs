namespace BumboServices.Interface;

public interface IImportService
{
    public void ImportEmployees(Stream file, int branchId);

    public void ImportClockEvents(Stream file, int branchId);
}