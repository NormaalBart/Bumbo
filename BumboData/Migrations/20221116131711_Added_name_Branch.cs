using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Added_name_Branch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e55be0-9007-4eac-ad96-726e0604179f", "AQAAAAEAACcQAAAAEAxxi7LJjAEJLIdcVYy7fkIv5Cf+Cgzjz8oIhG9Gf7Hy18FQno6AYLTL4TfyCvNwSA==", "4fc3dc08-161a-48bc-8ce4-2fce1f632c52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973fc020-9b7b-40de-a189-73a9d3a29e8a", "AQAAAAEAACcQAAAAELlO4mESoJ3sreol1NYiOeGHjyYI7+9VRjI9Tu4jwbOw/vspc5olLN9iRj40yzUJfg==", "75fa307c-81a6-480b-b31a-d2b86fca0194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38393104-e041-4f39-8928-6df414a801d1", "AQAAAAEAACcQAAAAEA4b0a532o9ThlcZ+BSJnkoqv/pN0PDUoIbN+4uculrjXXcHERx9bpDMuk2ussuVuQ==", "8edb3490-eea9-4b30-a850-3ca1ad396e30" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bumbo v1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Branches");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "98115108-0e71-4647-a8d3-ec1ebf1eb015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "049fc147-65c8-46ab-9750-d2eaea6fbc3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "89a07890-4b24-4470-a038-2f8e0c02f148");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3793eb81-7aa3-4546-a3e9-6f2f5c41760a", "AQAAAAEAACcQAAAAEA2zOODsjgVT7icY2H+rDgEMfMfhLwjJxNsXcxXTEgH2w+SvPwk6s0JnwEXvH058wA==", "00a130c9-8cc6-4b39-896c-9652b10304be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd529fa7-f8f7-44cc-8f65-ef92b5e394d7", "AQAAAAEAACcQAAAAEFLxTfgskKITgaYh8A840r3W/FTTPVEaa7wzRXLdAZig8SowGczvfZJAOzBbnlxIuw==", "f1a42bfc-fcd0-48c7-b234-31c110eb26ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c68e449a-be89-4ed4-8435-3e3feb58833c", "AQAAAAEAACcQAAAAEDOuaz4+Cgd8FnHSwtCzAp1FmtI9fZIGRKcH+zHixCT3Sv5uqsm2u0+S5QoTYvbc4A==", "0f74e7de-63de-45a5-87ff-54a4d947a7c1" });
        }
    }
}
