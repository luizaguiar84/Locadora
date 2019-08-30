using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class NovosCamposVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorSeguro",
                table: "Locacoes",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorSeguroTerceiros",
                table: "Locacoes",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorSeguro",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "ValorSeguroTerceiros",
                table: "Locacoes");
        }
    }
}
