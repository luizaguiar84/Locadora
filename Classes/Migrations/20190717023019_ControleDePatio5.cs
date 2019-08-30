using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ControleDePatio5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "KmSaida",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "KmRetorno",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "KmSaida",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "KmRetorno",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
