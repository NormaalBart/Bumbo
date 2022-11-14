using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class UpdateEmployeeWithNewInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeJoinedCompany",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeJoinedCompany",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Employees");
        }
    }
}
