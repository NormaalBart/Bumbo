using BumboData.Enums;
using BumboRepositories.Utils;
using BumboServices.CAO;

namespace BumboUnitTests
{
    public class CAOTests
    {
        private BaseCAOService _baseCAOService;
        private readonly Mock<IUnavailableMomentsRepository> _unavailableMomentsRepositoryMock = new Mock<IUnavailableMomentsRepository>();
        private readonly Mock<IPlannedShiftsRepository> _plannedShiftsRepositoryMock = new Mock<IPlannedShiftsRepository>();

        [SetUp]
        public void Setup()
        {
            _baseCAOService = new DutchCAOService(_unavailableMomentsRepositoryMock.Object, _plannedShiftsRepositoryMock.Object);
        }

        [Test]
        public void Test1()
        {
            var day = new DateOnly(2022, 1, 2);
            var timeOfTheDay = new DateTime(2022, 1, 2, 13, 0, 0);
            var branch = new Branch
            {
                Id = 1,
                Name = "d",
                ShelvingDistance = 0,
                City = "d",
                HouseNumber = "3",
                Street = "ddd",
                Inactive = false
            };
            // employee is over 18 years old
            var employee = new Employee
            {
                Id = "1",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = new DateOnly(1990, 12, 3),
                Active = true,
                EmployeeSince = new DateOnly(2014, 2, 4),
                Postalcode = "1",
                Housenumber = "1"
            };
            var freshDepartment = new Department
            {
                Id = 2,
                DepartmentName = "vers"
            };
            List<PlannedShift> plannedShifts = new List<PlannedShift>
            {

                new PlannedShift
                {
                    Id = 1,
                    StartTime = timeOfTheDay,
                    EndTime = timeOfTheDay.AddHours(2),
                    Employee = employee,
                    Department=freshDepartment
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay.AddHours(-3),
                EndTime = timeOfTheDay.AddHours(-1),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(false);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.True(result.Count() == 0);
        }

        [Test]
        public void ShiftTooLongAdult()
        {
            var day = new DateOnly(2022, 1, 2);
            var timeOfTheDay = new DateTime(2022, 1, 2, 13, 0, 0);
            var branch = new Branch
            {
                Id = 1,
                Name = "d",
                ShelvingDistance = 0,
                City = "d",
                HouseNumber = "3",
                Street = "ddd",
                Inactive = false
            };
            // employee is over 18 years old
            var employee = new Employee
            {
                Id = "1",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = new DateOnly(1990, 12, 3),
                Active = true,
                EmployeeSince = new DateOnly(2014, 2, 4),
                Postalcode = "1",
                Housenumber = "1"
            };
            var freshDepartment = new Department
            {
                Id = 2,
                DepartmentName = "vers"
            };
            List<PlannedShift> plannedShifts = new List<PlannedShift>
            {
                new PlannedShift
                {
                    Id = 1,
                    StartTime = timeOfTheDay.AddHours(-8),
                    EndTime = timeOfTheDay.AddHours(5),
                    Employee = employee,
                    Department=freshDepartment
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay.AddHours(-3),
                EndTime = timeOfTheDay.AddHours(-1),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(false);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void ShiftTooLongYoungerThan16()
        {
            var day = new DateOnly(2022, 1, 2);
            var timeOfTheDay = new DateTime(2022, 1, 2, 13, 0, 0);
            var branch = new Branch
            {
                Id = 1,
                Name = "d",
                ShelvingDistance = 0,
                City = "d",
                HouseNumber = "3",
                Street = "ddd",
                Inactive = false
            };
            // employee is over 18 years old
            var employee = new Employee
            {
                Id = "1",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = DateTime.Now.AddYears(-15).ToDateOnly(),
                Active = true,
                EmployeeSince = new DateOnly(2014, 2, 4),
                Postalcode = "1",
                Housenumber = "1"
            };
            var freshDepartment = new Department
            {
                Id = 2,
                DepartmentName = "vers"
            };
            List<PlannedShift> plannedShifts = new List<PlannedShift>
            {
                new PlannedShift
                {
                    Id = 1,
                    StartTime = timeOfTheDay.AddHours(-4),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay.AddHours(-3),
                EndTime = timeOfTheDay.AddHours(-1),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(false);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }
    }
}
