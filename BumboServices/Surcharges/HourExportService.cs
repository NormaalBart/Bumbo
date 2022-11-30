using System.Globalization;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using BumboServices.Surcharges.Models;
using BumboServices.Surcharges.SurchargeRules;
using BumboServices.Surcharges.SurchargeRules.Rules;
using BumboServices.Utils;
using CsvHelper;

namespace BumboServices;

public class HourExportService : IHourExportService
{
    private readonly IWorkedShiftRepository _workedShiftRepository;
    private readonly List<ISurchargeRule> _useSurchargesRules;

    public HourExportService(IWorkedShiftRepository workedShiftRepository)
    {
        _workedShiftRepository = workedShiftRepository;

        // Set rules that the hour export service uses.
        _useSurchargesRules = new List<ISurchargeRule>()
        {
            // Op zon- en feestdagen 100% ( ook voor hulpkrachten)
            new SunOrHolidaySurchargeRule(),
            // Op zaterdag tussen 18.00 en 24.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(18, 00),
                new TimeOnly(23, 59),
                SurchargeType.Surcharge50,
                i => i.StartTime.DayOfWeek == DayOfWeek.Saturday),
            // tussen 21.00 en 24.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(21, 00),
                new TimeOnly(23, 59),
                SurchargeType.Surcharge50),
            // tussen 20.00 en 21.00 uur 33 1/3%
            new BasicSurchargeRule(
                new TimeOnly(20, 00),
                new TimeOnly(21, 00),
                SurchargeType.Surcharge33),
            // tussen 00.00 en 06.00 uur 50%
            new BasicSurchargeRule(
                new TimeOnly(00, 00),
                new TimeOnly(6, 00),
                SurchargeType.Surcharge50)
        };
    }

    /*
     * Generates the total workes hours, sick time and surcharges based on the given list of worked shifts.
     */
    public HourExportModel WorkedShiftsToExportOverview(List<WorkedShift> shifts)
    {
        // Only allow shifts in the same month, and only approved shifts.
        var first = shifts.FirstOrDefault();
        shifts = shifts.Where(s => s.StartTime.Year == first?.StartTime.Year &&
                                   s.StartTime.Month == first?.StartTime.Month &&
                                   s.Approved).ToList();

        var dict = new Dictionary<SurchargeType, TimeSpan>();

        // Add all with zero value
        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
        {
            dict[surchargeType] = TimeSpan.Zero;
        }

        // Add actual surcharge values for each rule
        if (shifts.Count != 0)
        {
            _useSurchargesRules.ForEach(s =>
            {
                var dictAdd = s.CalculateSurcharges(shifts);
                foreach (var value in dictAdd.Keys)
                {
                    dict[value] = dict.GetValueOrDefault(value) + dictAdd[value];
                }
            });
        }

        var hoursSick = shifts.Where(i => i.Sick)
            .SumTimeSpan(i => (i.EndTime ?? i.StartTime) - i.StartTime);

        dict[SurchargeType.Sick] = hoursSick;

        return new HourExportModel()
        {
            // Sick hours don't count as worked hours, since they are factored in surcharges already.
            HoursWorked = shifts.SumTimeSpan(i => (i.EndTime ?? i.StartTime) - i.StartTime) - hoursSick,
            Surcharges = dict
        };
    }

    /*
     * Generates an export csv for the given employee and hourexport model list.
     */
    public Byte[] CsvExportForMonth(int branchId, DateTime month)
    {
        var workedShiftsInMonth =
            _workedShiftRepository.GetWorkedShiftsInMonth(branchId, month.Year, month.Month);

        var exportModels = workedShiftsInMonth.GroupBy(s => s.Employee)
            .Select(s => (s.Key, WorkedShiftsToExportOverview(s.ToList())))
            .Where(s=>s.Item2.HoursWorked.Ticks > 0).ToList();

        var ms = new MemoryStream();
        using (var writer = new StreamWriter(ms))
        {
            writer.WriteLine("sep=,"); // make Excel use comma as field separator
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteField("WeekNr: " + month.GetWeekNumber() + " : " + month.Year);
                csv.NextRecord();
            
                csv.WriteHeader<ExportCsvRowModel>();
                csv.NextRecord();

                csv.WriteRecords(exportModels.SelectMany(m => ExportRowsFromHourExportModel(m.Key, m.Item2)));
            }
        }

        return ms.ToArray();
    }

    private List<ExportCsvRowModel> ExportRowsFromHourExportModel(Employee employee, HourExportModel model)
    {
        var list = new List<ExportCsvRowModel>();
        list.Add(new ExportCsvRowModel()
        {
            EmployeeId = employee.Id,
            EmployeeName = employee.FullName(),
            Hours = Math.Round(model.HoursWorked.TotalHours + 
                                (model.Surcharges[SurchargeType.Sick] / 100 * SurchargeType.Sick.SurchargePercentage()).TotalHours, 2, MidpointRounding.AwayFromZero),
            SurchargePercentage = "0%"
        });

        // Only add rows that have more than the value of 0
        list.AddRange(model.Surcharges
                // Don't include sick as seperate entry in export.
            .Where(s=>s.Value.Ticks != 0 && s.Key != SurchargeType.Sick)
            .Select(surcharge => new ExportCsvRowModel()
        {
            EmployeeId = employee.Id,
            EmployeeName = employee.FullName(),
            // Round hours to 2 decimals.
            Hours = Math.Round(surcharge.Value.TotalHours, 2, MidpointRounding.AwayFromZero),
            SurchargePercentage = surcharge.Key.SurchargePercentage() + "%"
        }));

        return list;
    }
}