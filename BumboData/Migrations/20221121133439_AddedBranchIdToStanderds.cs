using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class AddedBranchIdToStanderds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "58e1b38c-aa1b-4ba6-80a7-4930fcc6cbb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "6f3b49c2-f806-4079-adca-12854f2985b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "189c9bed-50c7-4710-a9d7-cf7068fe4a6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce19d8bf-569b-425d-9f0a-0a276359889f", "AQAAAAEAACcQAAAAEL7EoGROpy+hf9MLK9HvJASJJkLz9nzjk+SQPXNglHjhCqTUj3iHqGfDwtLgKoltjw==", "7dbb85a8-2f28-4c84-8161-6054ebd4f7d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91f78210-57fa-449c-977b-4792e9754f3c", "AQAAAAEAACcQAAAAEAIUvOL4tP9lmhUz8uohPTRJfo6vFY6ZDJlCd4iWlOvwXn8wMOST04mouQ6QJ64S0Q==", "5e1900c7-3011-4b65-9bd1-66ff3620ccd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f0bca4b-d492-4a2b-aec6-1388e93637ae", "AQAAAAEAACcQAAAAEIc49m81fV0LxA2QDE9Y+z9dzK8ATkdqRe0xhL/LN9rAgqhg30SYypdwQo/krALX8Q==", "d467b96c-f9ff-4731-ae5e-530f298ed1aa" });

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

            migrationBuilder.InsertData(
                table: "Standards",
                columns: new[] { "Key", "BranchId", "Value" },
                values: new object[,]
                {
                    { 0, 1, 5 },
                    { 1, 1, 30 },
                    { 2, 1, 30 },
                    { 3, 1, 100 },
                    { 4, 1, 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Standards",
                keyColumn: "Key",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Standards",
                keyColumn: "Key",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Standards",
                keyColumn: "Key",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Standards",
                keyColumn: "Key",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Standards",
                keyColumn: "Key",
                keyValue: 4);

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
    }
}
