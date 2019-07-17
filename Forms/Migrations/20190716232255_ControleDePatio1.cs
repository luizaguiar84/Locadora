using Microsoft.EntityFrameworkCore.Migrations;

namespace Forms.Migrations
{
    public partial class ControleDePatio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControlePatio_Cliente_ClienteId",
                table: "ControlePatio");

            migrationBuilder.DropForeignKey(
                name: "FK_ControlePatio_Veiculos_VeiculoId",
                table: "ControlePatio");

            migrationBuilder.DropIndex(
                name: "IX_ControlePatio_ClienteId",
                table: "ControlePatio");

            migrationBuilder.DropIndex(
                name: "IX_ControlePatio_VeiculoId",
                table: "ControlePatio");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ControlePatio_ClienteId",
                table: "ControlePatio",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlePatio_VeiculoId",
                table: "ControlePatio",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePatio_Cliente_ClienteId",
                table: "ControlePatio",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ControlePatio_Veiculos_VeiculoId",
                table: "ControlePatio",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
