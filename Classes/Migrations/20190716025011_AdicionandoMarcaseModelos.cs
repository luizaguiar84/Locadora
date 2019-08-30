using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class AdicionandoMarcaseModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MontadoraId",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CorId",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Montadoras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
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
                    Nome = table.Column<string>(nullable: true),
                    MontadoraId = table.Column<int>(nullable: true)
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
                name: "IX_Veiculos_CorId",
                table: "Veiculos",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ModeloId",
                table: "Veiculos",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MontadoraId",
                table: "Veiculos",
                column: "MontadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MontadoraId",
                table: "Modelos",
                column: "MontadoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Cor_CorId",
                table: "Veiculos",
                column: "CorId",
                principalTable: "Cor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Modelos_ModeloId",
                table: "Veiculos",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Montadoras_MontadoraId",
                table: "Veiculos",
                column: "MontadoraId",
                principalTable: "Montadoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Cor_CorId",
                table: "Veiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Modelos_ModeloId",
                table: "Veiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Montadoras_MontadoraId",
                table: "Veiculos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Montadoras");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_CorId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_ModeloId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_MontadoraId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Funcionarios");

            migrationBuilder.AlterColumn<int>(
                name: "MontadoraId",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CorId",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
