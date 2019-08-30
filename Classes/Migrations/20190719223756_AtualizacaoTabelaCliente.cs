using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class AtualizacaoTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "StatusCliente",
                table: "Cliente");

            migrationBuilder.AlterColumn<bool>(
                name: "VidroEletrico",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DirecaoHidraulica",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ArCondicionado",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AirBag",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Abs",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAtivo",
                table: "Veiculos",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pneus",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraFinal",
                table: "Locacao",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraInicio",
                table: "Locacao",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<bool>(
                name: "IsAtivo",
                table: "Funcionarios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "TipoDespesaId",
                table: "Despesas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAtiva",
                table: "Despesas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAtivo",
                table: "Cliente",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas",
                column: "TipoDespesaId",
                principalTable: "TipoDespesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "IsAtivo",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "HoraFinal",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "IsAtivo",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "IsAtiva",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "IsAtivo",
                table: "Cliente");

            migrationBuilder.AlterColumn<short>(
                name: "VidroEletrico",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<short>(
                name: "DirecaoHidraulica",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<short>(
                name: "ArCondicionado",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<short>(
                name: "AirBag",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<short>(
                name: "Abs",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "TipoDespesaId",
                table: "Despesas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "Despesas",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<short>(
                name: "StatusCliente",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                table: "Despesas",
                column: "TipoDespesaId",
                principalTable: "TipoDespesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
