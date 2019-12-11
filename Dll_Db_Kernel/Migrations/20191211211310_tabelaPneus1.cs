using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class tabelaPneus1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pneus");

            migrationBuilder.DropColumn(
                name: "KmInicial",
                table: "Pneus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pneus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KmInicial",
                table: "Pneus",
                nullable: false,
                defaultValue: 0);
        }
    }
}
