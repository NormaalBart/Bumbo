using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class UpdatedPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9545f802-f5e7-4708-a99c-9afa83012b8d", "AQAAAAEAACcQAAAAENhQWtC9CiEy0jGjDxauqESzgQm9Ghiuzx54cCzCe1pc1oXy+WRmZhPVABRv01PUTw==", "DZ4QIASGBFUBIEZJFGH5VPV3POM2CCBF" });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 13, 55, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 24, 9, 19, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 22, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 19, 27, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 13, 41, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 13, 48, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 16, 6, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 24, 6, 42, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 12, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 7, 24, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 15, 4, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 14, 53, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 14, 10, 8, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 6, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 18, 5, 4, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 18, 34, 0, 0, DateTimeKind.Unspecified) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "30211f17-70c1-4440-ac64-bed46fc75c5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "69091734-f098-4f98-a2ae-432d2d810d85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "304dd91a-2ae8-42d9-b062-2a65f706e80e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0e22fed-5fbd-48d5-b313-411b8350100b", "AQAAAAEAACcQAAAAELlqRXsMk6cNIJZRsAfyVljwasb+DV+2q25sM5n+pdOd4vVBv5xN2qVNJCKB5n601w==", "42c7d791-d6c1-4856-b52b-127170af9aec" });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 6, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 8, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 10, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 10, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 12, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 8, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 5, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 10, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 0, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 8, 20, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 8, 0, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 4, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 1, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 15, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 13, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 19, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 12, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 22, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 11, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 22, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 13, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 10, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 10, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 18, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 22, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 12, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 18, 5, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 21, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 14, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 14, 52, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 20, 14, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 14, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 22, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 14, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 13, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 11, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 7, 57, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 24, 6, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 20, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 18, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 22, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 4, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 7, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 2, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 19, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 7, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 15, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 19, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 7, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 21, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 14, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 11, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 20, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 14, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 13, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 10, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 5, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 15, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 14, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 15, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 3, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 12, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 14, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 14, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 9, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 20, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 18, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 6, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 2, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 18, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 7, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 15, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 13, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 6, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 4, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 0, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 13, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 10, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 10, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 20, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 22, 12, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 12, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 12, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 11, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 11, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 5, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 20, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 15, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 10, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 3, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 4, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 2, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 20, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 16, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 14, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 3, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 12, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 5, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 7, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 10, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 10, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 20, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 18, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 19, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 8, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 0, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 17, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 13, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 6, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 12, 55, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 12, 11, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 15, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 13, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 6, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 18, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 5, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 18, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 18, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 13, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 11, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 8, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 0, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 12, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 18, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 16, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 19, 33, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 13, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 7, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 18, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 16, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 19, 8, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 22, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 12, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 1, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 14, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 15, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 7, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 18, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 17, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 17, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 11, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 19, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 3, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 16, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 20, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 16, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 7, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 6, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 13, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 13, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 14, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 18, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 6, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 48, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 14, 15, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 14, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 11, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 5, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 18, 16, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 19, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 10, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 8, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 5, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 18, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 17, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 22, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 4, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 12, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 6, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 20, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 18, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 15, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 5, 5, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 3, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 12, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 31, 5, 26, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
