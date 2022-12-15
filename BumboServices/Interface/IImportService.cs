using BumboServices.Import;

namespace BumboServices.Interface;

public interface IImportService
{
    public Task ImportEmployees(Stream file, int branchId);

    public void ImportClockEvents(Stream file, int branchId, ImportClockEventsType importType);
}