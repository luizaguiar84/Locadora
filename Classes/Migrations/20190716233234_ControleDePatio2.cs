using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ControleDePatio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "ControlePatio",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ControlePatio");
        }
    }
}
