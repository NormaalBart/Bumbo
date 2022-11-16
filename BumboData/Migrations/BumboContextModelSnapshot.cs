﻿// <auto-generated />
using System;
using BumboData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BumboData.Migrations
{
    [DbContext(typeof(BumboContext))]
    partial class BumboContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BumboData.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ShelvingDistance")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("BumboData.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BumboData.Models.DepartmentPrognosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("PrognosisId")
                        .HasColumnType("int");

                    b.Property<int>("RequiredEmployees")
                        .HasColumnType("int");

                    b.Property<int>("RequiredHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PrognosisId");

                    b.ToTable("DepartmentPrognoses");
                });

            modelBuilder.Entity("BumboData.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DefaultBranchId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EmployeeSince")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Housenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Postalcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DefaultBranchId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BumboData.Models.OpeningHoursOverride", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("date");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("date");

                    b.HasKey("Date");

                    b.HasIndex("BranchId");

                    b.ToTable("OpeningHoursOverride");
                });

            modelBuilder.Entity("BumboData.Models.PlannedShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PlannedShifts");
                });

            modelBuilder.Entity("BumboData.Models.Prognosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ColiCount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Prognoses");
                });

            modelBuilder.Entity("BumboData.Models.Standard", b =>
                {
                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Key");

                    b.HasIndex("BranchId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("BumboData.Models.StandardOpeningHours", b =>
                {
                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("date");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("date");

                    b.HasKey("DayOfWeek");

                    b.HasIndex("BranchId");

                    b.ToTable("StandardOpeningHours");
                });

            modelBuilder.Entity("BumboData.Models.UnavailableMoment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("UnavailableMoments");
                });

            modelBuilder.Entity("BumboData.Models.WorkedShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Sick")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkedShifts");
                });

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.Property<int>("AllowedDepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("AllowedEmployeesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AllowedDepartmentsId", "AllowedEmployeesId");

                    b.HasIndex("AllowedEmployeesId");

                    b.ToTable("Employee_allowed_Department", (string)null);
                });

            modelBuilder.Entity("BumboData.Models.Branch", b =>
                {
                    b.HasOne("BumboData.Models.Employee", "Manager")
                        .WithMany("ManagedBranches")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("BumboData.Models.DepartmentPrognosis", b =>
                {
                    b.HasOne("BumboData.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Prognosis", "Prognosis")
                        .WithMany("DepartmentPrognoses")
                        .HasForeignKey("PrognosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Prognosis");
                });

            modelBuilder.Entity("BumboData.Models.Employee", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "DefaultBranch")
                        .WithMany("DefaultEmployees")
                        .HasForeignKey("DefaultBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DefaultBranch");
                });

            modelBuilder.Entity("BumboData.Models.OpeningHoursOverride", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany("OpeningHoursOverrides")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BumboData.Models.PlannedShift", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Employee", "Employee")
                        .WithMany("PlannedShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Department");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BumboData.Models.Prognosis", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany("Prognoses")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BumboData.Models.Standard", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany("Standards")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BumboData.Models.StandardOpeningHours", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany("StandardOpeningHours")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("BumboData.Models.UnavailableMoment", b =>
                {
                    b.HasOne("BumboData.Models.Employee", "Employee")
                        .WithMany("UnavailableMoments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BumboData.Models.WorkedShift", b =>
                {
                    b.HasOne("BumboData.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Employee", "Employee")
                        .WithMany("WorkedShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.HasOne("BumboData.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("AllowedDepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("AllowedEmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BumboData.Models.Branch", b =>
                {
                    b.Navigation("DefaultEmployees");

                    b.Navigation("OpeningHoursOverrides");

                    b.Navigation("Prognoses");

                    b.Navigation("StandardOpeningHours");

                    b.Navigation("Standards");
                });

            modelBuilder.Entity("BumboData.Models.Employee", b =>
                {
                    b.Navigation("ManagedBranches");

                    b.Navigation("PlannedShifts");

                    b.Navigation("UnavailableMoments");

                    b.Navigation("WorkedShifts");
                });

            modelBuilder.Entity("BumboData.Models.Prognosis", b =>
                {
                    b.Navigation("DepartmentPrognoses");
                });
#pragma warning restore 612, 618
        }
    }
}
