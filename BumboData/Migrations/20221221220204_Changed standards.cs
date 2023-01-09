using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BumboData.Migrations
{
    public partial class Changedstandards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Standards",
                table: "Standards");

            migrationBuilder.DropIndex(
                name: "IX_Standards_BranchId",
                table: "Standards");

            migrationBuilder.AlterColumn<int>(
                name: "Key",
                table: "Standards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standards",
                table: "Standards",
                columns: new[] { "BranchId", "Key" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Standards",
                table: "Standards");

            migrationBuilder.AlterColumn<int>(
                name: "Key",
                table: "Standards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standards",
                table: "Standards",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_Standards_BranchId",
                table: "Standards",
                column: "BranchId");
        }
    }
}
