using BumboServices;
using BumboServices.Surcharges.Models;
using BumboServices.Surcharges.SurchargeRules;
using Newtonsoft.Json;

namespace BumboUnitTests;

internal class SurchargesTests
{
    private readonly Mock<IWorkedShiftRepository> _workedShiftRepository = new();
    private HourExportService _hourExportService;

    [SetUp]
    public void Setup()
    {
        _hourExportService = new HourExportService(_workedShiftRepository.Object);
    }

    [Test]
    public void WorkedShiftsToExportOverview_HolidaySurchargeOnHoliday()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 01, 17, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 01, 9, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 8, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Holiday] = new TimeSpan(0, 8, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_HolidaySurchargeOnSunday()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 03, 17, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 03, 9, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 8, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Holiday] = new TimeSpan(0, 8, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_NoSurcharge()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 02, 17, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 02, 9, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 8, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_50SurChargeOnSaturdayBetween1800And2359()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 02, 23, 59, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 02, 18, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 5, 59, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 8, 58, 0, 0);
        testData.Surcharges[SurchargeType.Surcharge33] = new TimeSpan(0, 1, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_Double50SurChargeBetween2100And2400OnSaturdayBetween1800And2400()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 02, 23, 59, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 02, 18, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 5, 59, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 8, 58, 0, 0);
        testData.Surcharges[SurchargeType.Surcharge33] = new TimeSpan(0, 1, 00, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_50SurChargeBetween2100And2359()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 05, 23, 59, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 05, 21, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 2, 59, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 2, 59, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_33SurChargeBetween2000And2100()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 05, 21, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 05, 17, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 4, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge33] = new TimeSpan(0, 1, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_50SurChargeBetween0000And0600()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 05, 06, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 05, 00, 00, 0)
        });

        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 6, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 6, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_NoData()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 0, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 0, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_WholeDay()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 08, 23, 59, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 08, 00, 00, 0)
        });
        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(0, 23, 59, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 8, 59, 0, 0);
        testData.Surcharges[SurchargeType.Surcharge33] = new TimeSpan(0, 1, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }

    [Test]
    public void WorkedShiftsToExportOverview_TwoDays()
    {
        //Arange
        var shifts = new List<WorkedShift>();
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 08, 22, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 08, 6, 00, 0)
        });
        shifts.Add(new WorkedShift
        {
            Id = 1, Employee = new Employee(), EmployeeId = "1", Approved = true, Branch = new Branch(), BranchId = 1,
            EndTime = new DateTime(2021, 01, 09, 22, 00, 0), Sick = false,
            StartTime = new DateTime(2021, 01, 09, 6, 00, 0)
        });
        //Act
        var result = _hourExportService.WorkedShiftsToExportOverview(shifts);
        var testData = new HourExportModel
            {HoursWorked = new TimeSpan(1, 08, 0, 0, 0), Surcharges = new Dictionary<SurchargeType, TimeSpan>()};

        foreach (var surchargeType in Enum.GetValues<SurchargeType>())
            testData.Surcharges[surchargeType] = TimeSpan.Zero;
        testData.Surcharges[SurchargeType.Surcharge50] = new TimeSpan(0, 6, 0, 0, 0);
        testData.Surcharges[SurchargeType.Surcharge33] = new TimeSpan(0, 2, 0, 0, 0);
        //Assert
        Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(result));
    }
}