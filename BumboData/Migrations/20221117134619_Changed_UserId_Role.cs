using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Changed_UserId_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
