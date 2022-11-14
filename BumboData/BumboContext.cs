using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BumboData
{
    public class BumboContext : DbContext
    {
        public BumboContext(DbContextOptions<BumboContext> options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentPrognosis> DepartmentPrognoses { get; set; }
        public DbSet<OpeningHoursOverride> OpeningHoursOverride { get; set; }
        public DbSet<PlannedShift> PlannedShifts { get; set; }
        public DbSet<Prognosis> Prognoses { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<StandardOpeningHours> StandardOpeningHours { get; set; }
        public DbSet<UnavailableMoment> UnavailableMoments { get; set; }
        public DbSet<WorkedShift> WorkedShifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setup allowed departments table
            modelBuilder.Entity<Department>()
                .HasMany(i => i.AllowedEmployees)
                .WithMany(i => i.AllowedDepartments)
                .UsingEntity(join => join.ToTable("Employee_allowed_Department"));

            // Manually set these since EF can't figure it out 
            modelBuilder.Entity<Employee>()
                .HasOne(i=>i.DefaultBranch)
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
