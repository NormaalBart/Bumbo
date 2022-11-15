using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Adding_Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_DefaultBranchKey",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchKey",
                table: "StandardOpeningHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StandardOpeningHours",
                table: "StandardOpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_StandardOpeningHours_BranchKey",
                table: "StandardOpeningHours");

            migrationBuilder.RenameColumn(
                name: "BranchKey",
                table: "StandardOpeningHours",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "DefaultBranchKey",
                table: "AspNetUsers",
                newName: "DefaultBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DefaultBranchKey",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DefaultBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StandardOpeningHours",
                table: "StandardOpeningHours",
                columns: new[] { "BranchId", "DayOfWeek" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "513b8bc3-fc8b-4acf-b013-4328702dea58", "Administrator", "ADMINISTRATOR" },
                    { "2", "6df9e759-3737-4f32-9d4f-b3bd59bda3d5", "Manager", "MANAGER" },
                    { "3", "91a9f932-961e-4015-8655-1b5d8f0c40c8", "Medewerker", "MEDEWERKER" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Key", "City", "HouseNumber", "ManagerId", "ShelvingDistance", "Street" },
                values: new object[] { 1, "Den Bosch", "2", null, 100, "Onderwijsboulevard" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Key", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Kassa" },
                    { 2, "Vers" },
                    { 3, "Vullers" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "Birthdate", "ConcurrencyStamp", "DefaultBranchId", "Email", "EmailConfirmed", "FirstName", "Key", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Preposition", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, true, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc40537f-a7b6-400e-83e5-7348d73e5ebb", 1, "admin@admin.com", true, "Jan", 1, "Piet", false, null, null, null, "AQAAAAEAACcQAAAAEF7D6YQY4AUfRKjBVUI/MZLb8VRfIe1JNk9qJpYDjXNpncMXOtOpgp5JS172AW+gJQ==", null, false, null, "b2e9e731-f897-4186-9660-baa0100a70ba", false, "admin" });

            migrationBuilder.InsertData(
                table: "StandardOpeningHours",
                columns: new[] { "BranchId", "DayOfWeek", "CloseTime", "OpenTime" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 1, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 2, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 3, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 4, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 5, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) },
                    { 1, 6, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_DefaultBranchId",
                table: "AspNetUsers",
                column: "DefaultBranchId",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchId",
                table: "StandardOpeningHours",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_DefaultBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchId",
                table: "StandardOpeningHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StandardOpeningHours",
                table: "StandardOpeningHours");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Key",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Key",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Key",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Key",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "StandardOpeningHours",
                newName: "BranchKey");

            migrationBuilder.RenameColumn(
                name: "DefaultBranchId",
                table: "AspNetUsers",
                newName: "DefaultBranchKey");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DefaultBranchId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DefaultBranchKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StandardOpeningHours",
                table: "StandardOpeningHours",
                column: "DayOfWeek");

            migrationBuilder.CreateIndex(
                name: "IX_StandardOpeningHours_BranchKey",
                table: "StandardOpeningHours",
                column: "BranchKey");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_DefaultBranchKey",
                table: "AspNetUsers",
                column: "DefaultBranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardOpeningHours_Branches_BranchKey",
                table: "StandardOpeningHours",
                column: "BranchKey",
                principalTable: "Branches",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
