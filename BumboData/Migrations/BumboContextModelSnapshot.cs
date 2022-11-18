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

                    b.Property<bool>("Inactive")
                        .HasColumnType("bit");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShelvingDistance")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Den Bosch",
                            HouseNumber = "2",
                            Inactive = false,
                            Name = "Bumbo v1",
                            ShelvingDistance = 100,
                            Street = "Onderwijsboulevard"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentName = "Kassa"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentName = "Vers"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentName = "Vullers"
                        });
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

                    b.ToTable("DepartmentPrognosis");
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
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DefaultBranchId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DefaultBranchId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                            AccessFailedCount = 0,
                            Active = true,
                            Birthdate = new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "d2bc5b52-cc83-4b23-ac33-9fbf9d081928",
                            DefaultBranchId = 1,
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            EmployeeSince = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            Function = "Administrator",
                            Housenumber = "10",
                            LastName = "Piet",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ4L9+5TFLii/nveacMNTlt/t+Si32hmab8uPCHAN3WmAjrHH4k82Dx6y7uSNQc2TQ==",
                            PhoneNumberConfirmed = false,
                            Postalcode = "1234AA",
                            SecurityStamp = "60437f7a-08bc-4117-b28d-c104bcf0d989",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "3a792773-527d-4bb7-8319-6db070350d38",
                            AccessFailedCount = 0,
                            Active = true,
                            Birthdate = new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "240b48a0-9c97-4965-94f8-46f98b5f13c7",
                            DefaultBranchId = 1,
                            Email = "manager@manager.com",
                            EmailConfirmed = true,
                            EmployeeSince = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Manager",
                            Function = "Manager",
                            Housenumber = "10",
                            LastName = "Piet",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@MANAGER.COM",
                            NormalizedUserName = "MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEGZW58C8SWGS33/dDIowV7417i0ii63v5x2y4hA7Cnu8m25oPCp5PDQAgTd+51jc5Q==",
                            PhoneNumberConfirmed = false,
                            Postalcode = "1234AA",
                            SecurityStamp = "2f7278f0-335e-4235-8824-4e41b0d344dc",
                            TwoFactorEnabled = false,
                            UserName = "manager"
                        },
                        new
                        {
                            Id = "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                            AccessFailedCount = 0,
                            Active = true,
                            Birthdate = new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "89979da9-45a3-4750-abd9-7ca8f361b9c6",
                            DefaultBranchId = 1,
                            Email = "medewerker@medewerker.com",
                            EmailConfirmed = true,
                            EmployeeSince = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Medewerker",
                            Function = "Vers",
                            Housenumber = "10",
                            LastName = "Piet",
                            LockoutEnabled = false,
                            NormalizedEmail = "MEDEWERKER@MEDEWERKER.COM",
                            NormalizedUserName = "MEDEWERKER",
                            PasswordHash = "AQAAAAEAACcQAAAAENOws7Fv9w9a8SJbDEYALCqYso+uqnLb/83znRkK/JeTe7wkTFCzLaCimW2WDCS1YA==",
                            PhoneNumberConfirmed = false,
                            Postalcode = "1234AA",
                            SecurityStamp = "52af6351-6b6d-46df-85b7-08f89a434b83",
                            TwoFactorEnabled = false,
                            UserName = "medewerker"
                        });
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
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("date");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("date");

                    b.HasKey("BranchId", "DayOfWeek");

                    b.ToTable("StandardOpeningHours");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 0,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 1,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 2,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 3,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 4,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 5,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            BranchId = 1,
                            DayOfWeek = 6,
                            CloseTime = new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local),
                            OpenTime = new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local)
                        });
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "administrator",
                            ConcurrencyStamp = "be3cb770-6ef7-4b6e-b895-8516d9eb5288",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "manager",
                            ConcurrencyStamp = "827fc57d-0fcc-46f3-88b5-aa455d7b41b6",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "employee",
                            ConcurrencyStamp = "b6794d3d-c43b-4db6-9913-8a946a0d9095",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                            RoleId = "administrator"
                        },
                        new
                        {
                            UserId = "3a792773-527d-4bb7-8319-6db070350d38",
                            RoleId = "manager"
                        },
                        new
                        {
                            UserId = "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                            RoleId = "employee"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                        .WithMany("DepartmentPrognosis")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BumboData.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
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
                    b.Navigation("DepartmentPrognosis");
                });
#pragma warning restore 612, 618
        }
    }
}
