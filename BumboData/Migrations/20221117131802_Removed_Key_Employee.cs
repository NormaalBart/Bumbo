using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Removed_Key_Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0115f238-d719-418a-85af-1640af2a0c63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8000018a-7518-41c2-b9ea-1eeee7eb08d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ac636006-5e8b-4c62-bf87-31d7cb5c422b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "Birthdate", "ConcurrencyStamp", "DefaultBranchId", "Email", "EmailConfirmed", "EmployeeSince", "FirstName", "Function", "Housenumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postalcode", "Preposition", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "a798d3da-306e-4914-ab4e-e3879f44e250", 1, "admin@admin.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Administrator", "10", "Piet", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEAMhRqH9jI2+K0eM2iD+v8Yvk+RzMnxDyLsFd6S+NeoGhd05V6NExtrLWBR3gZRoLA==", null, false, "1234AA", null, "1c06c50d-725d-486e-a8fb-5d3d9b6bc3de", false, "admin" },
                    { "3a792773-527d-4bb7-8319-6db070350d38", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "03541ba5-962d-4713-a54b-8f8915844835", 1, "manager@manager.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager", "Manager", "10", "Piet", false, null, "MANAGER@MANAGER.COM", "MANAGER", "AQAAAAEAACcQAAAAELzQ0lg9heC9ZDgeAGxVbKm5CrqbMTxsBZRIj0UDwd0ZtYHC6pA/t0sltifE+2TtiQ==", null, false, "1234AA", null, "474f84e3-069a-4783-a7c9-9928439585fb", false, "manager" },
                    { "d916944e-c1aa-44d6-83a0-cb04c5734e6b", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a4054a3-aa0a-4890-9aa9-15a74c63d1aa", 1, "medewerker@medewerker.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medewerker", "Vuller", "10", "Piet", false, null, "MEDEWERKER@MEDEWERKER.COM", "MEDEWERKER", "AQAAAAEAACcQAAAAEP7lRdBbia9WokjzwUJJBijorLRotP2odDWdCChTafEdz5uSLpXb1y8CCoHPw7A1EA==", null, false, "1234AA", null, "c22b4bb7-dab4-4536-bcde-f8afb0314e69", false, "medewerker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "Birthdate", "ConcurrencyStamp", "DefaultBranchId", "Email", "EmailConfirmed", "EmployeeSince", "FirstName", "Function", "Housenumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postalcode", "Preposition", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "608a76cf-705c-4f4c-9cf7-fa7a71ff18a6", 1, "admin@admin.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Administrator", "10", "Piet", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEMPCGEyIzy9UtkSwNlNhRMiIAqO5B2t9HGXxLlnXS8a3xcQKRT4e+54XKateXZnRWA==", null, false, "1234AA", null, "51be8d43-3f35-4d23-8d9a-f69392bb7f88", false, "admin" },
                    { "2", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "150b4abd-26d0-4af2-83ec-8c55ed91b167", 1, "manager@manager.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager", "Manager", "10", "Piet", false, null, "MANAGER@MANAGER.COM", "MANAGER", "AQAAAAEAACcQAAAAECs7J8Z949vpflk1lXE9/W/T0A6yhenJSpPwY06ezyg9mkEHa06PFiopHpbTt/dLeg==", null, false, "1234AA", null, "bc6684fb-de04-4f15-a5b6-15f434ec72a3", false, "manager" },
                    { "3", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "864b04f2-ab5a-4f78-8d3b-5e46673aa9cf", 1, "medewerker@medewerker.com", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medewerker", "Vuller", "10", "Piet", false, null, "MEDEWERKER@MEDEWERKER.COM", "MEDEWERKER", "AQAAAAEAACcQAAAAEEsIWRF6sr6CiTq41o0cuAVZhRiI6i6v4AjDg3V3XoSGAt+VdzDZS3OU8nkPuC4axA==", null, false, "1234AA", null, "a285560c-6178-419a-a372-5a0b77179a9d", false, "medewerker" }
                });
        }
    }
}
