﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class tabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_ClientesPJ_ClientesPJId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_ClienteLocacao_ClientesPJId",
                table: "ClienteLocacao");

            migrationBuilder.DropColumn(
                name: "ClientesPJId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "ClientesPJId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "ClientesPJId",
                table: "ClienteLocacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientesPJId",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientesPJId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientesPJId",
                table: "ClienteLocacao",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ClientesPJId",
                table: "Veiculos",
                column: "ClientesPJId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_ClientesPJId",
                table: "Funcionarios",
                column: "ClientesPJId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteLocacao_ClientesPJId",
                table: "ClienteLocacao",
                column: "ClientesPJId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_ClientesPJ_ClientesPJId",
                table: "ClienteLocacao",
                column: "ClientesPJId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_ClientesPJ_ClientesPJId",
                table: "Funcionarios",
                column: "ClientesPJId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_ClientesPJ_ClientesPJId",
                table: "Veiculos",
                column: "ClientesPJId",
                principalTable: "ClientesPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
