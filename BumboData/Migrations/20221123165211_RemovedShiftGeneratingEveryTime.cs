using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class RemovedShiftGeneratingEveryTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "1181a7d7-f073-4d05-b928-cc80f6f54033");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "7d959d94-90d6-4597-b435-609d47ad20a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "9561f2c3-10ae-4fcf-bba4-2a0fea44eb0f");

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 16, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 8, 9, 8, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 21, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 18, 2, 35, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 20, 14, 56, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 58, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 28, 0, 30, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 20, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 5, 7, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 21, 53, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 22, 17, 52, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 4, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 8, 46, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 58, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 6, 11, 44, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 40, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 9, 13, 5, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 9, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 12, 8, 31, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 17, 55, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 14, 12, 37, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 15, 3, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 4, 23, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 15, 37, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 18, 33, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 5, 4, 55, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 10, 25, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 8, 7, 1, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 11, 33, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 27, 9, 48, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 11, 53, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 2, 6, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 31, 1, 42, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "8c661ee8-0f6e-47dc-b4c8-37d5942be9df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "ec53335e-6846-436e-8e17-223f758a3be2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "8c8e01e8-48c7-46b0-8557-194006e8be12");

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 18, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 13, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 18, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 9, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 7, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 19, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 17, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 18, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 8, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 2, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 52, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 8, 1, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 12, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 4, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 19, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 11, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 7, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 1, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 7, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 4, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 22, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 18, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 5, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 1, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 10, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 10, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 22, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 13, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 10, 14, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 18, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 23, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 20, 16, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 19, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 18, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 22, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 13, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 19, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 13, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 10, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 6, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 15, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 57, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 28, 19, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 15, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 13, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 20, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 13, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 15, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 19, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 17, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 13, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 19, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 4, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 15, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 12, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 3, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 15, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 7, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 20, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 18, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 16, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 8, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 1, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 4, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 15, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 1, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 10, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 3, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 11, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 10, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 2, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 2, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 2, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 8, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 5, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 18, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 29, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 22, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 19, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 16, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 18, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 20, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 21, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 18, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 18, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 16, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 20, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 19, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 22, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 10, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 12, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 16, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 3, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 17, 3, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 6, 13, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 19, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 17, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 10, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 1, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 17, 10, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 9, 13, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 7, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 6, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 19, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 20, 51, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 12, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 21, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 2, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 16, 9, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 14, 16, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 13, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 7, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 10, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 21, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 16, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 19, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 3, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 7, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 1, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 19, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 15, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 6, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 20, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 20, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 5, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 8, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 1, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 20, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 1, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 15, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 2, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 13, 13, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 30, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 19, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 12, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 2, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 19, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 13, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 15, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 4, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 12, 57, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 5, 7, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 10, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 3, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 2, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 8, 15, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 1, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 14, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 5, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 18, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 10, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 21, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 18, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 14, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 10, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 5, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 2, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 6, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 6, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 5, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 18, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 7, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 21, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 13, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 21, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 11, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 13, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 12, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 7, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 2, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 8, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 0, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 19, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 12, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 27, 18, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 20, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 17, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 19, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 19, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 3, 32, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 30, 0, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 21, 30, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 31, 19, 47, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
