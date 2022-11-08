using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmployed = table.Column<bool>(type: "bit", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    EmployeeJoinedCompany = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prognosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountOfCollies = table.Column<int>(type: "int", nullable: false),
                    AmountOfCustomers = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CassiereDepartment = table.Column<double>(type: "float", nullable: false),
                    FreshDepartment = table.Column<double>(type: "float", nullable: false),
                    StockersDepartment = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsEmployee",
                columns: table => new
                {
                    DepartmentsEmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsEmployee", x => new { x.DepartmentsEmployeeId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_DepartmentsEmployee_Departments_DepartmentsEmployeeId",
                        column: x => x.DepartmentsEmployeeId,
                        principalTable: "Departments",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentsEmployee_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnavailableMoment",
                columns: table => new
                {
                    UnavailableMomentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccountedForInWorkLoad = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnavailableMoment", x => x.UnavailableMomentId);
                    table.ForeignKey(
                        name: "FK_UnavailableMoment_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkedShift",
                columns: table => new
                {
                    WorkedShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedShift", x => x.WorkedShiftId);
                    table.ForeignKey(
                        name: "FK_WorkedShift_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlannedShift",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PrognosisId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedShift", x => x.ShiftId);
                    table.ForeignKey(
                        name: "FK_PlannedShift_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlannedShift_Prognosis_PrognosisId",
                        column: x => x.PrognosisId,
                        principalTable: "Prognosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsEmployee_EmployeesId",
                table: "DepartmentsEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShift_EmployeeId",
                table: "PlannedShift",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShift_PrognosisId",
                table: "PlannedShift",
                column: "PrognosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Prognosis_Date",
                table: "Prognosis",
                column: "Date",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnavailableMoment_EmployeeId",
                table: "UnavailableMoment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedShift_EmployeeId",
                table: "WorkedShift",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentsEmployee");

            migrationBuilder.DropTable(
                name: "PlannedShift");

            migrationBuilder.DropTable(
                name: "UnavailableMoment");

            migrationBuilder.DropTable(
                name: "WorkedShift");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Prognosis");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
