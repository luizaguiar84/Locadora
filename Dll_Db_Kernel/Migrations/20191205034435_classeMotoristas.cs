using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class classeMotoristas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_ClientesPF_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientesPF_Cnhs_CnhId",
                table: "ClientesPF");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientesPF_Enderecos_EnderecoId",
                table: "ClientesPF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientesPF",
                table: "ClientesPF");

            migrationBuilder.RenameTable(
                name: "ClientesPF",
                newName: "Motoristas");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesPF_EnderecoId",
                table: "Motoristas",
                newName: "IX_Motoristas_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesPF_CnhId",
                table: "Motoristas",
                newName: "IX_Motoristas_CnhId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motoristas",
                table: "Motoristas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Motoristas_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "Motoristas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Cnhs_CnhId",
                table: "Motoristas",
                column: "CnhId",
                principalTable: "Cnhs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Enderecos_EnderecoId",
                table: "Motoristas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Motoristas_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Cnhs_CnhId",
                table: "Motoristas");

            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Enderecos_EnderecoId",
                table: "Motoristas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Motoristas",
                table: "Motoristas");

            migrationBuilder.RenameTable(
                name: "Motoristas",
                newName: "ClientesPF");

            migrationBuilder.RenameIndex(
                name: "IX_Motoristas_EnderecoId",
                table: "ClientesPF",
                newName: "IX_ClientesPF_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Motoristas_CnhId",
                table: "ClientesPF",
                newName: "IX_ClientesPF_CnhId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientesPF",
                table: "ClientesPF",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_ClientesPF_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "ClientesPF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesPF_Cnhs_CnhId",
                table: "ClientesPF",
                column: "CnhId",
                principalTable: "Cnhs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesPF_Enderecos_EnderecoId",
                table: "ClientesPF",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
