﻿// <auto-generated />
using System;
using Dll_Db_Kernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dll_Db_Kernel.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20191012222445_nova")]
    partial class nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dll_BS_Fat.Abastecimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Combustivel");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Km");

                    b.Property<decimal>("Litros");

                    b.Property<decimal>("ValorUnitario");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Abastecimentos");
                });

            modelBuilder.Entity("Dll_BS_Fat.ClienteLocacao", b =>
                {
                    b.Property<int>("LocacaoId");

                    b.Property<int>("ClienteId");

                    b.Property<int?>("ClientesPJId");

                    b.HasKey("LocacaoId", "ClienteId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ClientesPJId");

                    b.ToTable("ClienteLocacao");
                });

            modelBuilder.Entity("Dll_BS_Fat.ClientesPF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CnhId");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EnderecoId");

                    b.Property<bool>("IsAtivo");

                    b.Property<DateTime?>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Profissao")
                        .HasMaxLength(50);

                    b.Property<string>("Rg")
                        .HasMaxLength(20);

                    b.Property<string>("TelCelular")
                        .HasMaxLength(14);

                    b.Property<string>("TelComercial");

                    b.Property<string>("TelResidencial")
                        .HasMaxLength(14);

                    b.Property<int>("TipoCliente")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("CnhId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("ClientesPF");
                });

            modelBuilder.Entity("Dll_BS_Fat.ClientesPJ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(17);

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Ie")
                        .IsRequired()
                        .HasMaxLength(17);

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("RazaoSocial")
                        .IsRequired();

                    b.Property<string>("TelComercial")
                        .HasMaxLength(14);

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("ClientesPJ");
                });

            modelBuilder.Entity("Dll_BS_Fat.Cnhs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<DateTime?>("Emissao");

                    b.Property<string>("Numero")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Validade");

                    b.HasKey("Id");

                    b.ToTable("Cnhs");
                });

            modelBuilder.Entity("Dll_BS_Fat.ControlePatio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime?>("DataRetorno");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<string>("EstadoRetorno");

                    b.Property<TimeSpan?>("HoraRetorno");

                    b.Property<TimeSpan?>("HoraSaida");

                    b.Property<int>("KmRetorno");

                    b.Property<int>("KmSaida");

                    b.Property<string>("LiberadoSaida");

                    b.Property<string>("NivelCombustivelRetorno");

                    b.Property<string>("NivelCombustivelSaida");

                    b.Property<string>("ObservacoesSaida");

                    b.Property<string>("Placa");

                    b.Property<string>("RecolhidoRetorno");

                    b.Property<bool>("Status");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("ControlePatio");
                });

            modelBuilder.Entity("Dll_BS_Fat.Despesas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<bool>("IsAtiva");

                    b.Property<int>("TipoDespesaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("TipoDespesaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Dll_BS_Fat.Enderecos", b =>
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

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Dll_BS_Fat.Estoque", b =>
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

            modelBuilder.Entity("Dll_BS_Fat.Funcionarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Admissao");

                    b.Property<int>("CnhId");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Ctps")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Demissao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EnderecoId");

                    b.Property<bool>("IsAtivo");

                    b.Property<DateTime?>("Nascimento")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Observacoes");

                    b.Property<string>("Pis")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Rg")
                        .IsRequired()
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

            modelBuilder.Entity("Dll_BS_Fat.Locacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataContrato");

                    b.Property<DateTime?>("DataFinal");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<string>("FormaDePagamento");

                    b.Property<TimeSpan?>("HoraFinal");

                    b.Property<TimeSpan?>("HoraInicio");

                    b.Property<bool>("IsAtiva");

                    b.Property<int>("KmDevolucao");

                    b.Property<int>("KmInicial");

                    b.Property<string>("LiberadoPor");

                    b.Property<string>("NivelCombustivel");

                    b.Property<string>("RecebidoPor");

                    b.Property<bool>("SeguroCarro");

                    b.Property<bool>("SeguroTerceiros");

                    b.Property<int?>("SinistroId");

                    b.Property<decimal>("ValorAntecipado");

                    b.Property<decimal>("ValorSeguro");

                    b.Property<decimal>("ValorSeguroTerceiros");

                    b.Property<decimal>("ValorTotal");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("SinistroId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Dll_BS_Fat.Manutencoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250);

                    b.Property<int>("Km");

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Manutencoes");
                });

            modelBuilder.Entity("Dll_BS_Fat.Multas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataMulta");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.Property<int>("Pontos");

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.Property<DateTime>("Vencimento");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Multas");
                });

            modelBuilder.Entity("Dll_BS_Fat.Obrigacoes", b =>
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

                    b.HasIndex("VeiculoId");

                    b.ToTable("Obrigacoes");
                });

            modelBuilder.Entity("Dll_BS_Fat.Pecas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Pecas");
                });

            modelBuilder.Entity("Dll_BS_Fat.Pneus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAdicao");

                    b.Property<string>("Estado");

                    b.Property<int>("KmAtual");

                    b.Property<int>("KmInicial");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Pneus");
                });

            modelBuilder.Entity("Dll_BS_Fat.Sinistros", b =>
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

                    b.HasIndex("VeiculoId");

                    b.ToTable("Sinistros");
                });

            modelBuilder.Entity("Dll_BS_Fat.TipoDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("TipoDespesa");
                });

            modelBuilder.Entity("Dll_BS_Fat.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmaSenha");

                    b.Property<int>("FuncionariosId");

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Nivel");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("FuncionariosId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dll_BS_Fat.Veiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Abs");

                    b.Property<bool>("AirBag");

                    b.Property<string>("AnoModelo");

                    b.Property<bool>("ArCondicionado");

                    b.Property<string>("Chassi");

                    b.Property<int?>("ClientesPJId");

                    b.Property<string>("Combustivel");

                    b.Property<string>("Cor");

                    b.Property<DateTime?>("DataAquisicao");

                    b.Property<bool>("DirecaoHidraulica");

                    b.Property<bool>("IsAtivo");

                    b.Property<int>("Lugares");

                    b.Property<string>("Modelo");

                    b.Property<string>("Montadora");

                    b.Property<string>("Observacoes");

                    b.Property<string>("Placa");

                    b.Property<int>("Portas");

                    b.Property<int>("Quilometragem");

                    b.Property<string>("Renavam");

                    b.Property<string>("Status");

                    b.Property<string>("ValorAtual");

                    b.Property<decimal>("ValorDiaria");

                    b.Property<bool>("VidroEletrico");

                    b.HasKey("Id");

                    b.HasIndex("ClientesPJId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Dll_BS_Fat.Abastecimentos", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Abastecimentos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.ClienteLocacao", b =>
                {
                    b.HasOne("Dll_BS_Fat.ClientesPF", "Cliente")
                        .WithMany("Locacao")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Dll_BS_Fat.ClientesPJ")
                        .WithMany("Locacao")
                        .HasForeignKey("ClientesPJId");

                    b.HasOne("Dll_BS_Fat.Locacoes", "Locacao")
                        .WithMany("Cliente")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.ClientesPF", b =>
                {
                    b.HasOne("Dll_BS_Fat.Cnhs", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Dll_BS_Fat.Enderecos", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.ClientesPJ", b =>
                {
                    b.HasOne("Dll_BS_Fat.Enderecos", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Despesas", b =>
                {
                    b.HasOne("Dll_BS_Fat.TipoDespesa", "TipoDespesa")
                        .WithMany()
                        .HasForeignKey("TipoDespesaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Funcionarios", b =>
                {
                    b.HasOne("Dll_BS_Fat.Cnhs", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Dll_BS_Fat.Enderecos", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Locacoes", b =>
                {
                    b.HasOne("Dll_BS_Fat.Sinistros", "Sinistro")
                        .WithMany()
                        .HasForeignKey("SinistroId");

                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Manutencoes", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Manutencao")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Multas", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Multas")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Obrigacoes", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Obrigacoes")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Pneus", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Pneu")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Sinistros", b =>
                {
                    b.HasOne("Dll_BS_Fat.Veiculos", "Veiculo")
                        .WithMany("Sinistros")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Usuarios", b =>
                {
                    b.HasOne("Dll_BS_Fat.Funcionarios", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionariosId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Dll_BS_Fat.Veiculos", b =>
                {
                    b.HasOne("Dll_BS_Fat.ClientesPJ")
                        .WithMany("ListaVeiculos")
                        .HasForeignKey("ClientesPJId");
                });
#pragma warning restore 612, 618
        }
    }
}
