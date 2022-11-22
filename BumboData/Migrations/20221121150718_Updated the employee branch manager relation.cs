using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Updatedtheemployeebranchmanagerrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_ManagerId",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_ManagerId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Branches");

            migrationBuilder.AddColumn<int>(
                name: "ManagesBranchId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "f2e62ad0-e19a-48d5-a4c2-9b2ba4813836");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "08307dc1-5e9b-42db-9e51-3c79fe8eec1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "1dbeb54a-ba45-44b8-b38c-52f4f310164a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebcd4b9f-6421-4be5-ba80-5d598e12089f", "AQAAAAEAACcQAAAAEAyxWq8uN30qLg1zRUrr0rKrnSQVUTmEd3tAEsGuFl5sOeW+VN306NiY5YwA+FDN5g==", "5654b411-c3bf-4d4b-9f7f-14776917c1fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7298b9b9-3fcd-423a-8440-fef85cb90bdc", "AQAAAAEAACcQAAAAEPYX+udju7wuMq0tyH2ac7OAWpkJs5wX6Y7pLpGBjdR4S9UApuq25jcYmrBo3B022Q==", "382cbca7-d10a-4c11-b680-645d235be2f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "ManagesBranchId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97069e37-a135-45b0-918f-3825705feae3", 1, "AQAAAAEAACcQAAAAENxMnN2A1javhxYOsmtcJqC3K3Uh6A+N7K6dcPAQSYX1s7a+3opj75KrUElQEugdvA==", "15f9c6b2-3e49-4f0f-9864-34228e885ad5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "526dd4a7-5d83-4b3c-9133-44f42c7a6a37", "AQAAAAEAACcQAAAAEN/uYPe8A3xiQ3aEzk/p47FR1jtil1c67rz1HxkXXg5I0h577lutA3EULC/LZM9OUQ==", "e1b80859-24b0-4020-9878-1a99e9f67786" });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 4, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 18, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 10, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 1, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 9, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 16, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 5, 14, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 12, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 7, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 14, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 14, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 4, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 21, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 19, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 12, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 4, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 22, 49, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 13, 17, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 19, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 13, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 19, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 4, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 19, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 18, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 16, 25, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 17, 2, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 5, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 21, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 15, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 18, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 15, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 31, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 21, 13, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 13, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 20, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 10, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 18, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 20, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 19, 56, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 27, 12, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 15, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 11, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 13, 37, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 29, 11, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 15, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 14, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 2, 19, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 14, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 3, 10, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 2, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 4, 21, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 15, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 5, 14, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 11, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 6, 8, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 4, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 22, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 18, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 18, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 9, 13, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 12, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 10, 3, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 3, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 12, 37, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 11, 7, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 12, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 11, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 8, 40, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 13, 0, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 14, 21, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 15, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 15, 18, 16, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 15, 5, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 13, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 5, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 1, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 18, 5, 29, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 18, 3, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 19, 22, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 20, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 17, 52, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 21, 17, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 22, 22, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 14, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 23, 21, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 18, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 22, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 6, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 20, 21, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 25, 5, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 30, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 26, 18, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 11, 39, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 27, 10, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 11, 24, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 28, 3, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 2, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 30, 10, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 6, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 14, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 14, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 1, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 5, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 2, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 22, 11, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 4, 18, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 14, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 15, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 14, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 8, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 7, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 4, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 15, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 0, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 5, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 13, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 6, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 11, 53, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 12, 2, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 6, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 3, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 20, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 16, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 16, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 17, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 16, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 17, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 12, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 7, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 12, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 10, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 3, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 14, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 14, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 19, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 15, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 15, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 21, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 15, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 17, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 20, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 14, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 18, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 18, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 2, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 9, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 5, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 1, 18, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 13, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 2, 20, 41, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 2, 11, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 3, 15, 26, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 3, 5, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 17, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 5, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 6, 20, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 19, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 7, 9, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 3, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 6, 11, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 8, 2, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 9, 13, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 4, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 16, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 11, 4, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 4, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 14, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 10, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 3, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 7, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 6, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 11, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 4, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 10, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 2, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 19, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 20, 20, 41, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 20, 15, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 21, 13, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 17, 16, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 22, 6, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 23, 11, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 3, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 7, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 25, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 12, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 26, 13, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 27, 15, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 28, 19, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 18, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 29, 20, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 19, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 30, 8, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 6, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 31, 21, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 1, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagesBranchId",
                table: "AspNetUsers",
                column: "ManagesBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_ManagesBranchId",
                table: "AspNetUsers",
                column: "ManagesBranchId",
                principalTable: "Branches",
                principalColumn: "Id");
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "025a973d-bf65-4895-8426-11c2fd0fe8fb", "AQAAAAEAACcQAAAAEFomtPr7Xcb7FIHVZSDf+GJpMi4G42jnfNe5Q/mLHlMukhVLnQ9teYJN6notRyfiTQ==", "b2cf5c0b-fa3c-4cdb-87bd-770e96301667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a9ace75-6bea-412d-a41d-cbbc4a476029", "AQAAAAEAACcQAAAAEPZ8KJ1qk1XihWB0HtruuqWo1ZIVrp4OU+6xRMTRoeAtzbhiCEtOst4i4im6yLUeOw==", "a4d6aa01-b0e2-4303-9a69-3ffe28f33546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0fba09-932b-4b6e-be38-f4989597add8", "AQAAAAEAACcQAAAAEDe6C9uwtebIaPbPWxxWFtyjasXNLXt/5UALCftwx6PR/AVETcFsPHBRbiEDccduOA==", "c5ac9b7d-4622-4a04-8541-8c6d29dc4e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb898099-a452-4213-b7ee-32c0f76a5cea", "AQAAAAEAACcQAAAAEAqNNEg9hk2bVS7Vi8RcvCdw2dokT6udKQ43zDUbge6o5tWbnx8fegFGFk8s1sajhQ==", "0616df05-adb8-4a9e-8bf8-38fcf40f7399" });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 17, 46, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 17, 7, 38, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 17, 6, 31, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 18, 32, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 18, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 27, 8, 12, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 29, 21, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 29, 12, 27, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 11, 20, 55, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 11, 9, 55, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 53, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 13, 14, 34, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 21, 10, 50, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 21, 5, 27, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 12, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 25, 1, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 26, 8, 51, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 26, 1, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 27, 22, 9, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 27, 12, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 28, 7, 5, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 28, 2, 41, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 4, 17, 54, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 4, 14, 49, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 12, 17, 47, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 12, 8, 37, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 17, 12, 7, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 17, 11, 3, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 24, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 1, 8, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 14, 10, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 5, 7, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 18, 19, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 17, 31, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "EndTime", "Sick", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 11, 40, 0, 0, DateTimeKind.Unspecified) });

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
