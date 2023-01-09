using System.Globalization;
using AutoMapper;
using BumboData.Enums;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboServices.Interface;
using CsvHelper;
using Microsoft.AspNetCore.Identity;

namespace BumboServices.Import;

public class ImportService : IImportService
{
    private readonly IDepartmentsRepository _departmentsRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IPlannedShiftsRepository _plannedShiftsRepository;
    private readonly UserManager<Employee> _userManager;
    private readonly IWorkedShiftRepository _workedShiftRepository;

    public ImportService(IEmployeeRepository employeeRepository, IWorkedShiftRepository workedShiftRepository,
        IMapper mapper, IPlannedShiftsRepository plannedShiftsRepository, UserManager<Employee> userManager,
        IDepartmentsRepository departmentsRepository)
    {
        _employeeRepository = employeeRepository;
        _workedShiftRepository = workedShiftRepository;
        _mapper = mapper;
        _plannedShiftsRepository = plannedShiftsRepository;
        _userManager = userManager;
        _departmentsRepository = departmentsRepository;
    }

    public async Task ImportEmployees(Stream file, int branchId)
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

        // Add employee role by default
        foreach (var mappedEmployee in mappedEmployees)
        {
            await _userManager.AddToRoleAsync(mappedEmployee, RoleType.EMPLOYEE.Name);

            // Add all departments to employee
            var usr = _employeeRepository.Get(mappedEmployee.Id);

            foreach (var department in _departmentsRepository.GetList()) usr.AllowedDepartments.Add(department);

            _employeeRepository.Update(usr);
        }
    }

    public void ImportClockEvents(Stream file, int branchId, ImportClockEventsType type)
    {
        var csv = CsvFromStream(file);

        var mappedModels = _mapper.Map<List<WorkedShift>>(csv.GetRecords<WorkedShiftCsvModel>());

        // Set all models as approved and set branch id
        mappedModels.ForEach(m =>
        {
            m.Approved = true;
            m.BranchId = branchId;
        });

        if (type == ImportClockEventsType.Planned)
        {
            var plannedShifts = mappedModels.Select(s => new PlannedShift
            {
                StartTime = s.StartTime,
                EndTime = (DateTime) s.EndTime,
                DepartmentId = 1,
                EmployeeId = s.EmployeeId,
                BranchId = s.BranchId
            }).ToList();

            _plannedShiftsRepository.Import(plannedShifts);
        }
        else if (type == ImportClockEventsType.Worked)
        {
            _workedShiftRepository.Import(mappedModels);
        }
    }

    private CsvReader CsvFromStream(Stream s)
    {
        return new CsvReader(new StreamReader(s), CultureInfo.InvariantCulture);
    }
}