﻿// <auto-generated />
using System;
using Forms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forms.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20190717061326_ControleEstoque")]
    partial class ControleEstoque
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Forms.Models.Abastecimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Combustivel");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Km");

                    b.Property<float>("Litros");

                    b.Property<decimal>("ValorUnitario");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("Abastecimentos");
                });

            modelBuilder.Entity("Forms.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CnhId");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(20);

                    b.Property<string>("Contato")
                        .HasMaxLength(200);

                    b.Property<string>("Cpf")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Ie")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Profissao")
                        .HasMaxLength(50);

                    b.Property<string>("Rg")
                        .HasMaxLength(20);

                    b.Property<short?>("StatusCliente");

                    b.Property<string>("TelCelular")
                        .HasMaxLength(14);

                    b.Property<string>("TelComercial")
                        .HasMaxLength(14);

                    b.Property<string>("TelResidencial")
                        .HasMaxLength(14);

                    b.Property<string>("TipoCliente")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("CnhId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Forms.Models.Cnh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .HasMaxLength(2);

                    b.Property<DateTime?>("Emissao");

                    b.Property<string>("Numero")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Validade");

                    b.HasKey("Id");

                    b.ToTable("Cnh");
                });

            modelBuilder.Entity("Forms.Models.Contratos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataContrato");

                    b.Property<DateTime?>("DataFinal");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<int>("KmFinal");

                    b.Property<int>("KmInicial");

                    b.Property<short?>("Status");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Forms.Models.ControlePatio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<string>("EstadoRetorno");

                    b.Property<int>("KmRetorno");

                    b.Property<int>("KmSaida");

                    b.Property<string>("LiberadoSaida");

                    b.Property<string>("NivelCombustivelRetorno");

                    b.Property<string>("NivelCombustivelSaida");

                    b.Property<string>("ObservacoesSaida");

                    b.Property<string>("Placa");

                    b.Property<string>("RecolhidoRetorno");

                    b.Property<DateTime?>("RetornoPatio");

                    b.Property<DateTime?>("SaidaPatio");

                    b.Property<short?>("Status");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("ControlePatio");
                });

            modelBuilder.Entity("Forms.Models.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Cor");
                });

            modelBuilder.Entity("Forms.Models.Despesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<short>("Status");

                    b.Property<int?>("TipoDespesaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("TipoDespesaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Forms.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(200);

                    b.Property<string>("Cep")
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .HasMaxLength(200);

                    b.Property<string>("Complemento")
                        .HasMaxLength(200);

                    b.Property<string>("Logradouro")
                        .HasMaxLength(200);

                    b.Property<string>("Num")
                        .HasMaxLength(10);

                    b.Property<string>("Uf")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Forms.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAdicao");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<string>("Descricao");

                    b.Property<string>("IncluidoPor");

                    b.Property<string>("Observacoes");

                    b.Property<string>("Peca");

                    b.Property<int>("Quantidade");

                    b.Property<string>("RetiradoPor");

                    b.Property<decimal>("ValorUnitario");

                    b.HasKey("Id");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("Forms.Models.Funcionarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Admissao");

                    b.Property<int?>("CnhId");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Ctps")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Demissao");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<int?>("EnderecoId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Observacoes");

                    b.Property<string>("Pis")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Rg")
                        .HasMaxLength(20);

                    b.Property<decimal>("Salario");

                    b.Property<string>("TelCelular")
                        .HasMaxLength(20);

                    b.Property<string>("TelResidencial")
                        .HasMaxLength(20);

                    b.Property<string>("TituloEleitor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CnhId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Forms.Models.Manutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataManutencao");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250);

                    b.Property<int>("KmManutencao");

                    b.Property<decimal>("ValorManutencao");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("Manutencao");
                });

            modelBuilder.Entity("Forms.Models.Modelos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MontadoraId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("MontadoraId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("Forms.Models.Montadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeFipe");

                    b.HasKey("Id");

                    b.ToTable("Montadoras");
                });

            modelBuilder.Entity("Forms.Models.Multas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataMulta");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.Property<int>("Pontos");

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.Property<DateTime>("Vencimento");

                    b.HasKey("Id");

                    b.ToTable("Multas");
                });

            modelBuilder.Entity("Forms.Models.Obrigacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250);

                    b.Property<string>("Tipo")
                        .HasMaxLength(100);

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("Obrigacoes");
                });

            modelBuilder.Entity("Forms.Models.Pecas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Pecas");
                });

            modelBuilder.Entity("Forms.Models.Pneus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KmAtual");

                    b.Property<int>("KmInicial");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("Pneus");
                });

            modelBuilder.Entity("Forms.Models.Sinistros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<int>("Km");

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("Sinistros");
                });

            modelBuilder.Entity("Forms.Models.Teste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Teste");
                });

            modelBuilder.Entity("Forms.Models.TipoDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("TipoDespesa");
                });

            modelBuilder.Entity("Forms.Models.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login");

                    b.Property<int>("Nivel");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Forms.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Abs");

                    b.Property<short?>("AirBag");

                    b.Property<string>("AnoModelo");

                    b.Property<short?>("ArCondicionado");

                    b.Property<int>("CONTRATOCARRO_IDCONTRATOCARRO");

                    b.Property<string>("Chassi");

                    b.Property<string>("Combustivel");

                    b.Property<string>("Cor");

                    b.Property<DateTime?>("DataAquisicao");

                    b.Property<short?>("DirecaoHidraulica");

                    b.Property<int>("Lugares");

                    b.Property<int>("MANUTENCAO_IDMANUTENCAO");

                    b.Property<string>("Modelo");

                    b.Property<string>("Montadora");

                    b.Property<string>("Observacoes");

                    b.Property<string>("Placa");

                    b.Property<int>("PneuId");

                    b.Property<int>("Portas");

                    b.Property<int>("Quilometragem");

                    b.Property<string>("Renavam");

                    b.Property<string>("Status");

                    b.Property<string>("ValorAtual");

                    b.Property<decimal>("ValorDiaria");

                    b.Property<short?>("VidroEletrico");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Forms.Models.Cliente", b =>
                {
                    b.HasOne("Forms.Models.Cnh", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId");

                    b.HasOne("Forms.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Forms.Models.Despesas", b =>
                {
                    b.HasOne("Forms.Models.TipoDespesa", "TipoDespesa")
                        .WithMany()
                        .HasForeignKey("TipoDespesaId");
                });

            modelBuilder.Entity("Forms.Models.Funcionarios", b =>
                {
                    b.HasOne("Forms.Models.Cnh", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId");

                    b.HasOne("Forms.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Forms.Models.Modelos", b =>
                {
                    b.HasOne("Forms.Models.Montadora", "Montadora")
                        .WithMany()
                        .HasForeignKey("MontadoraId");
                });
#pragma warning restore 612, 618
        }
    }
}
