using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Tried_Fixing_Bug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "d71b761a-1738-421a-935c-e9a99bf0c7ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "cfb2cc17-90ad-4b7c-bca2-bc34dadf84c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "09554a04-0bd1-4e51-8d9e-d57e066c01a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78f20b7b-9d71-4b6a-bf78-8de6e2f2f04c", "AQAAAAEAACcQAAAAEN1ZRopEy64lj/Ah/TWACsXbrj/f93l6NgUU9N/ntROzoypmxOP9w/cQYCfvMLzJEA==", "de7963cc-4ea3-413c-89dd-a3cab3fb9757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "badac738-7f17-404c-82e8-f5f9940840af", "AQAAAAEAACcQAAAAENB9zA1dMT8FAdi+Khn2fGG7t1/RjNSmoQEPusswDLchXjHS8kmLEEa5menhmMIZ4g==", "456f583e-0dd9-4d33-9989-4c6e4878e18a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f97b88a-86fd-4323-85f9-317989f5f5ec", "AQAAAAEAACcQAAAAELG/2ilLdA7RdCUypxirkQQmSOzl11VgA4qPSayOigytdCxc/wKrXjqEIWPSsDi0ow==", "dc864215-ec35-4e60-83a0-4373d1535d03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "64ee46b5-61f6-461f-baf7-35a040f1353d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "65f3b20f-9801-4b4e-9074-89622442095a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "a6d543ce-4444-4e70-8549-38010647eacb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c675fe-d1eb-4b71-819b-ec3703597487", "AQAAAAEAACcQAAAAELxU/f5VeGLvS+2gQ271bEL2bc9fqHr6/c8+Jd/UO8cW9yxzcRO6RMV8WxtRxw5EmA==", "a8bf1aee-89b0-42b0-930c-088119c24bd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0abc6f3d-1d38-41aa-9e7b-b3b57c3ff9a1", "AQAAAAEAACcQAAAAECaN+romCHwpseuzlKFDGuz0Wk/nErQ1xZvp8wSKC0elVYkn94/UmMlChSLG/9V2lg==", "6053eed1-c3fc-4e26-83cf-e4535a89b7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2591366-2b8b-4cb4-bcb9-bbe0d9940e53", "AQAAAAEAACcQAAAAEGoJ0etz+863ow/ALj73Od5HqoXPJV33Kf+u2dtE+aLIkl2s2UIOgsBA6W7GO4CdZg==", "db6494f1-3729-4128-8806-7adb04d0df5f" });
        }
    }
}
