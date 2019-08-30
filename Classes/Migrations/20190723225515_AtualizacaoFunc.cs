using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class AtualizacaoFunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Funcionarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CnhId",
                table: "Funcionarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CnhId",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
