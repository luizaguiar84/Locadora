using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class tabelaCargos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Funcionarios_FuncionariosId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_FuncionariosId",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FuncionariosId",
                table: "Usuarios",
                column: "FuncionariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Funcionarios_FuncionariosId",
                table: "Usuarios",
                column: "FuncionariosId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
