using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class Reformulacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Motoristas_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropColumn(
                name: "Demissao",
                table: "Funcionarios");

            migrationBuilder.AlterColumn<int>(
                name: "CnhId",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(int));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Funcionarios_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Funcionarios");

            migrationBuilder.AlterColumn<int>(
                name: "CnhId",
                table: "Funcionarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Demissao",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CnhId = table.Column<int>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    EnderecoId = table.Column<int>(nullable: false),
                    IsAtivo = table.Column<bool>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Rg = table.Column<string>(maxLength: 20, nullable: false),
                    TelCelular = table.Column<string>(maxLength: 14, nullable: true),
                    TelComercial = table.Column<string>(nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motoristas_Cnhs_CnhId",
                        column: x => x.CnhId,
                        principalTable: "Cnhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motoristas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_CnhId",
                table: "Motoristas",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_EnderecoId",
                table: "Motoristas",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Motoristas_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "Motoristas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
