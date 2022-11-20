using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class IdentityUserRole_Bugged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
