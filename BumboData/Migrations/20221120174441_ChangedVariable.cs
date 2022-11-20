using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class ChangedVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "4eee60d8-aef1-47fd-9397-5a89474607f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "dc4076f1-b8f0-4bd3-aeb0-6de6b453a2e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "c0733c74-f727-4e5f-a953-29208091222a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2ca3125-74d2-454e-80a2-f0441a34d834", "AQAAAAEAACcQAAAAEMr1kgizSk90jwcN054IkveAR/6xH+AymwNUrSMPVsz6Jn4S5RTDu+VvORLuj6PaEQ==", "9adf8ab5-107e-4fe2-95fe-78d040aa994d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4737e021-f7fd-44b4-b238-dddf3fe57b46", "AQAAAAEAACcQAAAAEATU2FewqDZ2dbglGcDP+VrXKx9n+t8ckpH7JIOK6UvdEVS2/4cf4PEmk7/es9gbjQ==", "24b78f66-7335-4def-89ff-5c701ab236fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b43389d7-4775-4c3f-890c-2f692e64e3ea", "AQAAAAEAACcQAAAAEPLNxH75RNXy/Xu4fELxae/kuWW83wdzA4hWefhiJc2QyuwcZEKDPsBzgX4jMen2DQ==", "1cdb5c0a-a978-4f52-835e-c1cfdd116cd5" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "be3cb770-6ef7-4b6e-b895-8516d9eb5288");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "b6794d3d-c43b-4db6-9913-8a946a0d9095");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "827fc57d-0fcc-46f3-88b5-aa455d7b41b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2bc5b52-cc83-4b23-ac33-9fbf9d081928", "AQAAAAEAACcQAAAAEJ4L9+5TFLii/nveacMNTlt/t+Si32hmab8uPCHAN3WmAjrHH4k82Dx6y7uSNQc2TQ==", "60437f7a-08bc-4117-b28d-c104bcf0d989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "240b48a0-9c97-4965-94f8-46f98b5f13c7", "AQAAAAEAACcQAAAAEGZW58C8SWGS33/dDIowV7417i0ii63v5x2y4hA7Cnu8m25oPCp5PDQAgTd+51jc5Q==", "2f7278f0-335e-4235-8824-4e41b0d344dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89979da9-45a3-4750-abd9-7ca8f361b9c6", "AQAAAAEAACcQAAAAENOws7Fv9w9a8SJbDEYALCqYso+uqnLb/83znRkK/JeTe7wkTFCzLaCimW2WDCS1YA==", "52af6351-6b6d-46df-85b7-08f89a434b83" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
