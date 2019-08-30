using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Classes.Migrations
{
    public partial class AtualizaNomes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Cliente_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Locacao_LocacaoId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cnh_CnhId",
                table: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "Cnh");

            migrationBuilder.CreateTable(
                name: "Cnhs",
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
                    table.PrimaryKey("PK_Cnhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    SinistroId = table.Column<int>(nullable: true),
                    IsAtiva = table.Column<bool>(nullable: false),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    HoraInicio = table.Column<TimeSpan>(nullable: true),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    HoraFinal = table.Column<TimeSpan>(nullable: true),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    ValorAntecipado = table.Column<decimal>(nullable: false),
                    FormaDePagamento = table.Column<string>(nullable: true),
                    KmInicial = table.Column<int>(nullable: false),
                    KmDevolucao = table.Column<int>(nullable: false),
                    LiberadoPor = table.Column<string>(nullable: true),
                    RecebidoPor = table.Column<string>(nullable: true),
                    NivelCombustivel = table.Column<string>(nullable: true),
                    SeguroCarro = table.Column<bool>(nullable: false),
                    SeguroTerceiros = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacoes_Sinistros_SinistroId",
                        column: x => x.SinistroId,
                        principalTable: "Sinistros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacoes_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manutencoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 250, nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencoes_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAtivo = table.Column<bool>(nullable: false),
                    TipoCliente = table.Column<string>(maxLength: 2, nullable: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
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
                    CnhId = table.Column<int>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Cnhs_CnhId",
                        column: x => x.CnhId,
                        principalTable: "Cnhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CnhId",
                table: "Clientes",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_SinistroId",
                table: "Locacoes",
                column: "SinistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_VeiculoId",
                table: "Locacoes",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencoes_VeiculoId",
                table: "Manutencoes",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Clientes_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Locacoes_LocacaoId",
                table: "ClienteLocacao",
                column: "LocacaoId",
                principalTable: "Locacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Cnhs_CnhId",
                table: "Funcionarios",
                column: "CnhId",
                principalTable: "Cnhs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Clientes_ClienteId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteLocacao_Locacoes_LocacaoId",
                table: "ClienteLocacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cnhs_CnhId",
                table: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "Manutencoes");

            migrationBuilder.DropTable(
                name: "Cnhs");

            migrationBuilder.CreateTable(
                name: "Cnh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(maxLength: 2, nullable: true),
                    Emissao = table.Column<DateTime>(nullable: true),
                    Numero = table.Column<string>(maxLength: 20, nullable: true),
                    Validade = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cnh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    FormaDePagamento = table.Column<string>(nullable: true),
                    HoraFinal = table.Column<TimeSpan>(nullable: true),
                    HoraInicio = table.Column<TimeSpan>(nullable: true),
                    IsAtiva = table.Column<bool>(nullable: false),
                    KmDevolucao = table.Column<int>(nullable: false),
                    KmInicial = table.Column<int>(nullable: false),
                    LiberadoPor = table.Column<string>(nullable: true),
                    NivelCombustivel = table.Column<string>(nullable: true),
                    RecebidoPor = table.Column<string>(nullable: true),
                    SeguroCarro = table.Column<bool>(nullable: false),
                    SeguroTerceiros = table.Column<bool>(nullable: false),
                    SinistroId = table.Column<int>(nullable: true),
                    ValorAntecipado = table.Column<decimal>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacao_Sinistros_SinistroId",
                        column: x => x.SinistroId,
                        principalTable: "Sinistros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacao_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 250, nullable: true),
                    Km = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencao_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CnhId = table.Column<int>(nullable: true),
                    Cnpj = table.Column<string>(maxLength: 20, nullable: true),
                    Contato = table.Column<string>(maxLength: 200, nullable: true),
                    Cpf = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    EnderecoId = table.Column<int>(nullable: true),
                    Ie = table.Column<string>(maxLength: 20, nullable: true),
                    IsAtivo = table.Column<bool>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Profissao = table.Column<string>(maxLength: 50, nullable: true),
                    Rg = table.Column<string>(maxLength: 20, nullable: true),
                    TelCelular = table.Column<string>(maxLength: 14, nullable: true),
                    TelComercial = table.Column<string>(maxLength: 14, nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 14, nullable: true),
                    TipoCliente = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Cnh_CnhId",
                        column: x => x.CnhId,
                        principalTable: "Cnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CnhId",
                table: "Cliente",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_SinistroId",
                table: "Locacao",
                column: "SinistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_VeiculoId",
                table: "Locacao",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_VeiculoId",
                table: "Manutencao",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Cliente_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteLocacao_Locacao_LocacaoId",
                table: "ClienteLocacao",
                column: "LocacaoId",
                principalTable: "Locacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Cnh_CnhId",
                table: "Funcionarios",
                column: "CnhId",
                principalTable: "Cnh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
