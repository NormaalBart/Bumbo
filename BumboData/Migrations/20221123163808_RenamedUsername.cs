using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class RenamedUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d2acbf3f-d036-419a-a9a2-3b600593717a", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2", "AQAAAAEAACcQAAAAEMhLmHfItvpJ4iRneBRJiYC4WNbOhV7DnEd1p05WZQjfinW62cn/CmI/u3uEvxmghQ==", "08e92cf7-1030-4e42-8abb-659601fdf881", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b0e22fed-5fbd-48d5-b313-411b8350100b", "1c5d93f8-2965-47a1-89f2-fc626e06949b", "AQAAAAEAACcQAAAAELlqRXsMk6cNIJZRsAfyVljwasb+DV+2q25sM5n+pdOd4vVBv5xN2qVNJCKB5n601w==", "42c7d791-d6c1-4856-b52b-127170af9aec", "1c5d93f8-2965-47a1-89f2-fc626e06949b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "ManagesBranchId", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dffd73be-bc93-4385-8296-ccadccd635ee", 1, "3a792773-527d-4bb7-8319-6db070350d38", "AQAAAAEAACcQAAAAEDLx0FkXHJEHBgP85LHKwOyjbYgWvQjyIyiPAUXO8A/+3URtMmx9kYa8oVic+XHg5Q==", "f8fb6fe2-204d-4893-82ec-57f6b84082a0", "3a792773-527d-4bb7-8319-6db070350d38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f36c94f7-8d1f-473d-819a-f25868a38aa7", "d916944e-c1aa-44d6-83a0-cb04c5734e6b", "AQAAAAEAACcQAAAAEMOlYiKxVnGRKVf+iPMdNaZzOZnffb8Suz+7VzFUo0m97n0xU73z2tX303VpuaFH8g==", "cc50d2a2-3e96-4d46-ac33-92f239b5e972", "d916944e-c1aa-44d6-83a0-cb04c5734e6b" });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 8, 55, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 5, 5, 21, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 0, 58, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 5, 2, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 14, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 14, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 14, 56, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 21, 8, 55, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 6, 38, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 15, 2, 48, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 22, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 18, 6, 36, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 20, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 12, 13, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 12, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 11, 41, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 18, 50, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 16, 5, 28, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 19, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 8, 48, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 2, 14, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 15, 47, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 3, 7, 42, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 41, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 8, 16, 50, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 19, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 20, 10, 47, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 5, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 3, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 12, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 5, 26, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_ManagesBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ManagesBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ManagesBranchId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "Branches",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "3bcb98ea-653e-440b-b442-ebc407ee6ef2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "ba36dcb8-5fde-43e8-889f-b3709362e391");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "e78c4173-9f0a-4167-92c3-18a538911593");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "025a973d-bf65-4895-8426-11c2fd0fe8fb", "ADMIN", "AQAAAAEAACcQAAAAEFomtPr7Xcb7FIHVZSDf+GJpMi4G42jnfNe5Q/mLHlMukhVLnQ9teYJN6notRyfiTQ==", "b2cf5c0b-fa3c-4cdb-87bd-770e96301667", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0a9ace75-6bea-412d-a41d-cbbc4a476029", "MEDEWERKER2", "AQAAAAEAACcQAAAAEPZ8KJ1qk1XihWB0HtruuqWo1ZIVrp4OU+6xRMTRoeAtzbhiCEtOst4i4im6yLUeOw==", "a4d6aa01-b0e2-4303-9a69-3ffe28f33546", "medewerker2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3f0fba09-932b-4b6e-be38-f4989597add8", "MANAGER", "AQAAAAEAACcQAAAAEDe6C9uwtebIaPbPWxxWFtyjasXNLXt/5UALCftwx6PR/AVETcFsPHBRbiEDccduOA==", "c5ac9b7d-4622-4a04-8541-8c6d29dc4e71", "manager" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb898099-a452-4213-b7ee-32c0f76a5cea", "MEDEWERKER", "AQAAAAEAACcQAAAAEAqNNEg9hk2bVS7Vi8RcvCdw2dokT6udKQ43zDUbge6o5tWbnx8fegFGFk8s1sajhQ==", "0616df05-adb8-4a9e-8bf8-38fcf40f7399", "medewerker" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 5, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 3, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 20, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 19, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 3, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 2, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 12, 3, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 5, 1, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 15, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 10, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 10, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 2, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 14, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 10, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 14, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 12, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 21, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 18, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 11, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 5, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 11, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 10, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 19, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 17, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 7, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 6, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 0, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 13, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 10, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 14, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 4, 3, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 21, 2, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 18, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 12, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 19, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 5, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 21, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 24, 18, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 16, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 15, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 12, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 3, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 21, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 12, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 10, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 6, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 10, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 8, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 6, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 11, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 5, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 18, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 12, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 1, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 20, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 2, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 0, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 14, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 22, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 11, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 19, 12, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 15, 2, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 6, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 21, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 18, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 21, 28, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 18, 11, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 20, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 11, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 5, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 11, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 6, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 6, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 8, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 5, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 1, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 8, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 1, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 22, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 12, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 7, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 2, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 8, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 3, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 14, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 12, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 6, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 2, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 15, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 14, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 12, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 15, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 21, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 15, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 13, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 13, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 17, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 6, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 5, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 8, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 5, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 11, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 5, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 20, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 16, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 6, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 3, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 36, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 16, 4, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 12, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 11, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 20, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 19, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 4, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 10, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 7, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 12, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 5, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 13, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 2, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 19, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 4, 23, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 24, 1, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 19, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 19, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 6, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 19, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 7, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 12, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 11, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 15, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 14, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 5, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 3, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 18, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 12, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 21, 6, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 2, 5, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 21, 44, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 3, 17, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 20, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 10, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 12, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 7, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 15, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 6, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 4, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 40, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 8, 12, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 15, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 13, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 11, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 21, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 12, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 18, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 15, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 10, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 14, 5, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 18, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 18, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 7, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 14, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 7, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 19, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 18, 17, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 18, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 2, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 20, 3, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 15, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 5, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 11, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 13, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 15, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 10, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 5, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 5, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 20, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 18, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 13, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 12, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 21, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 13, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 5, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 11, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 16, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_ManagerId",
                table: "Branches",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_AspNetUsers_ManagerId",
                table: "Branches",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
