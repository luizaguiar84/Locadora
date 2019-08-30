using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ControleDePatio3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "ControlePatio",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placa",
                table: "ControlePatio");
        }
    }
}
