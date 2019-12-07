using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class AdicaoDeTabelas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Cnhs",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AddColumn<int>(
                name: "NivelAcesso",
                table: "Cargos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NivelAcesso",
                table: "Cargos");

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Cnhs",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 2);
        }
    }
}
