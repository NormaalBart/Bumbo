using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Addedsicktoplannedshift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Sick",
                table: "PlannedShifts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 14, 8, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sick",
                table: "PlannedShifts");

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
