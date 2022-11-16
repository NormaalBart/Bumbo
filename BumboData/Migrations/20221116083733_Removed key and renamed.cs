using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Removedkeyandrenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Employees_ManagerKey",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_allowed_Department_Employees_AllowedEmployeesKey",
                table: "Employee_allowed_Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_DefaultBranchKey",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHoursOverride_Branches_BranchKey",
                table: "OpeningHoursOverride");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Branches_BranchKey",
                table: "PlannedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Employees_EmployeeKey",
                table: "PlannedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_Prognoses_Branches_BranchKey",
                table: "Prognoses");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchKey",
                table: "StandardOpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Standards_Branches_BranchKey",
                table: "Standards");

            migrationBuilder.DropForeignKey(
                name: "FK_UnavailableMoments_Employees_EmployeeKey",
                table: "UnavailableMoments");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkedShifts_Branches_BranchKey",
                table: "WorkedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkedShifts_Employees_EmployeeKey",
                table: "WorkedShifts");

            migrationBuilder.DropIndex(
                name: "IX_WorkedShifts_BranchKey",
                table: "WorkedShifts");

            migrationBuilder.DropIndex(
                name: "IX_UnavailableMoments_EmployeeKey",
                table: "UnavailableMoments");

            migrationBuilder.DropIndex(
                name: "IX_PlannedShifts_BranchKey",
                table: "PlannedShifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_allowed_Department",
                table: "Employee_allowed_Department");

            migrationBuilder.DropIndex(
                name: "IX_Employee_allowed_Department_AllowedEmployeesKey",
                table: "Employee_allowed_Department");

            migrationBuilder.DropIndex(
                name: "IX_Branches_ManagerKey",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "BranchKey",
                table: "WorkedShifts");

            migrationBuilder.DropColumn(
                name: "EmployeeKey",
                table: "UnavailableMoments");

            migrationBuilder.DropColumn(
                name: "BranchKey",
                table: "PlannedShifts");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AllowedEmployeesKey",
                table: "Employee_allowed_Department");

            migrationBuilder.DropColumn(
                name: "ManagerKey",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "EmployeeKey",
                table: "WorkedShifts",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkedShifts_EmployeeKey",
                table: "WorkedShifts",
                newName: "IX_WorkedShifts_BranchId");

            migrationBuilder.RenameColumn(
                name: "BranchKey",
                table: "Standards",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Standards_BranchKey",
                table: "Standards",
                newName: "IX_Standards_BranchId");

            migrationBuilder.RenameColumn(
                name: "BranchKey",
                table: "StandardOpeningHours",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_StandardOpeningHours_BranchKey",
                table: "StandardOpeningHours",
                newName: "IX_StandardOpeningHours_BranchId");

            migrationBuilder.RenameColumn(
                name: "BranchKey",
                table: "Prognoses",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Prognoses_BranchKey",
                table: "Prognoses",
                newName: "IX_Prognoses_BranchId");

            migrationBuilder.RenameColumn(
                name: "EmployeeKey",
                table: "PlannedShifts",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_PlannedShifts_EmployeeKey",
                table: "PlannedShifts",
                newName: "IX_PlannedShifts_BranchId");

            migrationBuilder.RenameColumn(
                name: "BranchKey",
                table: "OpeningHoursOverride",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_OpeningHoursOverride_BranchKey",
                table: "OpeningHoursOverride",
                newName: "IX_OpeningHoursOverride_BranchId");

            migrationBuilder.RenameColumn(
                name: "DefaultBranchKey",
                table: "Employees",
                newName: "DefaultBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DefaultBranchKey",
                table: "Employees",
                newName: "IX_Employees_DefaultBranchId");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Branches",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "WorkedShifts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "UnavailableMoments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "PlannedShifts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AllowedEmployeesId",
                table: "Employee_allowed_Department",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "Branches",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_allowed_Department",
                table: "Employee_allowed_Department",
                columns: new[] { "AllowedDepartmentsId", "AllowedEmployeesId" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkedShifts_EmployeeId",
                table: "WorkedShifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnavailableMoments_EmployeeId",
                table: "UnavailableMoments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShifts_EmployeeId",
                table: "PlannedShifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_allowed_Department_AllowedEmployeesId",
                table: "Employee_allowed_Department",
                column: "AllowedEmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ManagerId",
                table: "Branches",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Employees_ManagerId",
                table: "Branches",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_allowed_Department_Employees_AllowedEmployeesId",
                table: "Employee_allowed_Department",
                column: "AllowedEmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_DefaultBranchId",
                table: "Employees",
                column: "DefaultBranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHoursOverride_Branches_BranchId",
                table: "OpeningHoursOverride",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Branches_BranchId",
                table: "PlannedShifts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Employees_EmployeeId",
                table: "PlannedShifts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prognoses_Branches_BranchId",
                table: "Prognoses",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchId",
                table: "StandardOpeningHours",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standards_Branches_BranchId",
                table: "Standards",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnavailableMoments_Employees_EmployeeId",
                table: "UnavailableMoments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedShifts_Branches_BranchId",
                table: "WorkedShifts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedShifts_Employees_EmployeeId",
                table: "WorkedShifts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Employees_ManagerId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_allowed_Department_Employees_AllowedEmployeesId",
                table: "Employee_allowed_Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_DefaultBranchId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHoursOverride_Branches_BranchId",
                table: "OpeningHoursOverride");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Branches_BranchId",
                table: "PlannedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Employees_EmployeeId",
                table: "PlannedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_Prognoses_Branches_BranchId",
                table: "Prognoses");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchId",
                table: "StandardOpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Standards_Branches_BranchId",
                table: "Standards");

            migrationBuilder.DropForeignKey(
                name: "FK_UnavailableMoments_Employees_EmployeeId",
                table: "UnavailableMoments");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkedShifts_Branches_BranchId",
                table: "WorkedShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkedShifts_Employees_EmployeeId",
                table: "WorkedShifts");

            migrationBuilder.DropIndex(
                name: "IX_WorkedShifts_EmployeeId",
                table: "WorkedShifts");

            migrationBuilder.DropIndex(
                name: "IX_UnavailableMoments_EmployeeId",
                table: "UnavailableMoments");

            migrationBuilder.DropIndex(
                name: "IX_PlannedShifts_EmployeeId",
                table: "PlannedShifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_allowed_Department",
                table: "Employee_allowed_Department");

            migrationBuilder.DropIndex(
                name: "IX_Employee_allowed_Department_AllowedEmployeesId",
                table: "Employee_allowed_Department");

            migrationBuilder.DropIndex(
                name: "IX_Branches_ManagerId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "WorkedShifts");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "UnavailableMoments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "PlannedShifts");

            migrationBuilder.DropColumn(
                name: "AllowedEmployeesId",
                table: "Employee_allowed_Department");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "WorkedShifts",
                newName: "EmployeeKey");

            migrationBuilder.RenameIndex(
                name: "IX_WorkedShifts_BranchId",
                table: "WorkedShifts",
                newName: "IX_WorkedShifts_EmployeeKey");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Standards",
                newName: "BranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_Standards_BranchId",
                table: "Standards",
                newName: "IX_Standards_BranchKey");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "StandardOpeningHours",
                newName: "BranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_StandardOpeningHours_BranchId",
                table: "StandardOpeningHours",
                newName: "IX_StandardOpeningHours_BranchKey");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Prognoses",
                newName: "BranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_Prognoses_BranchId",
                table: "Prognoses",
                newName: "IX_Prognoses_BranchKey");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "PlannedShifts",
                newName: "EmployeeKey");

            migrationBuilder.RenameIndex(
                name: "IX_PlannedShifts_BranchId",
                table: "PlannedShifts",
                newName: "IX_PlannedShifts_EmployeeKey");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "OpeningHoursOverride",
                newName: "BranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_OpeningHoursOverride_BranchId",
                table: "OpeningHoursOverride",
                newName: "IX_OpeningHoursOverride_BranchKey");

            migrationBuilder.RenameColumn(
                name: "DefaultBranchId",
                table: "Employees",
                newName: "DefaultBranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DefaultBranchId",
                table: "Employees",
                newName: "IX_Employees_DefaultBranchKey");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "Key");

            migrationBuilder.AddColumn<int>(
                name: "BranchKey",
                table: "WorkedShifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeKey",
                table: "UnavailableMoments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchKey",
                table: "PlannedShifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Key",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AllowedEmployeesKey",
                table: "Employee_allowed_Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerKey",
                table: "Branches",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Key");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_allowed_Department",
                table: "Employee_allowed_Department",
                columns: new[] { "AllowedDepartmentsId", "AllowedEmployeesKey" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkedShifts_BranchKey",
                table: "WorkedShifts",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_UnavailableMoments_EmployeeKey",
                table: "UnavailableMoments",
                column: "EmployeeKey");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedShifts_BranchKey",
                table: "PlannedShifts",
                column: "BranchKey");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_allowed_Department_AllowedEmployeesKey",
                table: "Employee_allowed_Department",
                column: "AllowedEmployeesKey");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ManagerKey",
                table: "Branches",
                column: "ManagerKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Employees_ManagerKey",
                table: "Branches",
                column: "ManagerKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_allowed_Department_Employees_AllowedEmployeesKey",
                table: "Employee_allowed_Department",
                column: "AllowedEmployeesKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_DefaultBranchKey",
                table: "Employees",
                column: "DefaultBranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHoursOverride_Branches_BranchKey",
                table: "OpeningHoursOverride",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Branches_BranchKey",
                table: "PlannedShifts",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Employees_EmployeeKey",
                table: "PlannedShifts",
                column: "EmployeeKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prognoses_Branches_BranchKey",
                table: "Prognoses",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchKey",
                table: "StandardOpeningHours",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standards_Branches_BranchKey",
                table: "Standards",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnavailableMoments_Employees_EmployeeKey",
                table: "UnavailableMoments",
                column: "EmployeeKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedShifts_Branches_BranchKey",
                table: "WorkedShifts",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedShifts_Employees_EmployeeKey",
                table: "WorkedShifts",
                column: "EmployeeKey",
                principalTable: "Employees",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
