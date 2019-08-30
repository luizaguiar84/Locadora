using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ClienteLocacao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SinistroId",
                table: "Locacao",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SinistroId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
