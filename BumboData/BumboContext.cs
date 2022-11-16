using BumboData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BumboData
{
    public class BumboContext : IdentityDbContext<Employee, IdentityRole, string>
    {
        public BumboContext(DbContextOptions<BumboContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentPrognosis> DepartmentPrognosis { get; set; }
        public DbSet<OpeningHoursOverride> OpeningHoursOverride { get; set; }
        public DbSet<PlannedShift> PlannedShifts { get; set; }
        public DbSet<Prognosis> Prognoses { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<StandardOpeningHours> StandardOpeningHours { get; set; }
        public DbSet<UnavailableMoment> UnavailableMoments { get; set; }
        public DbSet<WorkedShift> WorkedShifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Setup allowed departments table
            modelBuilder.Entity<Department>()
                .HasMany(i => i.AllowedEmployees)
                .WithMany(i => i.AllowedDepartments)
                .UsingEntity(join => join.ToTable("Employee_allowed_Department"));

            // Manually set these since EF can't figure it out 
            modelBuilder.Entity<Employee>()

                .HasOne(i => i.DefaultBranch)
                .WithMany(i => i.DefaultEmployees);

            modelBuilder.Entity<Branch>()
                .HasOne(i => i.Manager)
                .WithMany(i => i.ManagedBranches);

            // Disable some cascade deletes, otherwise multiple cascade paths are created

            // When deleting an employee that was a branch manager, don't delete the branch too.
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ManagedBranches)
                .WithOne(e => e.Manager)
                .OnDelete(DeleteBehavior.Restrict);

            // By deleting a branch, do not also delete all employees
            modelBuilder.Entity<Branch>()
                .HasMany(e => e.DefaultEmployees)
                .WithOne(e => e.DefaultBranch)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StandardOpeningHours>().HasKey(e => new { e.BranchId, e.DayOfWeek });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Id = "2", Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Id = "3", Name = "Medewerker", NormalizedName = "MEDEWERKER" });

            modelBuilder.Entity<Branch>().HasData(
                new Branch
                {
                    Id = 1,
                    Name = "Bumbo v1",
                    ShelvingDistance = 100,
                    City = "Den Bosch",
                    HouseNumber = "2",
                    Street = "Onderwijsboulevard"
                });

            modelBuilder.Entity<StandardOpeningHours>().HasData(
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Sunday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Monday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Tuesday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Wednesday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Thursday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Friday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) },
                new StandardOpeningHours { BranchId = 1, DayOfWeek = DayOfWeek.Saturday, OpenTime = new TimeOnly(8, 00), CloseTime = new TimeOnly(20, 00) });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Kassa" },
                new Department { Id = 2, DepartmentName = "Vers" },
                new Department { Id = 3, DepartmentName = "Vullers" }
                );

            var hasher = new PasswordHasher<Employee>();
            modelBuilder.Entity<Employee>().HasData(
                // Admin
                new Employee
                {
                    Id = "1",
                    Key = "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Jan",
                    LastName = "Piet",
                    UserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    Email = "admin@admin.com",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = "Administrator"
                },
                // Manager
                new Employee
                {
                    Id = "2",
                    Key = "3a792773-527d-4bb7-8319-6db070350d38",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Manager",
                    LastName = "Piet",
                    UserName = "manager",
                    PasswordHash = hasher.HashPassword(null, "manager"),
                    Email = "manager@manager.com",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = "Manager"
                },
                // Medewerker
                new Employee
                {
                    Id = "3",
                    Key = "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Medewerker",
                    LastName = "Piet",
                    UserName = "medewerker",
                    PasswordHash = hasher.HashPassword(null, "medewerker"),
                    Email = "medewerker@medewerker.com",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = "Vuller"
                }); 

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1",
                }, new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2",
                }, new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "3",
                });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>()
                .HaveColumnType("date");
        }

        /// <summary>
        /// Converts <see cref="DateOnly" /> to <see cref="DateTime"/> and vice versa.
        /// </summary>
        private class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
        {
            /// <summary>
            /// Creates a new instance of this converter.
            /// </summary>
            public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
            { }
        }

        private class TimeOnlyConverter : ValueConverter<TimeOnly, DateTime>
        {
            /// <summary>
            /// Creates a new instance of this converter.
            /// </summary>
            public TimeOnlyConverter() : base(
                d => DateTime.Today.Add(d.ToTimeSpan()),
                d => TimeOnly.FromDateTime(d))
            { }
        }
    }
}
