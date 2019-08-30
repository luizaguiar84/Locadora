using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoCliente = table.Column<string>(maxLength: 2, nullable: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: true),
                    Cpf = table.Column<string>(maxLength: 20, nullable: true),
                    Cnpj = table.Column<string>(maxLength: 20, nullable: true),
                    Profissao = table.Column<string>(maxLength: 50, nullable: true),
                    Contato = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    Rg = table.Column<string>(maxLength: 20, nullable: true),
                    Ie = table.Column<string>(maxLength: 20, nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: true),
                    TelComercial = table.Column<string>(maxLength: 14, nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 14, nullable: true),
                    TelCelular = table.Column<string>(maxLength: 14, nullable: true),
                    Cnh = table.Column<string>(maxLength: 20, nullable: true),
                    CnhCategoria = table.Column<string>(maxLength: 2, nullable: true),
                    CnhEmissao = table.Column<DateTime>(maxLength: 20, nullable: false),
                    CnhValidade = table.Column<DateTime>(maxLength: 20, nullable: false),
                    StatusCliente = table.Column<short>(nullable: true),
                    EnderecoCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 250, nullable: true),
                    Cpf = table.Column<string>(maxLength: 20, nullable: true),
                    Rg = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 20, nullable: true),
                    TelCelular = table.Column<string>(maxLength: 20, nullable: true),
                    Salario = table.Column<decimal>(nullable: false),
                    Admissao = table.Column<DateTime>(nullable: false),
                    Ctps = table.Column<string>(maxLength: 20, nullable: true),
                    Pis = table.Column<string>(maxLength: 20, nullable: true),
                    TituloEleitor = table.Column<string>(maxLength: 20, nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Demissao = table.Column<DateTime>(nullable: false),
                    Cnh = table.Column<string>(maxLength: 20, nullable: true),
                    CnhCategoria = table.Column<string>(maxLength: 2, nullable: true),
                    CnhEmissao = table.Column<DateTime>(nullable: false),
                    CnhValidade = table.Column<DateTime>(nullable: false),
                    Cep = table.Column<string>(maxLength: 9, nullable: true),
                    Logradouro = table.Column<string>(maxLength: 200, nullable: true),
                    Num = table.Column<string>(maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(maxLength: 200, nullable: true),
                    Bairro = table.Column<string>(maxLength: 200, nullable: true),
                    Cidade = table.Column<string>(maxLength: 200, nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
