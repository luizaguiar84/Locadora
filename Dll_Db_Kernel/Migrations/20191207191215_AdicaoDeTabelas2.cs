using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class AdicaoDeTabelas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Cnhs",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "NivelAcesso",
                table: "Cargos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Cnhs",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "NivelAcesso",
                table: "Cargos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
