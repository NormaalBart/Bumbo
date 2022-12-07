using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class AddedStreet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 14, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 2, 22, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 11, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 3, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 16, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 4, 10, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 5, 6, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 3, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 6, 22, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 15, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 7, 20, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 8, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 8, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 9, 18, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 3, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 10, 20, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 13, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 3, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 13, 15, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 14, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 14, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 16, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 15, 18, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 10, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 16, 15, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 1, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 4, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 18, 21, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 2, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 19, 19, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 20, 22, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 14, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 21, 12, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 5, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 22, 14, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 23, 14, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 11, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 25, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 16, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 26, 14, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 26, 3, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 27, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 13, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 28, 22, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 0, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 29, 22, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 13, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 30, 22, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 6, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 12, 31, 20, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 5, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 2, 2, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 0, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 3, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 11, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 4, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 4, 11, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 5, 10, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 5, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 8, 16, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 11, 11, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 6, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 12, 14, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 13, 10, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 4, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 14, 15, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 3, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 15, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 10, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 16, 12, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 2, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 17, 10, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 19, 10, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 5, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 16, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 21, 21, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 17, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 22, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 13, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 23, 6, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 6, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 24, 19, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 18, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 25, 22, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 11, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 26, 1, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 28, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 2, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 4, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 12, 30, 11, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 4, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 12, 31, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 13, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 6, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 16, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 11, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 22, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 22, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 18, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 22, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 13, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 17, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 19, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 10, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 9, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 20, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 18, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 12, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 10, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 11, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 13, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 1, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 2, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 18, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 15, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 11, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 10, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 19, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 17, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 18, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 18, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 2, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 22, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 12, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 16, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 15, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 4, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 30, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 15, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 14, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 19, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 2, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 18, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 4, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 12, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 12, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 5, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 10, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 7, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 6, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 2, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 1, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 15, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 16, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 21, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 10, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 19, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 17, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 15, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 6, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 4, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 11, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 4, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 11, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 2, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 15, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 15, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 11, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 14, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 12, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 18, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 11, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 2, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 1, 42, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 14, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 22, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 11, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 16, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 15, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 10, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 6, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 3, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 22, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 15, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 20, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 18, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 3, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 20, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 13, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 19, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 3, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 15, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 14, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 16, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 18, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 10, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 1, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 15, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 4, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 21, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 2, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 19, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 13, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 14, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 12, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 5, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 14, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 14, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 13, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 16, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 3, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 13, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 22, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 13, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 6, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 1, 20, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 5, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 10, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 2, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 0, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 11, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 11, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 10, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 5, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 19, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 19, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 16, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 20, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 11, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 6, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 14, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 10, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 4, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 3, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 10, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 12, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 2, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 10, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 10, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 5, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 16, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 21, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 17, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 13, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 6, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 6, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 19, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 18, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 22, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 11, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 22, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 1, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 13, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 2, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 13, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 4, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 1, 11, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 4, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 13, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 6, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 16, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 11, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 18, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 13, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 17, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 19, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 10, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 9, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 20, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 18, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 12, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 10, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 11, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 13, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 1, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 20, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 2, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 20, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 18, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 15, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 11, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 10, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 20, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 19, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 17, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 20, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 18, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 21, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 18, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 10, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 2, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 12, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 16, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 15, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 4, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 14, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EmployeeId", "EndTime", "StartTime" },
                values: new object[] { "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 1, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 15, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 14, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 19, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 2, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 18, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 4, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 12, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 5, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 10, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 7, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 6, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 2, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 1, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 15, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 16, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 21, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 10, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 19, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 17, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 15, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 6, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 4, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 11, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 4, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 11, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 2, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 15, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 15, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 11, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 14, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 12, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 19, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 18, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 11, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 1, 42, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
