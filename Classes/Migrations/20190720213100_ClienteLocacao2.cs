using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class ClienteLocacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Locacao",
                newName: "SeguroTerceiros");

            migrationBuilder.AddColumn<bool>(
                name: "IsAtiva",
                table: "Locacao",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SeguroCarro",
                table: "Locacao",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAtiva",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "SeguroCarro",
                table: "Locacao");

            migrationBuilder.RenameColumn(
                name: "SeguroTerceiros",
                table: "Locacao",
                newName: "Status");
        }
    }
}
