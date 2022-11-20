﻿using BumboData.Enums;
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

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);
            SeedBranches(modelBuilder);
            SeedDepartments(modelBuilder);
        }

        private void SeedDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = DepartmentType.CASSIERS.DepartmentId, DepartmentName = DepartmentType.CASSIERS.Name },
                new Department { Id = DepartmentType.FRESH.DepartmentId, DepartmentName = DepartmentType.FRESH.Name },
                new Department { Id = DepartmentType.FILLERS.DepartmentId, DepartmentName = DepartmentType.FILLERS.Name }
            ); ;
        }

        private void SeedBranches(ModelBuilder modelBuilder)
        {
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

        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = RoleType.ADMINISTRATOR.RoleId, Name = RoleType.ADMINISTRATOR.Name, NormalizedName = RoleType.ADMINISTRATOR.NormalizedName },
                new IdentityRole { Id = RoleType.MANAGER.RoleId, Name = RoleType.MANAGER.Name, NormalizedName = RoleType.MANAGER.NormalizedName },
                new IdentityRole { Id = RoleType.EMPLOYEE.RoleId, Name = RoleType.EMPLOYEE.Name, NormalizedName = RoleType.EMPLOYEE.NormalizedName });

        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<Employee>();
            modelBuilder.Entity<Employee>().HasData(
                // Admin
                new Employee
                {
                    Id = "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Jan",
                    LastName = "Piet",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = RoleType.ADMINISTRATOR.Name
                },
                // Manager
                new Employee
                {
                    Id = "3a792773-527d-4bb7-8319-6db070350d38",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Manager",
                    LastName = "Piet",
                    UserName = "manager",
                    NormalizedUserName = "MANAGER",
                    PasswordHash = hasher.HashPassword(null, "manager"),
                    Email = "manager@manager.com",
                    NormalizedEmail = "MANAGER@MANAGER.COM",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = RoleType.MANAGER.Name
                },
                // Medewerker
                new Employee
                {
                    Id = "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                    DefaultBranchId = 1,
                    Active = true,
                    Birthdate = new DateOnly(2003, 10, 2),
                    FirstName = "Medewerker",
                    LastName = "Piet",
                    UserName = "medewerker",
                    NormalizedUserName = "MEDEWERKER",
                    PasswordHash = hasher.HashPassword(null, "medewerker"),
                    Email = "medewerker@medewerker.com",
                    NormalizedEmail = "MEDEWERKER@MEDEWERKER.COM",
                    EmailConfirmed = true,
                    Postalcode = "1234AA",
                    Housenumber = "10",
                    Function = DepartmentType.FRESH.Name,
                });
            
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = RoleType.ADMINISTRATOR.RoleId,
                    UserId = "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                }, new IdentityUserRole<string>
                {
                    RoleId = RoleType.MANAGER.RoleId,
                    UserId = "3a792773-527d-4bb7-8319-6db070350d38",
                }, new IdentityUserRole<string>
                {
                    RoleId = RoleType.EMPLOYEE.RoleId,
                    UserId = "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
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
