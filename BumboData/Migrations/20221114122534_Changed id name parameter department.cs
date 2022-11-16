using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Changedidnameparameterdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentPrognoses_Departments_DepartmentKey",
                table: "DepartmentPrognoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_allowed_Department_Departments_AllowedDepartmentsKey",
                table: "Employee_allowed_Department");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Departments_DepartmentKey",
                table: "PlannedShifts");

            migrationBuilder.RenameColumn(
                name: "DepartmentKey",
                table: "PlannedShifts",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_PlannedShifts_DepartmentKey",
                table: "PlannedShifts",
                newName: "IX_PlannedShifts_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "AllowedDepartmentsKey",
                table: "Employee_allowed_Department",
                newName: "AllowedDepartmentsId");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Departments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DepartmentKey",
                table: "DepartmentPrognoses",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentPrognoses_DepartmentKey",
                table: "DepartmentPrognoses",
                newName: "IX_DepartmentPrognoses_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentPrognoses_Departments_DepartmentId",
                table: "DepartmentPrognoses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_allowed_Department_Departments_AllowedDepartmentsId",
                table: "Employee_allowed_Department",
                column: "AllowedDepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Departments_DepartmentId",
                table: "PlannedShifts",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentPrognoses_Departments_DepartmentId",
                table: "DepartmentPrognoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_allowed_Department_Departments_AllowedDepartmentsId",
                table: "Employee_allowed_Department");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedShifts_Departments_DepartmentId",
                table: "PlannedShifts");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "PlannedShifts",
                newName: "DepartmentKey");

            migrationBuilder.RenameIndex(
                name: "IX_PlannedShifts_DepartmentId",
                table: "PlannedShifts",
                newName: "IX_PlannedShifts_DepartmentKey");

            migrationBuilder.RenameColumn(
                name: "AllowedDepartmentsId",
                table: "Employee_allowed_Department",
                newName: "AllowedDepartmentsKey");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "DepartmentPrognoses",
                newName: "DepartmentKey");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentPrognoses_DepartmentId",
                table: "DepartmentPrognoses",
                newName: "IX_DepartmentPrognoses_DepartmentKey");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentPrognoses_Departments_DepartmentKey",
                table: "DepartmentPrognoses",
                column: "DepartmentKey",
                principalTable: "Departments",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_allowed_Department_Departments_AllowedDepartmentsKey",
                table: "Employee_allowed_Department",
                column: "AllowedDepartmentsKey",
                principalTable: "Departments",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedShifts_Departments_DepartmentKey",
                table: "PlannedShifts",
                column: "DepartmentKey",
                principalTable: "Departments",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
