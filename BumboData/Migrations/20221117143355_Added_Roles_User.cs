using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Added_Roles_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "9826a19d-98dd-45ce-b9e8-94740e5a0a8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "977c919c-d2cb-4aa2-8fe6-0400a1ed998e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "975effb5-5f83-425a-ad17-705d2d21c2eb");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "administrator", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2" },
                    { "manager", "3a792773-527d-4bb7-8319-6db070350d38" },
                    { "employee", "d916944e-c1aa-44d6-83a0-cb04c5734e6b" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa44c98d-1d2e-4b1d-bece-462df861b2df", "AQAAAAEAACcQAAAAEC3ejoz2OsOev4hOOj4EIctT/3+eK3EoF3t6iB/rpo+ZQt4ekjl2tpiHwLr2mbzx7Q==", "a603bf1c-ecda-4664-9ec1-4cd5e205a525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4269a052-9bb5-4276-9454-80b35c8785aa", "AQAAAAEAACcQAAAAEIduzOP9fIe8lr5P2xjDG1etLrDmW8S3yZ0V47XQihkwl17VcXNnCGxcQrrcw1Yeug==", "b73b0694-6221-4bfb-919c-8d9e037de580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db684bd5-17de-4227-b50f-dbd7283abbdb", "AQAAAAEAACcQAAAAEBz9F8lLUXMOPPmH4LRtgpWEQ+v0Bw95d7wEZLK0jctVhc2Hsp7qIjELM/9D9BE8cQ==", "a0faf8bb-ac45-4dc2-b1e3-70defd329b11" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ManagerId" },
                values: new object[] { "3a792773-527d-4bb7-8319-6db070350d38" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "administrator", "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "manager", "3a792773-527d-4bb7-8319-6db070350d38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "employee", "d916944e-c1aa-44d6-83a0-cb04c5734e6b" });

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
    }
}
