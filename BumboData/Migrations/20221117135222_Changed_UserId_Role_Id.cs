using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Changed_UserId_Role_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "d22b093d-0bb0-4485-a398-fa53a3486ac3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "94337adf-6070-4b08-8cc1-11c001879df7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "3dc0c308-6fc7-4b13-a81b-6e3bf94dc575");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40384270-a832-43bc-af35-9d9c9e73eaed", "AQAAAAEAACcQAAAAECRrtVBOo1xoxF8o5pSuA0PM+9t9Fc8nJi7GkWhSZXffkjFPDCnwQaRcsDu/8qK/iw==", "1d724e87-2b68-416b-b5c6-ef6f69fc53bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "240db27b-0465-4e6b-a31d-7c1b3d77a902", "AQAAAAEAACcQAAAAEOh7aRg3eR4RfFn+b6oYmYHrOWwcPqjsZJ0Rl7QOHQFjhq3/cHiT+mfQ77q9UmxzJQ==", "61e7d7f1-df09-4c1d-b95d-d527a472c98d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7396ccd-77e4-4a03-8819-ca3e2ba4373e", "AQAAAAEAACcQAAAAEG4UowqSwgb7Gj7Ic9PdLMKjd9Rl5ISVMtqQJSjOSpC861Edy+om0/TdazsrjbtelQ==", "c883d040-432a-4a2f-8116-898ce9e1f0c4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "f294c1af-4421-4582-9850-c4031d23cdcf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "5c46fb98-4ca9-4f7d-be5b-e59b34eae87d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "545a05d8-f493-4730-9f4e-527b1c75c89d");

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
                values: new object[] { "e8c8835c-8579-4e12-b786-d256f4f21180", "AQAAAAEAACcQAAAAEC7hYj7XP4kK89TrdLom7urqHuJXVq2Lt+LQZMChPBTI9l99aoVsKdV0QV1gCN0OLQ==", "27dd1e0f-d534-457d-82f1-091b10f9baea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b16ca17c-e8b9-46d4-bca9-2dd8e02baaa7", "AQAAAAEAACcQAAAAEDhDar3MYqPc/N4g6J+h4YXC8L4TQMFD6VI8/y/UbjzEtjCLDRVygubpODnZHOSkrQ==", "1e2083f7-f91b-4dbc-a998-d02f4713366d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43f3c939-0dc5-433a-bb90-d6d4a2cef868", "AQAAAAEAACcQAAAAEA1A3kmp2NNtwauBlJTctLIAsG34+C9ga1kBd55vKeuneCZ3LpwDfwqjdWcEFiyhDg==", "c7aa0fb5-5af9-4d6d-ab77-eba2b5c2d94b" });
        }
    }
}
