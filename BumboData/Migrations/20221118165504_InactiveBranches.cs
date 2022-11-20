using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class InactiveBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator",
                column: "ConcurrencyStamp",
                value: "be3cb770-6ef7-4b6e-b895-8516d9eb5288");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee",
                column: "ConcurrencyStamp",
                value: "b6794d3d-c43b-4db6-9913-8a946a0d9095");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "manager",
                column: "ConcurrencyStamp",
                value: "827fc57d-0fcc-46f3-88b5-aa455d7b41b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0854e8fa-f2c9-4b71-b300-4a1728ea7ef2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2bc5b52-cc83-4b23-ac33-9fbf9d081928", "AQAAAAEAACcQAAAAEJ4L9+5TFLii/nveacMNTlt/t+Si32hmab8uPCHAN3WmAjrHH4k82Dx6y7uSNQc2TQ==", "60437f7a-08bc-4117-b28d-c104bcf0d989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "240b48a0-9c97-4965-94f8-46f98b5f13c7", "AQAAAAEAACcQAAAAEGZW58C8SWGS33/dDIowV7417i0ii63v5x2y4hA7Cnu8m25oPCp5PDQAgTd+51jc5Q==", "2f7278f0-335e-4235-8824-4e41b0d344dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d916944e-c1aa-44d6-83a0-cb04c5734e6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89979da9-45a3-4750-abd9-7ca8f361b9c6", "AQAAAAEAACcQAAAAENOws7Fv9w9a8SJbDEYALCqYso+uqnLb/83znRkK/JeTe7wkTFCzLaCimW2WDCS1YA==", "52af6351-6b6d-46df-85b7-08f89a434b83" });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "Branches");

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
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 0 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "StandardOpeningHours",
                keyColumns: new[] { "BranchId", "DayOfWeek" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
