using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class DespesasCarro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus");

            migrationBuilder.RenameColumn(
                name: "ValorManutencao",
                table: "Manutencao",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "KmManutencao",
                table: "Manutencao",
                newName: "Km");

            migrationBuilder.RenameColumn(
                name: "DataManutencao",
                table: "Manutencao",
                newName: "Data");

            migrationBuilder.CreateIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Obrigacoes_VeiculoId",
                table: "Obrigacoes",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_VeiculoId",
                table: "Manutencao",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obrigacoes_Veiculos_VeiculoId",
                table: "Obrigacoes",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Obrigacoes_Veiculos_VeiculoId",
                table: "Obrigacoes");

            migrationBuilder.DropIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropIndex(
                name: "IX_Obrigacoes_VeiculoId",
                table: "Obrigacoes");

            migrationBuilder.DropIndex(
                name: "IX_Manutencao_VeiculoId",
                table: "Manutencao");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Manutencao",
                newName: "ValorManutencao");

            migrationBuilder.RenameColumn(
                name: "Km",
                table: "Manutencao",
                newName: "KmManutencao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Manutencao",
                newName: "DataManutencao");

            migrationBuilder.CreateIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros",
                column: "VeiculoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus",
                column: "VeiculoId",
                unique: true);
        }
    }
}
