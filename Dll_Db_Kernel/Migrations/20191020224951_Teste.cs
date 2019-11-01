using Microsoft.EntityFrameworkCore.Migrations;

namespace DbKernel.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ConfirmaSenha",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ie",
                table: "ClientesPJ",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ClientesPJ",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "ClientesPJ",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "TipoCliente",
                table: "ClientesPF",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ConfirmaSenha",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ie",
                table: "ClientesPJ",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ClientesPJ",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "ClientesPJ",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "TipoCliente",
                table: "ClientesPF",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 2);
        }
    }
}
