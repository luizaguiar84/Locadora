using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desktop_Fat.Migrations
{
    public partial class Atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ControlePatio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeiculoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    HoraSaida = table.Column<TimeSpan>(nullable: true),
                    KmSaida = table.Column<int>(nullable: false),
                    NivelCombustivelSaida = table.Column<string>(nullable: true),
                    LiberadoSaida = table.Column<string>(nullable: true),
                    ObservacoesSaida = table.Column<string>(nullable: true),
                    DataRetorno = table.Column<DateTime>(nullable: true),
                    HoraRetorno = table.Column<TimeSpan>(nullable: true),
                    EstadoRetorno = table.Column<string>(nullable: true),
                    NivelCombustivelRetorno = table.Column<string>(nullable: true),
                    KmRetorno = table.Column<int>(nullable: false),
                    RecolhidoRetorno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlePatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
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
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Peca = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ValorUnitario = table.Column<decimal>(nullable: false),
                    DataAdicao = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    Observacoes = table.Column<string>(nullable: true),
                    IncluidoPor = table.Column<string>(nullable: true),
                    RetiradoPor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
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
                name: "TipoDespesa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDespesa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Montadora = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    AnoModelo = table.Column<string>(nullable: true),
                    Portas = table.Column<int>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Renavam = table.Column<string>(nullable: true),
                    Chassi = table.Column<string>(nullable: true),
                    Lugares = table.Column<int>(nullable: false),
                    Quilometragem = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Combustivel = table.Column<string>(nullable: true),
                    ValorAtual = table.Column<string>(nullable: true),
                    ValorDiaria = table.Column<decimal>(nullable: false),
                    Observacoes = table.Column<string>(nullable: true),
                    DataAquisicao = table.Column<DateTime>(nullable: true),
                    ArCondicionado = table.Column<bool>(nullable: false),
                    DirecaoHidraulica = table.Column<bool>(nullable: false),
                    VidroEletrico = table.Column<bool>(nullable: false),
                    AirBag = table.Column<bool>(nullable: false),
                    Abs = table.Column<bool>(nullable: false),
                    IsAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
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
                    CnhId = table.Column<int>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: false)
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
                        name: "FK_Clientes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAtivo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(maxLength: 250, nullable: false),
                    Cpf = table.Column<string>(maxLength: 20, nullable: false),
                    Rg = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 20, nullable: true),
                    TelCelular = table.Column<string>(maxLength: 20, nullable: true),
                    Salario = table.Column<decimal>(nullable: false),
                    Admissao = table.Column<DateTime>(nullable: false),
                    Ctps = table.Column<string>(maxLength: 20, nullable: false),
                    Pis = table.Column<string>(maxLength: 20, nullable: false),
                    TituloEleitor = table.Column<string>(maxLength: 20, nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Demissao = table.Column<DateTime>(nullable: true),
                    CnhId = table.Column<int>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: false),
                    Observacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Cnhs_CnhId",
                        column: x => x.CnhId,
                        principalTable: "Cnhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAtiva = table.Column<bool>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    TipoDespesaId = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despesas_TipoDespesa_TipoDespesaId",
                        column: x => x.TipoDespesaId,
                        principalTable: "TipoDespesa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Combustivel = table.Column<string>(nullable: true),
                    Litros = table.Column<decimal>(nullable: false),
                    ValorUnitario = table.Column<decimal>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Veiculos_VeiculoId",
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
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multas_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obrigacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<string>(maxLength: 100, nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 250, nullable: true),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obrigacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obrigacoes_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pneus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    KmInicial = table.Column<int>(nullable: false),
                    KmAtual = table.Column<int>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false),
                    DataAdicao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pneus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pneus_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sinistros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinistros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinistros_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAtivo = table.Column<bool>(nullable: false),
                    Nivel = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FuncionariosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Funcionarios_FuncionariosId",
                        column: x => x.FuncionariosId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    SeguroTerceiros = table.Column<bool>(nullable: false),
                    ValorSeguro = table.Column<decimal>(nullable: false),
                    ValorSeguroTerceiros = table.Column<decimal>(nullable: false)
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
                name: "ClienteLocacao",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteLocacao", x => new { x.LocacaoId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_ClienteLocacao_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteLocacao_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteLocacao_ClienteId",
                table: "ClienteLocacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CnhId",
                table: "Clientes",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_TipoDespesaId",
                table: "Despesas",
                column: "TipoDespesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CnhId",
                table: "Funcionarios",
                column: "CnhId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EnderecoId",
                table: "Funcionarios",
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

            migrationBuilder.CreateIndex(
                name: "IX_Multas_VeiculoId",
                table: "Multas",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Obrigacoes_VeiculoId",
                table: "Obrigacoes",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_VeiculoId",
                table: "Pneus",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinistros_VeiculoId",
                table: "Sinistros",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FuncionariosId",
                table: "Usuarios",
                column: "FuncionariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "ClienteLocacao");

            migrationBuilder.DropTable(
                name: "ControlePatio");

            migrationBuilder.DropTable(
                name: "Despesas");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Manutencoes");

            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Obrigacoes");

            migrationBuilder.DropTable(
                name: "Pecas");

            migrationBuilder.DropTable(
                name: "Pneus");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "TipoDespesa");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Sinistros");

            migrationBuilder.DropTable(
                name: "Cnhs");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
