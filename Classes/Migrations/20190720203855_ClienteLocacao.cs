using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ClienteLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas");

            migrationBuilder.DropForeignKey(
                name: "FK_Obrigacoes_Veiculos_VeiculoId",
                table: "Obrigacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinistros_Veiculos_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropTable(
                name: "Teste");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Locacao");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAdicao",
                table: "Pneus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SinistroId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HoraInicio",
                table: "Locacao",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<string>(
                name: "NivelCombustivel",
                table: "Locacao",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClienteLocacao",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteLocacao", x => new { x.LocacaoId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_ClienteLocacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteLocacao_Locacao_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteLocacao_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas",
                column: "TipoDespesaId",
                principalTable: "TipoDespesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Obrigacoes_Veiculos_VeiculoId",
                table: "Obrigacoes",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinistros_Veiculos_VeiculoId",
                table: "Sinistros",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas");

            migrationBuilder.DropForeignKey(
                name: "FK_Obrigacoes_Veiculos_VeiculoId",
                table: "Obrigacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinistros_Veiculos_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropTable(
                name: "ClienteLocacao");

            migrationBuilder.DropColumn(
                name: "DataAdicao",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "NivelCombustivel",
                table: "Locacao");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Locacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SinistroId",
                table: "Locacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HoraInicio",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Locacao",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teste",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teste", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimentos_Veiculos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas",
                column: "TipoDespesaId",
                principalTable: "TipoDespesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Veiculos_VeiculoId",
                table: "Manutencao",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Veiculos_VeiculoId",
                table: "Multas",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinistros_Veiculos_VeiculoId",
                table: "Sinistros",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
