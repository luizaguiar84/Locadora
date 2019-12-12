using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class AGORAVAIPNEU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pneus_Veiculos_VeiculosId",
                table: "Pneus");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Pneus_PneuId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_PneuId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Pneus_VeiculosId",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "PneuId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "VeiculosId",
                table: "Pneus");

            migrationBuilder.CreateTable(
                name: "VeiculosPneus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculosId = table.Column<int>(nullable: false),
                    PneusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosPneus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeiculosPneus_Pneus_PneusId",
                        column: x => x.PneusId,
                        principalTable: "Pneus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VeiculosPneus_Veiculos_VeiculosId",
                        column: x => x.VeiculosId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VeiculosPneus_PneusId",
                table: "VeiculosPneus",
                column: "PneusId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculosPneus_VeiculosId",
                table: "VeiculosPneus",
                column: "VeiculosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VeiculosPneus");

            migrationBuilder.AddColumn<int>(
                name: "PneuId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculosId",
                table: "Pneus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_PneuId",
                table: "Veiculos",
                column: "PneuId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Pneus_PneuId",
                table: "Veiculos",
                column: "PneuId",
                principalTable: "Pneus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
