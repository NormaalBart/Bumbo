using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class AddWorkedShifts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0fba09-932b-4b6e-be38-f4989597add8", "AQAAAAEAACcQAAAAEDe6C9uwtebIaPbPWxxWFtyjasXNLXt/5UALCftwx6PR/AVETcFsPHBRbiEDccduOA==", "c5ac9b7d-4622-4a04-8541-8c6d29dc4e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb898099-a452-4213-b7ee-32c0f76a5cea", "AQAAAAEAACcQAAAAEAqNNEg9hk2bVS7Vi8RcvCdw2dokT6udKQ43zDUbge6o5tWbnx8fegFGFk8s1sajhQ==", "0616df05-adb8-4a9e-8bf8-38fcf40f7399" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "Birthdate", "ConcurrencyStamp", "DefaultBranchId", "Email", "EmailConfirmed", "EmployeeSince", "FirstName", "Function", "Housenumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postalcode", "Preposition", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1c5d93f8-2965-47a1-89f2-fc626e06949b", 0, true, new DateTime(2004, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a9ace75-6bea-412d-a41d-cbbc4a476029", 1, "medewerker2@medewerker.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medewerker2", "Vers", "15", "Jan", false, null, "MEDEWERKER2@MEDEWERKER.COM", "MEDEWERKER2", "AQAAAAEAACcQAAAAEPZ8KJ1qk1XihWB0HtruuqWo1ZIVrp4OU+6xRMTRoeAtzbhiCEtOst4i4im6yLUeOw==", null, false, "1234AA", null, "a4d6aa01-b0e2-4303-9a69-3ffe28f33546", false, "medewerker2" });

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
                table: "WorkedShifts",
                columns: new[] { "Id", "Approved", "BranchId", "EmployeeId", "EndTime", "Sick", "StartTime" },
                values: new object[,]
                {
                    { 1, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 1, 5, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 2, 3, 16, 0, 0, DateTimeKind.Unspecified) },
                    { 3, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 3, 20, 22, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 3, 19, 26, 0, 0, DateTimeKind.Unspecified) },
                    { 4, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 4, 3, 5, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 4, 2, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 5, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 5, 12, 3, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 5, 1, 4, 0, 0, DateTimeKind.Unspecified) },
                    { 6, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 6, 15, 6, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 6, 10, 4, 0, 0, DateTimeKind.Unspecified) },
                    { 7, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 7, 17, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 7, 10, 34, 0, 0, DateTimeKind.Unspecified) },
                    { 8, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 8, 10, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 8, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 9, 14, 2, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 9, 10, 4, 0, 0, DateTimeKind.Unspecified) },
                    { 10, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 10, 14, 25, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 10, 12, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 11, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 11, 21, 26, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 11, 18, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 12, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 12, 13, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 12, 11, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 13, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 13, 17, 46, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 13, 10, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 14, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 14, 8, 23, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 14, 5, 47, 0, 0, DateTimeKind.Unspecified) },
                    { 15, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 15, 11, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 15, 10, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 16, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 16, 19, 29, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 16, 17, 52, 0, 0, DateTimeKind.Unspecified) },
                    { 17, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 17, 7, 38, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 17, 6, 31, 0, 0, DateTimeKind.Unspecified) },
                    { 18, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 18, 0, 40, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 18, 0, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 19, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 19, 13, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 19, 10, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 20, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 20, 17, 25, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 20, 14, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 21, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 21, 4, 3, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 21, 2, 33, 0, 0, DateTimeKind.Unspecified) },
                    { 22, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 22, 18, 44, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 22, 12, 2, 0, 0, DateTimeKind.Unspecified) },
                    { 23, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 23, 19, 19, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 23, 5, 43, 0, 0, DateTimeKind.Unspecified) },
                    { 24, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 24, 21, 21, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 24, 18, 32, 0, 0, DateTimeKind.Unspecified) },
                    { 25, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 25, 16, 42, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 25, 16, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 26, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 26, 15, 43, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 26, 12, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 27, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 27, 15, 18, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 27, 8, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 28, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 28, 3, 2, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkedShifts",
                columns: new[] { "Id", "Approved", "BranchId", "EmployeeId", "EndTime", "Sick", "StartTime" },
                values: new object[,]
                {
                    { 29, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 29, 21, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 29, 12, 27, 0, 0, DateTimeKind.Unspecified) },
                    { 30, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 11, 30, 12, 11, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 30, 0, 34, 0, 0, DateTimeKind.Unspecified) },
                    { 61, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 6, 53, 0, 0, DateTimeKind.Unspecified) },
                    { 62, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 2, 2, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 63, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 3, 18, 21, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 3, 15, 22, 0, 0, DateTimeKind.Unspecified) },
                    { 64, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 4, 17, 54, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 4, 14, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 65, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 5, 22, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 5, 12, 32, 0, 0, DateTimeKind.Unspecified) },
                    { 66, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 6, 15, 20, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 6, 15, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 67, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 7, 21, 9, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 7, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 68, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 8, 13, 32, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 8, 13, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 69, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 9, 21, 25, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 9, 17, 36, 0, 0, DateTimeKind.Unspecified) },
                    { 70, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 10, 6, 29, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 10, 5, 33, 0, 0, DateTimeKind.Unspecified) },
                    { 71, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 11, 8, 35, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 11, 5, 32, 0, 0, DateTimeKind.Unspecified) },
                    { 72, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 12, 17, 47, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 12, 8, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 73, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 13, 11, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 13, 5, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 74, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 14, 20, 41, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 14, 16, 33, 0, 0, DateTimeKind.Unspecified) },
                    { 75, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 15, 6, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 15, 3, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 76, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 16, 11, 36, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 16, 4, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 77, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 17, 12, 7, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 17, 11, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 78, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 18, 20, 7, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 18, 19, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 79, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 19, 17, 20, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 19, 4, 14, 0, 0, DateTimeKind.Unspecified) },
                    { 80, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 20, 10, 27, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 20, 7, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 81, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 21, 12, 5, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 21, 5, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 82, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 22, 13, 16, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 2, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 83, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 23, 22, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 23, 19, 44, 0, 0, DateTimeKind.Unspecified) },
                    { 84, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 24, 4, 23, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 24, 1, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 85, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 25, 19, 27, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 25, 19, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 86, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 26, 17, 6, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 26, 6, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 87, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 27, 22, 11, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 27, 19, 36, 0, 0, DateTimeKind.Unspecified) },
                    { 88, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 28, 7, 19, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 28, 3, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 89, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 29, 12, 8, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 29, 11, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 90, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 30, 15, 19, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 14, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 91, true, 1, "d916944e-c1aa-44d6-83a0-cb04c5734e6b", new DateTime(2022, 10, 31, 5, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 31, 3, 37, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkedShifts",
                columns: new[] { "Id", "Approved", "BranchId", "EmployeeId", "EndTime", "Sick", "StartTime" },
                values: new object[,]
                {
                    { 31, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 1, 10, 21, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 1, 6, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 32, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 2, 10, 27, 0, 0, DateTimeKind.Unspecified) },
                    { 33, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 3, 17, 1, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 3, 8, 51, 0, 0, DateTimeKind.Unspecified) },
                    { 34, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 4, 21, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 4, 9, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 35, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 5, 8, 11, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 5, 6, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 36, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 6, 17, 34, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 6, 11, 27, 0, 0, DateTimeKind.Unspecified) },
                    { 37, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 7, 7, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 7, 3, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 38, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 8, 9, 49, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 8, 5, 14, 0, 0, DateTimeKind.Unspecified) },
                    { 39, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 9, 18, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 9, 9, 36, 0, 0, DateTimeKind.Unspecified) },
                    { 40, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 10, 12, 13, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 10, 1, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 41, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 11, 20, 55, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 11, 9, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 42, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 12, 2, 46, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 12, 0, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 43, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 13, 20, 53, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 13, 14, 34, 0, 0, DateTimeKind.Unspecified) },
                    { 44, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 14, 22, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 14, 11, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 45, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 15, 19, 12, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 15, 2, 44, 0, 0, DateTimeKind.Unspecified) },
                    { 46, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 16, 20, 31, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 16, 6, 4, 0, 0, DateTimeKind.Unspecified) },
                    { 47, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 17, 21, 14, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 17, 18, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 48, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 18, 21, 28, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 18, 11, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 49, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 19, 20, 44, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 19, 11, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 50, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 20, 18, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 20, 9, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 51, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 21, 10, 50, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 21, 5, 27, 0, 0, DateTimeKind.Unspecified) },
                    { 52, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 22, 11, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 22, 6, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 53, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 23, 10, 10, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 23, 6, 47, 0, 0, DateTimeKind.Unspecified) },
                    { 54, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 24, 8, 8, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 24, 5, 17, 0, 0, DateTimeKind.Unspecified) },
                    { 55, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 25, 17, 12, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 25, 1, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 56, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 26, 8, 51, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 26, 1, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 57, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 27, 22, 9, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 27, 12, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 58, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 28, 7, 5, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 28, 2, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 59, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 29, 8, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 29, 3, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 60, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 11, 30, 14, 38, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 30, 12, 22, 0, 0, DateTimeKind.Unspecified) },
                    { 92, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 1, 18, 23, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 1, 12, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 93, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 2, 21, 6, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 2, 5, 36, 0, 0, DateTimeKind.Unspecified) },
                    { 94, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 3, 21, 44, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 3, 17, 32, 0, 0, DateTimeKind.Unspecified) },
                    { 95, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 4, 20, 34, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 4, 10, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 96, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 5, 12, 41, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 5, 7, 26, 0, 0, DateTimeKind.Unspecified) },
                    { 97, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 6, 15, 49, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 6, 6, 56, 0, 0, DateTimeKind.Unspecified) },
                    { 98, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 7, 16, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 7, 4, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 99, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 8, 21, 40, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 8, 12, 19, 0, 0, DateTimeKind.Unspecified) },
                    { 100, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 9, 15, 31, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 9, 13, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 101, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 10, 16, 45, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 10, 11, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 102, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 11, 21, 28, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 11, 12, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 103, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 12, 18, 17, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 12, 15, 14, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkedShifts",
                columns: new[] { "Id", "Approved", "BranchId", "EmployeeId", "EndTime", "Sick", "StartTime" },
                values: new object[,]
                {
                    { 104, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 13, 16, 11, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 13, 0, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 105, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 14, 10, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 14, 5, 7, 0, 0, DateTimeKind.Unspecified) },
                    { 106, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 15, 18, 34, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 15, 18, 7, 0, 0, DateTimeKind.Unspecified) },
                    { 107, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 16, 7, 53, 0, 0, DateTimeKind.Unspecified) },
                    { 108, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 17, 14, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 17, 7, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 109, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 18, 19, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 18, 17, 31, 0, 0, DateTimeKind.Unspecified) },
                    { 110, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 19, 18, 24, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 20, 9, 2, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 10, 20, 3, 43, 0, 0, DateTimeKind.Unspecified) },
                    { 112, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 21, 15, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 21, 5, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 113, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 22, 20, 4, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 22, 11, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 114, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 23, 17, 14, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 23, 13, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 115, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 24, 15, 52, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 24, 10, 22, 0, 0, DateTimeKind.Unspecified) },
                    { 116, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 25, 5, 36, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 25, 5, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 117, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 26, 20, 19, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 26, 18, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 118, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 27, 13, 3, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 27, 12, 51, 0, 0, DateTimeKind.Unspecified) },
                    { 119, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 28, 21, 29, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 28, 12, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 120, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 29, 13, 57, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 29, 5, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 121, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 30, 16, 34, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 30, 11, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 122, true, 1, "1c5d93f8-2965-47a1-89f2-fc626e06949b", new DateTime(2022, 10, 31, 17, 12, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 10, 31, 16, 32, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "WorkedShifts",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5d93f8-2965-47a1-89f2-fc626e06949b");

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
