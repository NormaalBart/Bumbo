using CsvHelper.Configuration.Attributes;

namespace BumboServices.Surcharges.Models;

public class ExportCsvRowModel
{
    [Name("BID")] public string EmployeeId { get; set; }

    [Name("Naam")] public string EmployeeName { get; set; }

    [Name("Uren")] public double Hours { get; set; }

    [Name("Toeslag")] public string SurchargePercentage { get; set; }
}