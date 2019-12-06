using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class MudancaClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Funcionarios_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "ClienteLocacao",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteLocacao_ClienteId",
                table: "ClienteLocacao",
                newName: "IX_ClienteLocacao_FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Funcionarios_FuncionarioId",
                table: "ClienteLocacao",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Funcionarios_FuncionarioId",
                table: "ClienteLocacao");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "ClienteLocacao",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteLocacao_FuncionarioId",
                table: "ClienteLocacao",
                newName: "IX_ClienteLocacao_ClienteId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Funcionarios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Funcionarios_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
