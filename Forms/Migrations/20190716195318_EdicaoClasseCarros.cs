using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forms.Migrations
{
    public partial class EdicaoClasseCarros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AnoFabricacao",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "CorId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "MontadoraId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Cores",
                table: "Cor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAquisicao",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "AnoModelo",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Montadora",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValorAtual",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Montadoras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeFipe",
                table: "Montadoras",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Montadora",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "ValorAtual",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Montadoras");

            migrationBuilder.DropColumn(
                name: "NomeFipe",
                table: "Montadoras");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAquisicao",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnoModelo",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnoFabricacao",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MontadoraId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cores",
                table: "Cor",
                nullable: true);

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
    }
}
