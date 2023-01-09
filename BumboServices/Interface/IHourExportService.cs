using BumboData.Models;
using BumboServices.Surcharges.Models;

namespace BumboServices.Interface;

public interface IHourExportService
{
    public HourExportModel WorkedShiftsToExportOverview(List<WorkedShift> shifts);
    public byte[] CsvExportForMonth(int branchId, DateTime month);
}