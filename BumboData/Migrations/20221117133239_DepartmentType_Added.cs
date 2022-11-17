using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class DepartmentType_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "administrator", "a3a9993d-dccb-4dc5-8663-def45fc6e4d9", "Administrator", "ADMINISTRATOR" },
                    { "employee", "95ec4328-f42e-4d88-ac06-fea512606d12", "Employee", "EMPLOYEE" },
                    { "manager", "c2e54dd3-d358-4c64-a5fc-517ca0b20e53", "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f552f6f7-6c41-474a-9d53-8ae0cef4d288", "AQAAAAEAACcQAAAAEGqaU2r8mVwst3yuPgSc9LHoveK1wJPTIV6X5YiIwi5XBmQa3X9ZD26lCmudJ57PYQ==", "67b3d1d1-2384-4559-ab0d-e07cf2249bed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56ca3500-09f4-4267-b60e-d9fd1f7977a6", "AQAAAAEAACcQAAAAEIw7YWcCF+VhGEjy5JxRG/kKR8O6SNWgZKl/4H8xeIDITxDiTafKHiyzLi/Op5F8zA==", "5dae8112-85ec-4809-879b-267746c0e1ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "Function", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17fdbff7-c932-46d6-8187-3fd3c08ce023", "Vers", "AQAAAAEAACcQAAAAENx7YDjDyn4TDUfZAGpXWWJ7oMNboazF2NGiv2Vz3ud1725TqO5fR8Za67M+jGp/Rw==", "c129384b-b87a-4448-9bd9-11af51382afc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "administrator", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "manager", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "employee", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "0115f238-d719-418a-85af-1640af2a0c63", "Administrator", "ADMINISTRATOR" },
                    { "2", "8000018a-7518-41c2-b9ea-1eeee7eb08d7", "Manager", "MANAGER" },
                    { "3", "ac636006-5e8b-4c62-bf87-31d7cb5c422b", "Medewerker", "MEDEWERKER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a798d3da-306e-4914-ab4e-e3879f44e250", "AQAAAAEAACcQAAAAEAMhRqH9jI2+K0eM2iD+v8Yvk+RzMnxDyLsFd6S+NeoGhd05V6NExtrLWBR3gZRoLA==", "1c06c50d-725d-486e-a8fb-5d3d9b6bc3de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03541ba5-962d-4713-a54b-8f8915844835", "AQAAAAEAACcQAAAAELzQ0lg9heC9ZDgeAGxVbKm5CrqbMTxsBZRIj0UDwd0ZtYHC6pA/t0sltifE+2TtiQ==", "474f84e3-069a-4783-a7c9-9928439585fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "Function", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a4054a3-aa0a-4890-9aa9-15a74c63d1aa", "Vuller", "AQAAAAEAACcQAAAAEP7lRdBbia9WokjzwUJJBijorLRotP2odDWdCChTafEdz5uSLpXb1y8CCoHPw7A1EA==", "c22b4bb7-dab4-4536-bcde-f8afb0314e69" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "3" });
        }
    }
}
