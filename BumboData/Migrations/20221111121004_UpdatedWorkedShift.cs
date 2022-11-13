using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class UpdatedWorkedShift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "WorkedShift");

            migrationBuilder.AddColumn<bool>(
                name: "Sick",
                table: "WorkedShift",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sick",
                table: "WorkedShift");

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "WorkedShift",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
