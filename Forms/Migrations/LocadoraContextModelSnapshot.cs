﻿// <auto-generated />
using System;
using Forms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forms.Migrations
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

            modelBuilder.Entity("Forms.Models.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cores");

                    b.HasKey("Id");

                    b.ToTable("Cor");
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

            modelBuilder.Entity("Forms.Models.Veiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Abs");

                    b.Property<short?>("AirBag");

                    b.Property<int>("AnoFabricacao");

                    b.Property<int>("AnoModelo");

                    b.Property<short?>("ArCondicionado");

                    b.Property<int>("CONTRATOCARRO_IDCONTRATOCARRO");

                    b.Property<string>("Chassi");

                    b.Property<string>("Combustivel");

                    b.Property<int>("CorId");

                    b.Property<DateTime>("DataAquisicao");

                    b.Property<short?>("DirecaoHidraulica");

                    b.Property<int>("Lugares");

                    b.Property<int>("MANUTENCAO_IDMANUTENCAO");

                    b.Property<int>("ModeloId");

                    b.Property<int>("MontadoraId");

                    b.Property<string>("Placa");

                    b.Property<int>("Portas");

                    b.Property<int>("Quilometragem");

                    b.Property<string>("Renavam");

                    b.Property<string>("Status");

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

            modelBuilder.Entity("Forms.Models.Funcionarios", b =>
                {
                    b.HasOne("Forms.Models.Cnh", "Cnh")
                        .WithMany()
                        .HasForeignKey("CnhId");

                    b.HasOne("Forms.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
