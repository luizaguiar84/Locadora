using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class Multas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "CONTRATOCARRO_IDCONTRATOCARRO",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "MANUTENCAO_IDMANUTENCAO",
                table: "Veiculos");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Multas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas");

            migrationBuilder.AddColumn<int>(
                name: "CONTRATOCARRO_IDCONTRATOCARRO",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MANUTENCAO_IDMANUTENCAO",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Multas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
