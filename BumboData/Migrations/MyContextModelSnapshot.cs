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
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BumboData.Models.Departments", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BumboData.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployeeJoinedCompany")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsEmployed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BumboData.Models.PlannedShift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrognosisId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShiftId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PrognosisId");

                    b.ToTable("PlannedShift");
                });

            modelBuilder.Entity("BumboData.Models.PrognosisDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfCollies")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfCustomers")
                        .HasColumnType("int");

                    b.Property<double>("CassiereDepartment")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("FreshDepartment")
                        .HasColumnType("float");

                    b.Property<double>("StockersDepartment")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Date")
                        .IsUnique();

                    b.ToTable("Prognosis");
                });

            modelBuilder.Entity("BumboData.Models.UnavailableMoment", b =>
                {
                    b.Property<int>("UnavailableMomentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnavailableMomentId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAccountedForInWorkLoad")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("UnavailableMomentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("UnavailableMoment");
                });

            modelBuilder.Entity("BumboData.Models.WorkedShift", b =>
                {
                    b.Property<int>("WorkedShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkedShiftId"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkedShiftId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkedShift");
                });

            modelBuilder.Entity("DepartmentsEmployee", b =>
                {
                    b.Property<int>("DepartmentsEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsEmployeeId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("DepartmentsEmployee");
                });

            modelBuilder.Entity("BumboData.Models.PlannedShift", b =>
                {
                    b.HasOne("BumboData.Models.Employee", "Employee")
                        .WithMany("PlannedShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BumboData.Models.PrognosisDay", "PrognosisDay")
                        .WithMany("PlannedShiftsOnDay")
                        .HasForeignKey("PrognosisId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("PrognosisDay");
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
                    b.HasOne("BumboData.Models.Employee", "Employee")
                        .WithMany("WorkedShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DepartmentsEmployee", b =>
                {
                    b.HasOne("BumboData.Models.Departments", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BumboData.Models.Employee", b =>
                {
                    b.Navigation("PlannedShifts");

                    b.Navigation("UnavailableMoments");

                    b.Navigation("WorkedShifts");
                });

            modelBuilder.Entity("BumboData.Models.PrognosisDay", b =>
                {
                    b.Navigation("PlannedShiftsOnDay");
                });
#pragma warning restore 612, 618
        }
    }
}
