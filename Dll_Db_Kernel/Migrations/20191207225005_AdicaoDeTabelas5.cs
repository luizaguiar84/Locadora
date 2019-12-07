using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class AdicaoDeTabelas5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoRetorno",
                table: "ControlePatio");

            migrationBuilder.DropColumn(
                name: "LiberadoSaida",
                table: "ControlePatio");

            migrationBuilder.DropColumn(
                name: "RecolhidoRetorno",
                table: "ControlePatio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoRetorno",
                table: "ControlePatio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiberadoSaida",
                table: "ControlePatio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecolhidoRetorno",
                table: "ControlePatio",
                nullable: true);
        }
    }
}
