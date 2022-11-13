using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerKey = table.Column<int>(type: "int", nullable: true),
                    ShelvingDistance = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DefaultBranchKey = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_DefaultBranchKey",
                        column: x => x.DefaultBranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHoursOverride",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false),
                    OpenTime = table.Column<DateTime>(type: "date", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHoursOverride", x => x.Date);
                    table.ForeignKey(
                        name: "FK_OpeningHoursOverride_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prognoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false),
                    ColiCount = table.Column<int>(type: "int", nullable: false),
                    CustomerCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prognoses_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StandardOpeningHours",
                columns: table => new
                {
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false),
                    OpenTime = table.Column<DateTime>(type: "date", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardOpeningHours", x => x.DayOfWeek);
                    table.ForeignKey(
                        name: "FK_StandardOpeningHours_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Standards_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_allowed_Department",
                columns: table => new
                {
                    AllowedDepartmentsKey = table.Column<int>(type: "int", nullable: false),
                    AllowedEmployeesKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_allowed_Department", x => new { x.AllowedDepartmentsKey, x.AllowedEmployeesKey });
                    table.ForeignKey(
                        name: "FK_Employee_allowed_Department_Departments_AllowedDepartmentsKey",
                        column: x => x.AllowedDepartmentsKey,
                        principalTable: "Departments",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_allowed_Department_Employees_AllowedEmployeesKey",
                        column: x => x.AllowedEmployeesKey,
                        principalTable: "Employees",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlannedShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeKey = table.Column<int>(type: "int", nullable: false),
                    DepartmentKey = table.Column<int>(type: "int", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedShifts_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannedShifts_Departments_DepartmentKey",
                        column: x => x.DepartmentKey,
                        principalTable: "Departments",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannedShifts_Employees_EmployeeKey",
                        column: x => x.EmployeeKey,
                        principalTable: "Employees",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnavailableMoments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeKey = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnavailableMoments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnavailableMoments_Employees_EmployeeKey",
                        column: x => x.EmployeeKey,
                        principalTable: "Employees",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkedShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeKey = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    BranchKey = table.Column<int>(type: "int", nullable: false),
                    Sick = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedShifts_Branches_BranchKey",
                        column: x => x.BranchKey,
                        principalTable: "Branches",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkedShifts_Employees_EmployeeKey",
                        column: x => x.EmployeeKey,
                        principalTable: "Employees",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentPrognoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentKey = table.Column<int>(type: "int", nullable: false),
                    PrognosisId = table.Column<int>(type: "int", nullable: false),
                    RequiredEmployees = table.Column<int>(type: "int", nullable: false),
                    RequiredHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentPrognoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentPrognoses_Departments_DepartmentKey",
                        column: x => x.DepartmentKey,
                        principalTable: "Departments",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentPrognoses_Prognoses_PrognosisId",
                        column: x => x.PrognosisId,
                        principalTable: "Prognoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ManagerKey",
                table: "Branches",
                column: "ManagerKey");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPrognoses_DepartmentKey",
                table: "DepartmentPrognoses",
                column: "DepartmentKey");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPrognoses_PrognosisId",
                table: "DepartmentPrognoses",
                column: "PrognosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_allowed_Department_AllowedEmployeesKey",
                table: "Employee_allowed_Department",
                column: "AllowedEmployeesKey");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DefaultBranchKey",
                table: "Employees",
                column: "DefaultBranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHoursOverride_BranchKey",
                table: "OpeningHoursOverride",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShifts_BranchKey",
                table: "PlannedShifts",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShifts_DepartmentKey",
                table: "PlannedShifts",
                column: "DepartmentKey");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShifts_EmployeeKey",
                table: "PlannedShifts",
                column: "EmployeeKey");

            migrationBuilder.CreateIndex(
                name: "IX_Prognoses_BranchKey",
                table: "Prognoses",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_StandardOpeningHours_BranchKey",
                table: "StandardOpeningHours",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_Standards_BranchKey",
                table: "Standards",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_UnavailableMoments_EmployeeKey",
                table: "UnavailableMoments",
                column: "EmployeeKey");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedShifts_BranchKey",
                table: "WorkedShifts",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedShifts_EmployeeKey",
                table: "WorkedShifts",
                column: "EmployeeKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Employees_ManagerKey",
                table: "Branches",
                column: "ManagerKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Employees_ManagerKey",
                table: "Branches");

            migrationBuilder.DropTable(
                name: "DepartmentPrognoses");

            migrationBuilder.DropTable(
                name: "Employee_allowed_Department");

            migrationBuilder.DropTable(
                name: "OpeningHoursOverride");

            migrationBuilder.DropTable(
                name: "PlannedShifts");

            migrationBuilder.DropTable(
                name: "StandardOpeningHours");

            migrationBuilder.DropTable(
                name: "Standards");

            migrationBuilder.DropTable(
                name: "UnavailableMoments");

            migrationBuilder.DropTable(
                name: "WorkedShifts");

            migrationBuilder.DropTable(
                name: "Prognoses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
