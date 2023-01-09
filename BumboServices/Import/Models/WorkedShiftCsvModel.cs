using CsvHelper.Configuration.Attributes;

namespace BumboServices.Import;

public class WorkedShiftCsvModel
{
    [Name("BID")] public string EmployeeId { get; set; }

    [Name("Date")] public DateTime Date { get; set; }

    [Name("Clock in")] public TimeOnly StartTime { get; set; }

    [Name("Clock out")] public TimeOnly EndTime { get; set; }
}