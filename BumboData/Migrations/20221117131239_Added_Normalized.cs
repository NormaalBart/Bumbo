using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Added_Normalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d8fa10ca-4603-4d15-83b4-b78746a43c43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a8bab04d-0842-4fe1-bf1f-5929f2bf0ec6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "174039b2-8a96-4010-bc40-ef354cc7ed9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608a76cf-705c-4f4c-9cf7-fa7a71ff18a6", "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEMPCGEyIzy9UtkSwNlNhRMiIAqO5B2t9HGXxLlnXS8a3xcQKRT4e+54XKateXZnRWA==", "51be8d43-3f35-4d23-8d9a-f69392bb7f88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "150b4abd-26d0-4af2-83ec-8c55ed91b167", "MANAGER@MANAGER.COM", "MANAGER", "AQAAAAEAACcQAAAAECs7J8Z949vpflk1lXE9/W/T0A6yhenJSpPwY06ezyg9mkEHa06PFiopHpbTt/dLeg==", "bc6684fb-de04-4f15-a5b6-15f434ec72a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "864b04f2-ab5a-4f78-8d3b-5e46673aa9cf", "MEDEWERKER@MEDEWERKER.COM", "MEDEWERKER", "AQAAAAEAACcQAAAAEEsIWRF6sr6CiTq41o0cuAVZhRiI6i6v4AjDg3V3XoSGAt+VdzDZS3OU8nkPuC4axA==", "a285560c-6178-419a-a372-5a0b77179a9d" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bb04ebe5-be50-4b5e-917c-44943545b903");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8951e2da-4966-4563-af94-7f730e6a15f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e6a44e84-edf2-4804-8573-4c6259db901b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e55be0-9007-4eac-ad96-726e0604179f", null, null, "AQAAAAEAACcQAAAAEAxxi7LJjAEJLIdcVYy7fkIv5Cf+Cgzjz8oIhG9Gf7Hy18FQno6AYLTL4TfyCvNwSA==", "4fc3dc08-161a-48bc-8ce4-2fce1f632c52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973fc020-9b7b-40de-a189-73a9d3a29e8a", null, null, "AQAAAAEAACcQAAAAELlO4mESoJ3sreol1NYiOeGHjyYI7+9VRjI9Tu4jwbOw/vspc5olLN9iRj40yzUJfg==", "75fa307c-81a6-480b-b31a-d2b86fca0194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38393104-e041-4f39-8928-6df414a801d1", null, null, "AQAAAAEAACcQAAAAEA4b0a532o9ThlcZ+BSJnkoqv/pN0PDUoIbN+4uculrjXXcHERx9bpDMuk2ussuVuQ==", "8edb3490-eea9-4b30-a850-3ca1ad396e30" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
