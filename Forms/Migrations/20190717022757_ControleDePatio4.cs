using Microsoft.EntityFrameworkCore.Migrations;

namespace Forms.Migrations
{
    public partial class ControleDePatio4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<decimal>(
                name: "KmSaida",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "KmRetorno",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KmSaida",
                table: "ControlePatio",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "KmRetorno",
                table: "ControlePatio",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
