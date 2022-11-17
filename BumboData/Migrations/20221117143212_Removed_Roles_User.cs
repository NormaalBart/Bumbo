using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Removed_Roles_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3a792773-527d-4bb7-8319-6db070350d38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d916944e-c1aa-44d6-83a0-cb04c5734e6b" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "adc68d8d-472a-4018-8532-589862c89d63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "a7f9ecbb-a9ce-4eab-aa02-f3567c508567");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "9fd38bda-2a6c-481f-91c0-ad1cf7b266ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6c77f6c-7748-4ea2-ba16-577280199da6", "AQAAAAEAACcQAAAAECJKPZgwqyC9yrM+nQUj3lDyC5CoCvRXpSoKIv6PN28K73+OqRnRCkomCaVI9vtF9g==", "9a3c23cd-9f9a-4663-8ffc-f1b24b749099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb69c92d-c3ea-4acb-ae14-19fd2789c45a", "AQAAAAEAACcQAAAAEOKJB+1/I7m+CaSbG2w3C9lvXTYDN6RVjmr/KVD+tJD91BjdKu4Gfj9d/3leJD7tGQ==", "d46e9c27-f196-4d8f-b963-9c389053d2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5d65350-447c-4250-be7e-0c45d3ae68ef", "AQAAAAEAACcQAAAAEGD+IQiT0cA4P0JwthZxw58hcbp5IUILvC7JkQTXtvxRa7s6wTiACbBM/I/rt88w2g==", "fd7a29dd-689a-405e-bd49-ba9816f79de0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2" },
                    { "2", "3a792773-527d-4bb7-8319-6db070350d38" },
                    { "3", "d916944e-c1aa-44d6-83a0-cb04c5734e6b" }
                });

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
    }
}
