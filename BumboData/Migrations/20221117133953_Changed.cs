using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "d7dc692a-ffc4-4639-acdd-b29c0abbd0f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "5621a84a-6a83-47a3-82c4-c6849af98419");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "b5dfb148-32a9-46aa-a725-c26d14f38d53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "144fb2b5-fd05-4386-a60c-6b2c697cce72", "AQAAAAEAACcQAAAAEFXKAwzCAfCGPuLkcdrCmpummNanJmDFvLTPlLdemP/NeF9xIrjXPTowSxDa3xHLDA==", "520f2079-c202-4d5f-833b-5c1b8d1de114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42f818f2-7305-46c8-b0b3-07c73938c3fd", "AQAAAAEAACcQAAAAEIyW2IFltRlzsltGG2KZRx7s8nyOZtUx/19WXmOUKn41qfAQKKEqsNoaqqZPFSu3Rw==", "f4524472-cf13-4d4d-89f7-cd730df2b99f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04fba3a4-6fc7-4417-8e70-28ac40196a97", "AQAAAAEAACcQAAAAEB+1cbEPlBzDW3oSxIdOs4nwkCGbURHFpAGLF0Z77w7CZJzqs0NC1UlwObHzS30cVg==", "f0479aaf-6ff4-47ed-a1c4-751f9b78011e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "a3a9993d-dccb-4dc5-8663-def45fc6e4d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "95ec4328-f42e-4d88-ac06-fea512606d12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "c2e54dd3-d358-4c64-a5fc-517ca0b20e53");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17fdbff7-c932-46d6-8187-3fd3c08ce023", "AQAAAAEAACcQAAAAENx7YDjDyn4TDUfZAGpXWWJ7oMNboazF2NGiv2Vz3ud1725TqO5fR8Za67M+jGp/Rw==", "c129384b-b87a-4448-9bd9-11af51382afc" });
        }
    }
}
