using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class estoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncluidoPor",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "RetiradoPor",
                table: "Estoque");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IncluidoPor",
                table: "Estoque",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Estoque",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetiradoPor",
                table: "Estoque",
                nullable: true);
        }
    }
}
