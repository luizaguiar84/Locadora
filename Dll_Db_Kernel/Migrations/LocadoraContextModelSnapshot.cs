﻿// <auto-generated />
using System;
using DbKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbKernel.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    partial class LocadoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BsFat.Abastecimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Combustivel")
                        .IsRequired();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Km");

                    b.Property<decimal>("Litros");

                    b.Property<decimal>("ValorUnitario");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Abastecimentos");
                });

            modelBuilder.Entity("BsFat.Cargos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<string>("NivelAcesso");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("BsFat.ClienteLocacao", b =>
                {
                    b.Property<int>("LocacaoId");

                    b.Property<int>("FuncionarioId");

                    b.Property<int?>("ClientesPJId");

                    b.HasKey("LocacaoId", "FuncionarioId");

                    b.HasIndex("ClientesPJId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("ClienteLocacao");
                });

            modelBuilder.Entity("BsFat.ClientesPJ", b =>
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

                    b.Property<string>("TelCelular");

                    b.Property<string>("TelComercial")
                        .HasMaxLength(14);

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("ClientesPJ");
                });

            modelBuilder.Entity("BsFat.Cnhs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<DateTime>("Emissao");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("Validade");

                    b.HasKey("Id");

                    b.ToTable("Cnhs");
                });

            modelBuilder.Entity("BsFat.ControlePatio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime?>("DataRetorno");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<TimeSpan?>("HoraRetorno");

                    b.Property<TimeSpan?>("HoraSaida");

                    b.Property<int>("KmRetorno");

                    b.Property<int>("KmSaida");

                    b.Property<string>("NivelCombustivelRetorno");

                    b.Property<string>("NivelCombustivelSaida");

                    b.Property<string>("ObservacoesSaida");

                    b.Property<string>("Placa")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.ToTable("ControlePatio");
                });

            modelBuilder.Entity("BsFat.Despesas", b =>
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

            modelBuilder.Entity("BsFat.Enderecos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(200);

                    b.Property<string>("Cep")
                        .IsRequired()
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

            modelBuilder.Entity("BsFat.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAdicao");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<string>("Descricao");

                    b.Property<string>("IncluidoPor");

                    b.Property<string>("Observacoes");

                    b.Property<string>("Peca")
                        .IsRequired();

                    b.Property<int>("Quantidade");

                    b.Property<string>("RetiradoPor");

                    b.Property<decimal>("ValorUnitario");

                    b.HasKey("Id");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("BsFat.Funcionarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Admissao");

                    b.Property<int>("CargoId");

                    b.Property<int?>("ClientesPJId");

                    b.Property<int?>("CnhId");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Ctps")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EnderecoId");

                    b.Property<bool>("IsAtivo");

                    b.Property<DateTime>("Nascimento");

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

                    b.HasIndex("CargoId");

                    b.HasIndex("ClientesPJId");

                    b.HasIndex("CnhId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("BsFat.Locacoes", b =>
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

            modelBuilder.Entity("BsFat.Manutencoes", b =>
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

            modelBuilder.Entity("BsFat.Multas", b =>
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

            modelBuilder.Entity("BsFat.Obrigacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Valor");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Obrigacoes");
                });

            modelBuilder.Entity("BsFat.Pecas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Pecas");
                });

            modelBuilder.Entity("BsFat.Pneus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAdicao");

                    b.Property<string>("Estado");

                    b.Property<int>("KmAtual");

                    b.Property<int>("KmInicial");

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("Modelo");

                    b.Property<int>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Pneus");
                });

            modelBuilder.Entity("BsFat.Sinistros", b =>
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

            modelBuilder.Entity("BsFat.TipoDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoDespesa");
                });

            modelBuilder.Entity("BsFat.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmaSenha")
                        .IsRequired();

                    b.Property<int>("FuncionariosId");

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Nivel");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("FuncionariosId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BsFat.Veiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Abs");

                    b.Property<bool>("AirBag");

                    b.Property<string>("AnoModelo")
                        .IsRequired();

                    b.Property<bool>("ArCondicionado");

                    b.Property<string>("Chassi")
                        .IsRequired();

                    b.Property<int?>("ClientesPJId");

                    b.Property<string>("Combustivel")
                        .IsRequired();

                    b.Property<string>("Cor")
                        .IsRequired();

                    b.Property<DateTime?>("DataAquisicao")
                        .IsRequired();

                    b.Property<bool>("DirecaoHidraulica");

                    b.Property<bool>("Disponivel");

                    b.Property<bool>("IsAtivo");

                    b.Property<int>("Lugares");

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.Property<string>("Montadora")
                        .IsRequired();

                    b.Property<string>("Observacoes");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<int>("Portas");

                    b.Property<int>("Quilometragem");

                    b.Property<string>("Renavam")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("ValorAtual");

                    b.Property<bool>("VidroEletrico");

                    b.HasKey("Id");

                    b.HasIndex("ClientesPJId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("BsFat.Abastecimentos", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Abastecimentos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.ClienteLocacao", b =>
                {
                    b.HasOne("BsFat.ClientesPJ")
                        .WithMany("Locacao")
                        .HasForeignKey("ClientesPJId");

                    b.HasOne("BsFat.Funcionarios", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BsFat.Locacoes", "Locacao")
                        .WithMany("Cliente")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.ClientesPJ", b =>
                {
                    b.HasOne("BsFat.Enderecos", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Despesas", b =>
                {
                    b.HasOne("BsFat.TipoDespesa", "TipoDespesa")
                        .WithMany()
                        .HasForeignKey("TipoDespesaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Funcionarios", b =>
                {
                    b.HasOne("BsFat.Cargos", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BsFat.ClientesPJ")
                        .WithMany("ListaDeFuncionarios")
                        .HasForeignKey("ClientesPJId");

                    b.HasOne("BsFat.Cnhs", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId");

                    b.HasOne("BsFat.Enderecos", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Locacoes", b =>
                {
                    b.HasOne("BsFat.Sinistros", "Sinistro")
                        .WithMany()
                        .HasForeignKey("SinistroId");

                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Manutencoes", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Manutencao")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Multas", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Multas")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Obrigacoes", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Obrigacoes")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Pneus", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Pneu")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Sinistros", b =>
                {
                    b.HasOne("BsFat.Veiculos", "Veiculo")
                        .WithMany("Sinistros")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Usuarios", b =>
                {
                    b.HasOne("BsFat.Funcionarios", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionariosId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BsFat.Veiculos", b =>
                {
                    b.HasOne("BsFat.ClientesPJ")
                        .WithMany("ListaVeiculos")
                        .HasForeignKey("ClientesPJId");
                });
#pragma warning restore 612, 618
        }
    }
}
