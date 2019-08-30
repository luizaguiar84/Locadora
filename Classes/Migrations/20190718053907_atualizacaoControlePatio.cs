using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class atualizacaoControlePatio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Montadoras");

            migrationBuilder.DropColumn(
                name: "PneuId",
                table: "Veiculos");

            migrationBuilder.RenameColumn(
                name: "SaidaPatio",
                table: "ControlePatio",
                newName: "DataSaida");

            migrationBuilder.RenameColumn(
                name: "RetornoPatio",
                table: "ControlePatio",
                newName: "DataRetorno");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraRetorno",
                table: "ControlePatio",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraSaida",
                table: "ControlePatio",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: true),
                    VeiculoId = table.Column<int>(nullable: true),
                    SinistroId = table.Column<int>(nullable: true),
                    Status = table.Column<short>(nullable: false),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    ValorAntecipado = table.Column<decimal>(nullable: false),
                    KmInicial = table.Column<int>(nullable: false),
                    KmDevolucao = table.Column<int>(nullable: false),
                    LiberadoPor = table.Column<string>(nullable: true),
                    RecebidoPor = table.Column<string>(nullable: true),
                    FormaDePagamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacao_Sinistros_SinistroId",
                        column: x => x.SinistroId,
                        principalTable: "Sinistros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacao_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_SinistroId",
                table: "Locacao",
                column: "SinistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_VeiculoId",
                table: "Locacao",
                column: "VeiculoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinistros_Veiculos_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "HoraRetorno",
                table: "ControlePatio");

            migrationBuilder.DropColumn(
                name: "HoraSaida",
                table: "ControlePatio");

            migrationBuilder.RenameColumn(
                name: "DataSaida",
                table: "ControlePatio",
                newName: "SaidaPatio");

            migrationBuilder.RenameColumn(
                name: "DataRetorno",
                table: "ControlePatio",
                newName: "RetornoPatio");

            migrationBuilder.AddColumn<int>(
                name: "PneuId",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    KmFinal = table.Column<int>(nullable: false),
                    KmInicial = table.Column<int>(nullable: false),
                    Status = table.Column<short>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Montadoras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    NomeFipe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Montadoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MontadoraId = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Montadoras_MontadoraId",
                        column: x => x.MontadoraId,
                        principalTable: "Montadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MontadoraId",
                table: "Modelos",
                column: "MontadoraId");
        }
    }
}
