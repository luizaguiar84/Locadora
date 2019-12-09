using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class atualizacaoTabelaAbastecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Km",
                table: "Abastecimentos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Km",
                table: "Abastecimentos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
