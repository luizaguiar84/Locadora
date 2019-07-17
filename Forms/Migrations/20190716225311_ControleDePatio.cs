using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forms.Migrations
{
    public partial class ControleDePatio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlePatio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    SaidaPatio = table.Column<DateTime>(nullable: true),
                    KmSaida = table.Column<int>(nullable: false),
                    NivelCombustivelSaida = table.Column<string>(nullable: true),
                    LiberadoSaida = table.Column<string>(nullable: true),
                    ObservacoesSaida = table.Column<string>(nullable: true),
                    RetornoPatio = table.Column<DateTime>(nullable: true),
                    EstadoRetorno = table.Column<string>(nullable: true),
                    NivelCombustivelRetorno = table.Column<string>(nullable: true),
                    KmRetorno = table.Column<string>(nullable: true),
                    RecolhidoRetorno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlePatio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlePatio_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlePatio_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlePatio_ClienteId",
                table: "ControlePatio",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePatio_VeiculoId",
                table: "ControlePatio",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlePatio");
        }
    }
}
