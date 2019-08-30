using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class Multas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas");

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
