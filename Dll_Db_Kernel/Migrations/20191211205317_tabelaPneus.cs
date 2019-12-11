using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class tabelaPneus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus");

            migrationBuilder.AddColumn<int>(
                name: "VeiculosId",
                table: "Pneus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_VeiculosId",
                table: "Pneus",
                column: "VeiculosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pneus_Veiculos_VeiculosId",
                table: "Pneus",
                column: "VeiculosId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculosId",
                table: "Pneus");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculosId",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "VeiculosId",
                table: "Pneus");

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
