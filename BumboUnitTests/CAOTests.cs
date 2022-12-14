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

        [Test, Description("the employee (15) has 4 hours of school but also 6 hours of work")]
        public void FourHoursWorkSixHoursSchoolYoungerThanSixteen()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
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
                    StartTime = timeOfTheDay.AddHours(-6),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay,
                EndTime = timeOfTheDay.AddHours(4),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test, Description("the employee (15) has 4 hours of school but also 4 hours of work")]
        public void FourHoursWorkFourHoursSchoolYoungerThanSixteen()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
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
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay,
                EndTime = timeOfTheDay.AddHours(4),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test, Description("the employee (15) has 0 hours of school but also 8 hours of work")]
        public void EightHoursWorkZeroHoursSchoolYoungerThanSixteen()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
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
                    StartTime = timeOfTheDay.AddHours(-8),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(0));
        }




        [Test, Description("the employee (15) has 0 hours of school but also 36 hours of work")]
        public void WorkWeekOfThirtyNineHoursYoungerThanSixteen()
        {
            var day = new DateOnly(2022, 1, 3);
            var timeOfTheDay = new DateTime(2022, 1, 3, 8, 0, 0);
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
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
            List<PlannedShift> plannedShifts = new List<PlannedShift>();
            for (int i = 0; i < 4; i++)
            {
                plannedShifts.Add(new PlannedShift
                {
                    Id = 1,
                    StartTime = timeOfTheDay.AddDays(i),
                    EndTime = timeOfTheDay.AddHours(9).AddDays(i),
                    Employee = employee,
                    Department = freshDepartment,
                    Branch = branch,
                    BranchId = branch.Id,
                    DepartmentId = freshDepartment.Id,
                    EmployeeId = employee.Id
                });
            }
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test, Description("the employee (15) has 0 hours of school but also 9 hours of work")]
        public void NineHoursWorkZeroHoursSchoolYoungerThanSixteen()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
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
                    StartTime = timeOfTheDay.AddHours(-9),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }




        //employee is now 17


        [Test, Description("the employee (17) has 4 hours of school but also 6 hours of work")]
        public void FourHoursWorkSixHoursSchoolSeventeenYearsOld()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = DateTime.Now.AddYears(-17).ToDateOnly(),
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
                    StartTime = timeOfTheDay.AddHours(-6),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay,
                EndTime = timeOfTheDay.AddHours(4),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test, Description("the employee (17) has 4 hours of school but also 4 hours of work")]
        public void FourHoursWorkFourHoursSchoolSeventeenYearsOld()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = DateTime.Now.AddYears(-17).ToDateOnly(),
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
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            var unavailableMoment = new UnavailableMoment
            {
                Id = 1,
                Employee = employee,
                EmployeeId = employee.Id,
                ReviewStatus = ReviewStatus.Approved,
                StartTime = timeOfTheDay,
                EndTime = timeOfTheDay.AddHours(4),
                Type = UnavailableMomentType.School
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment> { unavailableMoment });
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test, Description("the employee (17) has 0 hours of school but also 8 hours of work")]
        public void EightHoursWorkZeroHoursSchoolSeventeenYearsOld()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = DateTime.Now.AddYears(-17).ToDateOnly(),
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
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test, Description("the employee (17) has 0 hours of school but also 9 hours of work")]
        public void NineHoursWorkZeroHoursSchoolSeventeenYearsOld()
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
            var employee = new Employee
            {
                Id = "thisIsAnEmployeeID",
                FirstName = "hey",
                LastName = "die",
                DefaultBranch = branch,
                Birthdate = DateTime.Now.AddYears(-17).ToDateOnly(),
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
                    StartTime = timeOfTheDay.AddHours(-9),
                    EndTime = timeOfTheDay,
                    Employee = employee,
                    Department=freshDepartment,
                    Branch=branch,
                    BranchId=branch.Id,
                    DepartmentId=freshDepartment.Id,
                    EmployeeId=employee.Id
                }
            };
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByDay(employee.Id, day)).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.GetSchoolUnavailableMomentsByWeek(employee.Id, day.Year, timeOfTheDay.GetWeekNumber())).Returns(new List<UnavailableMoment>());
            _unavailableMomentsRepositoryMock.Setup(e => e.EmployeeSchoolWeek(employee.Id, 2022, 1)).Returns(true);
            _plannedShiftsRepositoryMock.Setup(e => e.GetPlannedShiftsInBetween(branch.Id, employee.Id, It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(plannedShifts);
            var result = _baseCAOService.VerifyPlannedShifts(plannedShifts, day);
            Assert.That(result.Count, Is.EqualTo(1));
        }



    }
}
