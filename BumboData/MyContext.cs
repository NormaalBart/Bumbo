using BumboData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BumboData
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        // TODO Branches are not yet implemented
        //public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<PrognosisDay> Prognosis { get; set; }
        public DbSet<PlannedShift> PlannedShift { get; set; }
        public DbSet<UnavailableMoment> UnavailableMoment { get; set; }
        public DbSet<WorkedShift> WorkedShift { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Employee has many departments and set keys
            modelBuilder.Entity<Employee>()
                     .HasMany(e => e.Departments)
                     .WithMany(d => d.Employees);
                 

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PlannedShifts)
                .WithOne(p => p.Employee);

            modelBuilder.Entity<PrognosisDay>()
                .HasIndex(p => p.Date).IsUnique(true);


            modelBuilder.Entity<PlannedShift>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.PlannedShifts)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PlannedShift>()
                .HasOne(p => p.PrognosisDay)
                .WithMany(p => p.PlannedShiftsOnDay)
                .HasForeignKey(p => p.PrognosisId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<UnavailableMoment>()
                .HasOne(u => u.Employee)
                .WithMany(e => e.UnavailableMoments)
                .HasForeignKey(u => u.EmployeeId);
            
            modelBuilder.Entity<WorkedShift>()
                .HasOne(w => w.Employee)
                .WithMany(e => e.WorkedShifts)
                .HasForeignKey(w => w.EmployeeId);









        }

    }
}
