using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.AddColumn<int>(
                name: "ClientePjId",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientePjId",
                table: "Funcionarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ClientesPJ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ClientePjId",
                table: "Veiculos",
                column: "ClientePjId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_ClientePjId",
                table: "Funcionarios",
                column: "ClientePjId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesPJ_UsuarioId",
                table: "ClientesPJ",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesPJ_Usuarios_UsuarioId",
                table: "ClientesPJ",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientePjId",
                table: "Funcionarios",
                column: "ClientePjId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientePjId",
                table: "Veiculos",
                column: "ClientePjId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesPJ_Usuarios_UsuarioId",
                table: "ClientesPJ");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientePjId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientePjId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_ClientePjId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_ClientePjId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_ClientesPJ_UsuarioId",
                table: "ClientesPJ");

            migrationBuilder.DropColumn(
                name: "ClientePjId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "ClientePjId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ClientesPJ");

            migrationBuilder.AddColumn<int>(
                name: "ClientesPJId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientesPJId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ClientesPJId",
                table: "Veiculos",
                column: "ClientesPJId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_ClientesPJId",
                table: "Funcionarios",
                column: "ClientesPJId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientesPJId",
                table: "Funcionarios",
                column: "ClientesPJId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientesPJId",
                table: "Veiculos",
                column: "ClientesPJId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
