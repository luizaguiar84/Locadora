using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class Multas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Multas");

            migrationBuilder.AddColumn<int>(
                name: "MultasId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MultasId",
                table: "Veiculos",
                column: "MultasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Multas_MultasId",
                table: "Veiculos",
                column: "MultasId",
                principalTable: "Multas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Multas_MultasId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_MultasId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "MultasId",
                table: "Veiculos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Multas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Multas",
                nullable: false,
                defaultValue: 0);
        }
    }
}
