using BumboData.Enums;
using BumboServices.CAO.Rules;
using BumboServices.Interface;
using BumboServices.Roster;
using Microsoft.AspNetCore.Identity;

namespace BumboUnitTests;

public class RosterTests
{
    private readonly Mock<IBranchRepository> _branchRepositoryMock = new();
    private readonly Mock<IPlannedShiftsRepository> _plannedShiftsRepositoryMock = new();
    private readonly Mock<IEmployeeRepository> _employeeRepositoryMock = new();
    private readonly Mock<IUnavailableMomentsRepository> _unavailableMomentsRepositoryMock = new();
    private readonly Mock<IDepartmentsRepository> _departmentsRepositoryMock = new();
    private readonly Mock<IPrognosesService> _prognosesServiceMock = new();
    private readonly Mock<ICAOService> _caoService = new();
    private IRosterService _rosterService;

    private readonly Mock<UserManager<Employee>> _userManager =
        new(Mock.Of<IUserStore<Employee>>(), null, null, null, null, null, null, null, null);
    
    private static readonly DateOnly TestDate = new(2022, 12, 15);

    private static readonly Branch Branch = new()
    {
        Id = 1,
        Name = "Test"
    };

    private readonly List<Department> _departments = new()
    {
        new Department { Id = DepartmentType.Cassiers.DepartmentId, DepartmentName = DepartmentType.Cassiers.Name },
        new Department { Id = DepartmentType.Fresh.DepartmentId, DepartmentName = DepartmentType.Fresh.Name },
        new Department { Id = DepartmentType.Fillers.DepartmentId, DepartmentName = DepartmentType.Fillers.Name }
    };

    private readonly List<PlannedShift> _plannedShifts = new()
    {
        new PlannedShift()
        {
            BranchId = Branch.Id,
            EmployeeId = "test1",
            DepartmentId = DepartmentType.Cassiers.DepartmentId,
            StartTime = TestDate.ToDateTime(new TimeOnly(10, 00)),
            EndTime = TestDate.ToDateTime(new TimeOnly(18, 00))
        },
        new PlannedShift()
            {
            BranchId = Branch.Id,
            EmployeeId = "test2",
            DepartmentId = DepartmentType.Fresh.DepartmentId,
            StartTime = TestDate.ToDateTime(new TimeOnly(10, 00)),
            EndTime = TestDate.ToDateTime(new TimeOnly(18, 00))
        },
        new PlannedShift()
        {
            BranchId = Branch.Id,
            EmployeeId = "test3",
            DepartmentId = DepartmentType.Fillers.DepartmentId,
            StartTime = TestDate.ToDateTime(new TimeOnly(10, 00)),
            EndTime = TestDate.ToDateTime(new TimeOnly(18, 00))
        },
    };

    [SetUp]
    public void Setup()
    {
        _rosterService = new RosterService(_plannedShiftsRepositoryMock.Object, _employeeRepositoryMock.Object, _branchRepositoryMock.Object,
            _userManager.Object, _caoService.Object, _unavailableMomentsRepositoryMock.Object, _prognosesServiceMock.Object, _departmentsRepositoryMock.Object);
        
        // Base setup
        _branchRepositoryMock.Setup(b => b.Get(1)).Returns(Branch); 
        _plannedShiftsRepositoryMock.Setup(s => s.GetShiftsByMonth(Branch.Id, TestDate.Year, TestDate.Month))
            .Returns(_plannedShifts);
        _departmentsRepositoryMock.Setup(d => d.GetList()).Returns(_departments);
        _branchRepositoryMock.Setup(b=>b.GetOpenAndCloseTimes(Branch.Id, TestDate))
            .Returns((new TimeOnly(8, 00), new TimeOnly(20, 00)));
        _plannedShiftsRepositoryMock.Setup(s => s.GetAllShiftsWeek(Branch.Id, TestDate)).Returns(_plannedShifts);
        _caoService.Setup(c=>c.VerifyPlannedShifts(It.IsAny<List<PlannedShift>>(), TestDate))
            .Returns(new Dictionary<ICAORule, List<PlannedShift>>());
        
        // Setup prognises
        foreach (var department in _departments)
        {
            _prognosesServiceMock.Setup(s =>
                    s.GetByDepartment(department, TestDate.ToDateTime(TimeOnly.MinValue), Branch.Id))
                .Returns((1, 8));
        }
    }

    [Test]
    public async Task NoEmployeesFoundError()
    {
        // Setup
        _plannedShiftsRepositoryMock.Setup(s => s.GetShiftsByMonth(Branch.Id, TestDate.Year, TestDate.Month))
            .Returns(new List<PlannedShift>());
        
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.NoEmployees));
    }
    
    [Test]
    public async Task NoPrognoseFoundError()
    {
        // Setup
        _prognosesServiceMock.Setup(s =>
                s.GetByDepartment(It.IsAny<Department>(), TestDate.ToDateTime(TimeOnly.MinValue), Branch.Id))
            .Returns((-1, -1));
        
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.NoPrognoseFound));
    }
    
    [Test]
    public async Task TestAlreadyReachedPrognosisError()
    {
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate, _plannedShifts);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.AlreadyReachedPrognosis));
    }
    
    [Test]
    public async Task ClosedOnDayError()
    {
        // Setup
        _branchRepositoryMock.Setup(b=>b.GetOpenAndCloseTimes(Branch.Id, TestDate))
            .Returns((TimeOnly.MinValue, TimeOnly.MinValue));
        
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.ClosedOnDay));
    }
    
    [Test]
    public async Task TestCaoViolationsFound()
    {
        // Setup
        _caoService.Setup(c=>c.VerifyPlannedShifts(It.IsAny<List<PlannedShift>>(), TestDate))
            .Returns(new Dictionary<ICAORule, List<PlannedShift>>
            {
                { new MaxConsecutiveHours(6), _plannedShifts }
            });
        
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.CaoViolationsFound));
    }

    [Test]
    public async Task TestSuccessfulRosterIncomplete()
    {
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.Incomplete));
    }
    
    [Test]
    public async Task TestSuccessfulRosterSuccess()
    {
        // Setup
        var employees = new List<Employee>();
        for (var i = 0; i < 50; i++)
        {
            employees.Add(new Employee()
            {
                Id = $"test{i}",
                AllowedDepartments = _departments
            });
        }
        _employeeRepositoryMock.Setup(e=>e.GetAllEmployeesOfBranch(Branch.Id))
            .Returns(employees);
        _userManager.Setup(u => u.GetRolesAsync(It.IsAny<Employee>()))
            .Returns(Task.FromResult<IList<string>>(new List<string> { RoleType.EMPLOYEE.Name }));
        _unavailableMomentsRepositoryMock.Setup(u =>
            u.IsEmployeeAvailable(It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>(), true))
            .Returns(true);
        
        // Act
        var resp = await _rosterService.GenerateRoster(Branch.Id, TestDate);

        // Assert
        Assert.That(resp, Is.EqualTo(RosterCreationResponse.Success));
    }
}