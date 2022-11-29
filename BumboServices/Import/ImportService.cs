using System.Globalization;
using AutoMapper;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboServices.Interface;
using CsvHelper;

namespace BumboServices.Import;

public class ImportService : IImportService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IWorkedShiftRepository _workedShiftRepository;
    private readonly IPlannedShiftsRepository _plannedShiftsRepository;
    private readonly IMapper _mapper;

    public ImportService(IEmployeeRepository employeeRepository, IWorkedShiftRepository workedShiftRepository,
        IMapper mapper, IPlannedShiftsRepository plannedShiftsRepository)
    {
        _employeeRepository = employeeRepository;
        _workedShiftRepository = workedShiftRepository;
        _mapper = mapper;
        _plannedShiftsRepository = plannedShiftsRepository;
    }

    public void ImportEmployees(Stream file, int branchId)
    {
        var csv = CsvFromStream(file);

        // Add date only converter
        csv.Context.TypeConverterCache.AddConverter<DateOnly>(new DateOnlyTypeConverter());

        var mappedEmployees = _mapper.Map<List<Employee>>(csv.GetRecords<EmployeeCsvModel>());

        // Add branch and set as active employee
        mappedEmployees.ForEach(e =>
        {
            e.Active = true;
            e.DefaultBranchId = branchId;
        });

        _employeeRepository.Import(mappedEmployees);
    }

    public void ImportClockEvents(Stream file, int branchId)
    {
        var csv = CsvFromStream(file);

        var mappedModels = _mapper.Map<List<WorkedShift>>(csv.GetRecords<WorkedShiftCsvModel>());

        // Set all models as approved and set branch id
        mappedModels.ForEach(m =>
        {
            m.Approved = true;
            m.BranchId = branchId;
        });
        
        // Uncomment to import as planned shifts, instead of workedshifts.
        // TODO: Create UI for switching between
        /*var plannedShifts = mappedModels.Select(s => new PlannedShift()
        {
            StartTime = s.StartTime,
            EndTime = (DateTime) s.EndTime,
            DepartmentId = 1,
            EmployeeId = s.EmployeeId,
            BranchId = s.BranchId
        }).ToList();

        _plannedShiftsRepository.Import(plannedShifts);*/

        _workedShiftRepository.Import(mappedModels);
    }

    private CsvReader CsvFromStream(Stream s)
    {
        return new CsvReader(new StreamReader(s), CultureInfo.InvariantCulture);
    }
}