using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class MaisClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Cnh",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CnhCategoria",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CnhEmissao",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CnhValidade",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Num",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Cnh",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CnhCategoria",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CnhEmissao",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CnhValidade",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EnderecoCliente",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "TituloEleitor",
                table: "Funcionarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pis",
                table: "Funcionarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Demissao",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Ctps",
                table: "Funcionarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Funcionarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CnhId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CnhId",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cliente",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Combustivel = table.Column<string>(nullable: true),
                    Litros = table.Column<float>(nullable: false),
                    ValorUnitario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cnh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(maxLength: 20, nullable: true),
                    Categoria = table.Column<string>(maxLength: 2, nullable: true),
                    Emissao = table.Column<DateTime>(nullable: true),
                    Validade = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cnh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    Status = table.Column<short>(nullable: true),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    KmInicial = table.Column<int>(nullable: false),
                    KmFinal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cores = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    DataManutencao = table.Column<DateTime>(nullable: false),
                    KmManutencao = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 250, nullable: true),
                    ValorManutencao = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataMulta = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 200, nullable: true),
                    Vencimento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Pontos = table.Column<int>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obrigacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<string>(maxLength: 100, nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obrigacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pecas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinistros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinistros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nivel = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MontadoraId = table.Column<int>(nullable: false),
                    ModeloId = table.Column<int>(nullable: false),
                    AnoFabricacao = table.Column<int>(nullable: false),
                    AnoModelo = table.Column<int>(nullable: false),
                    Portas = table.Column<int>(nullable: false),
                    CorId = table.Column<int>(nullable: false),
                    Placa = table.Column<string>(nullable: true),
                    Renavam = table.Column<string>(nullable: true),
                    Chassi = table.Column<string>(nullable: true),
                    Lugares = table.Column<int>(nullable: false),
                    Quilometragem = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Combustivel = table.Column<string>(nullable: true),
                    ValorDiaria = table.Column<decimal>(nullable: false),
                    DataAquisicao = table.Column<DateTime>(nullable: false),
                    ArCondicionado = table.Column<short>(nullable: true),
                    DirecaoHidraulica = table.Column<short>(nullable: true),
                    VidroEletrico = table.Column<short>(nullable: true),
                    AirBag = table.Column<short>(nullable: true),
                    Abs = table.Column<short>(nullable: true),
                    CONTRATOCARRO_IDCONTRATOCARRO = table.Column<int>(nullable: false),
                    MANUTENCAO_IDMANUTENCAO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CnhId",
                table: "Funcionarios",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EnderecoId",
                table: "Funcionarios",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CnhId",
                table: "Cliente",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Cnh_CnhId",
                table: "Cliente",
                column: "CnhId",
                principalTable: "Cnh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Cnh_CnhId",
                table: "Funcionarios",
                column: "CnhId",
                principalTable: "Cnh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Endereco_EnderecoId",
                table: "Funcionarios",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Cnh_CnhId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cnh_CnhId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Endereco_EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "Cnh");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Obrigacoes");

            migrationBuilder.DropTable(
                name: "Pecas");

            migrationBuilder.DropTable(
                name: "Sinistros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_CnhId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_CnhId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CnhId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CnhId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "TituloEleitor",
                table: "Funcionarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Pis",
                table: "Funcionarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Demissao",
                table: "Funcionarios",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ctps",
                table: "Funcionarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Funcionarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Funcionarios",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Funcionarios",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Funcionarios",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cnh",
                table: "Funcionarios",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CnhCategoria",
                table: "Funcionarios",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CnhEmissao",
                table: "Funcionarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CnhValidade",
                table: "Funcionarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Funcionarios",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Funcionarios",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num",
                table: "Funcionarios",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "Funcionarios",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Cnh",
                table: "Cliente",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CnhCategoria",
                table: "Cliente",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CnhEmissao",
                table: "Cliente",
                maxLength: 20,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CnhValidade",
                table: "Cliente",
                maxLength: 20,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EnderecoCliente",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);
        }
    }
}
