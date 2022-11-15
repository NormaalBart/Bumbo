using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class medewerkermanager_inlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e70c92ff-b8de-4f6d-9a22-9413c720f4fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5dace8eb-7020-4514-82ca-664dac15c065");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ba508519-e7c2-4d7e-a707-b42e2914e16d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ed45b55-b019-45da-9d67-3d0f721d20e9", "AQAAAAEAACcQAAAAEH9kaR/QeOzcXLVA9gAq5FhJHMK+IAXjIpdq3aY34tsB00ETUP6j+PiTrh7Y5y3PSg==", "b8a19627-5107-4b53-8ffc-526f456955df" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "Birthdate", "ConcurrencyStamp", "DefaultBranchId", "Email", "EmailConfirmed", "FirstName", "Key", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Preposition", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "12bf24ca-94c4-4e8e-848b-d02600a0bf21", 1, "manager@manager.com", true, "Manager", 2, "Piet", false, null, null, null, "AQAAAAEAACcQAAAAEK5o4LnKmS6bIQXPssyg77uPGzacumKqS2f0jFWrGkTHmhkZ7xBfMuHuxFWmSn09QQ==", null, false, null, "47996ee5-bc5f-4efc-b08b-e61b26099651", false, "manager" },
                    { "3", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "c12a22a8-3308-4c32-83c6-7428c0fcf431", 1, "medewerker@medewerker.com", true, "Medewerker", 3, "Piet", false, null, null, null, "AQAAAAEAACcQAAAAEAsgRLSvQqQ4Vg7RKY4V1AKyJQizwUu/8ewXhrevN24vjeT12AgcUcxK481nXCrKAA==", null, false, null, "9673e21f-22e8-4a3e-96a0-617bb5044388", false, "medewerker" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

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
                value: "513b8bc3-fc8b-4acf-b013-4328702dea58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6df9e759-3737-4f32-9d4f-b3bd59bda3d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "91a9f932-961e-4015-8655-1b5d8f0c40c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc40537f-a7b6-400e-83e5-7348d73e5ebb", "AQAAAAEAACcQAAAAEF7D6YQY4AUfRKjBVUI/MZLb8VRfIe1JNk9qJpYDjXNpncMXOtOpgp5JS172AW+gJQ==", "b2e9e731-f897-4186-9660-baa0100a70ba" });
        }
    }
}
