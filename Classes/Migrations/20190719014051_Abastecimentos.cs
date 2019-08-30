using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class Abastecimentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Litros",
                table: "Abastecimentos",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos");

            migrationBuilder.DropIndex(
                name: "IX_Abastecimentos_VeiculoId",
                table: "Abastecimentos");

            migrationBuilder.AlterColumn<float>(
                name: "Litros",
                table: "Abastecimentos",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
