using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class testeUsuarioEPneu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionariosId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Pneus");

            migrationBuilder.AddColumn<int>(
                name: "PneuId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuariosId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_PneuId",
                table: "Veiculos",
                column: "PneuId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_UsuariosId",
                table: "Funcionarios",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Usuarios_UsuariosId",
                table: "Funcionarios",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Pneus_PneuId",
                table: "Veiculos",
                column: "PneuId",
                principalTable: "Pneus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Usuarios_UsuariosId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Pneus_PneuId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_PneuId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_UsuariosId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "PneuId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "Funcionarios");

            migrationBuilder.AddColumn<int>(
                name: "FuncionariosId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Pneus",
                nullable: false,
                defaultValue: 0);
        }
    }
}
