using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class RemoveManagerBranchId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_ManagesBranchId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ManagesBranchId",
                table: "AspNetUsers",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ManagesBranchId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_BranchId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                column: "BranchId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "AspNetUsers",
                newName: "ManagesBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ManagesBranchId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a792773-527d-4bb7-8319-6db070350d38",
                column: "ManagesBranchId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_ManagesBranchId",
                table: "AspNetUsers",
                column: "ManagesBranchId",
                principalTable: "Branches",
                principalColumn: "Id");
        }
    }
}
