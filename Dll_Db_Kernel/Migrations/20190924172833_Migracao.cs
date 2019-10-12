using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Dll_Db_Kernel.Migrations
{
	public partial class Migracao : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_ClienteLocacao_Pessoa_ClienteId",
				table: "ClienteLocacao");

			migrationBuilder.DropForeignKey(
				name: "FK_ClienteLocacao_Pessoa_ClientesPJId",
				table: "ClienteLocacao");

			migrationBuilder.DropForeignKey(
				name: "FK_Pessoa_Veiculos_VeiculosId",
				table: "Pessoa");

			migrationBuilder.DropForeignKey(
				name: "FK_Pessoa_Cnhs_CnhId",
				table: "Pessoa");

			migrationBuilder.DropForeignKey(
				name: "FK_Pessoa_Enderecos_EnderecoId",
				table: "Pessoa");

			migrationBuilder.DropForeignKey(
				name: "FK_Usuarios_Pessoa_FuncionariosId",
				table: "Usuarios");

			migrationBuilder.DropForeignKey(
				name: "FK_Veiculos_Pessoa_ClientesPJId",
				table: "Veiculos");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Pessoa",
				table: "Pessoa");

			migrationBuilder.DropIndex(
				name: "IX_Pessoa_VeiculosId",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Idade",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Profissao",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "TelComercial",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "TipoCliente",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Cnpj",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Contato",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Ie",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "ClientesPJ_TelComercial",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "VeiculosId",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Funcionarios_Cpf",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Funcionarios_Nascimento",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Funcionarios_Rg",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Funcionarios_TelCelular",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Funcionarios_TelResidencial",
				table: "Pessoa");

			migrationBuilder.DropColumn(
				name: "Discriminator",
				table: "Pessoa");

			migrationBuilder.RenameTable(
				name: "Pessoa",
				newName: "Funcionarios");

			migrationBuilder.RenameIndex(
				name: "IX_Pessoa_EnderecoId",
				table: "Funcionarios",
				newName: "IX_Funcionarios_EnderecoId");

			migrationBuilder.RenameIndex(
				name: "IX_Pessoa_CnhId",
				table: "Funcionarios",
				newName: "IX_Funcionarios_CnhId");

			migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "Usuarios",
				maxLength: 10,
				nullable: false,
				oldClrType: typeof(string),
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Login",
				table: "Usuarios",
				maxLength: 50,
				nullable: false,
				oldClrType: typeof(string),
				oldNullable: true);

			migrationBuilder.AddColumn<string>(
				name: "ConfirmaSenha",
				table: "Usuarios",
				nullable: true);

			migrationBuilder.AlterColumn<bool>(
				name: "Status",
				table: "ControlePatio",
				nullable: false,
				oldClrType: typeof(bool),
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Categoria",
				table: "Cnhs",
				maxLength: 2,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 2,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Nome",
				table: "Funcionarios",
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 200);

			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "Funcionarios",
				maxLength: 50,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "TituloEleitor",
				table: "Funcionarios",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 20,
				oldNullable: true);

			migrationBuilder.AlterColumn<decimal>(
				name: "Salario",
				table: "Funcionarios",
				nullable: false,
				oldClrType: typeof(decimal),
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
				name: "Ctps",
				table: "Funcionarios",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 20,
				oldNullable: true);

			migrationBuilder.AlterColumn<DateTime>(
				name: "Admissao",
				table: "Funcionarios",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "TelResidencial",
				table: "Funcionarios",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 14,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "TelCelular",
				table: "Funcionarios",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 14,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Rg",
				table: "Funcionarios",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 20,
				oldNullable: true);

			migrationBuilder.AlterColumn<DateTime>(
				name: "Nascimento",
				table: "Funcionarios",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Cpf",
				table: "Funcionarios",
				nullable: false,
				oldClrType: typeof(string),
				oldNullable: true);

			migrationBuilder.AddPrimaryKey(
				name: "PK_Funcionarios",
				table: "Funcionarios",
				column: "Id");

			migrationBuilder.CreateTable(
				name: "ClientesPF",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					IsAtivo = table.Column<bool>(nullable: false),
					Nome = table.Column<string>(nullable: false),
					Email = table.Column<string>(maxLength: 50, nullable: false),
					EnderecoId = table.Column<int>(nullable: false),
					CnhId = table.Column<int>(nullable: false),
					Rg = table.Column<string>(maxLength: 20, nullable: true),
					Cpf = table.Column<string>(nullable: true),
					Nascimento = table.Column<DateTime>(nullable: true),
					TipoCliente = table.Column<string>(maxLength: 2, nullable: true),
					Profissao = table.Column<string>(maxLength: 50, nullable: true),
					TelResidencial = table.Column<string>(maxLength: 14, nullable: true),
					TelComercial = table.Column<string>(nullable: true),
					TelCelular = table.Column<string>(maxLength: 14, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ClientesPF", x => x.Id);
					table.ForeignKey(
						name: "FK_ClientesPF_Cnhs_CnhId",
						column: x => x.CnhId,
						principalTable: "Cnhs",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_ClientesPF_Enderecos_EnderecoId",
						column: x => x.EnderecoId,
						principalTable: "Enderecos",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "ClientesPJ",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					IsAtivo = table.Column<bool>(nullable: false),
					RazaoSocial = table.Column<string>(nullable: false),
					Contato = table.Column<string>(maxLength: 50, nullable: false),
					Email = table.Column<string>(nullable: true),
					Cnpj = table.Column<string>(nullable: false),
					Ie = table.Column<string>(maxLength: 20, nullable: true),
					EnderecoId = table.Column<int>(nullable: false),
					TelComercial = table.Column<string>(maxLength: 14, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ClientesPJ", x => x.Id);
					table.ForeignKey(
						name: "FK_ClientesPJ_Enderecos_EnderecoId",
						column: x => x.EnderecoId,
						principalTable: "Enderecos",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_ClientesPF_CnhId",
				table: "ClientesPF",
				column: "CnhId");

			migrationBuilder.CreateIndex(
				name: "IX_ClientesPF_EnderecoId",
				table: "ClientesPF",
				column: "EnderecoId");

			migrationBuilder.CreateIndex(
				name: "IX_ClientesPJ_EnderecoId",
				table: "ClientesPJ",
				column: "EnderecoId");

			migrationBuilder.AddForeignKey(
				name: "FK_ClienteLocacao_ClientesPF_ClienteId",
				table: "ClienteLocacao",
				column: "ClienteId",
				principalTable: "ClientesPF",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_ClienteLocacao_ClientesPJ_ClientesPJId",
				table: "ClienteLocacao",
				column: "ClientesPJId",
				principalTable: "ClientesPJ",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Funcionarios_Cnhs_CnhId",
				table: "Funcionarios",
				column: "CnhId",
				principalTable: "Cnhs",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Funcionarios_Enderecos_EnderecoId",
				table: "Funcionarios",
				column: "EnderecoId",
				principalTable: "Enderecos",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Usuarios_Funcionarios_FuncionariosId",
				table: "Usuarios",
				column: "FuncionariosId",
				principalTable: "Funcionarios",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Veiculos_ClientesPJ_ClientesPJId",
				table: "Veiculos",
				column: "ClientesPJId",
				principalTable: "ClientesPJ",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_ClienteLocacao_ClientesPF_ClienteId",
				table: "ClienteLocacao");

			migrationBuilder.DropForeignKey(
				name: "FK_ClienteLocacao_ClientesPJ_ClientesPJId",
				table: "ClienteLocacao");

			migrationBuilder.DropForeignKey(
				name: "FK_Funcionarios_Cnhs_CnhId",
				table: "Funcionarios");

			migrationBuilder.DropForeignKey(
				name: "FK_Funcionarios_Enderecos_EnderecoId",
				table: "Funcionarios");

			migrationBuilder.DropForeignKey(
				name: "FK_Usuarios_Funcionarios_FuncionariosId",
				table: "Usuarios");

			migrationBuilder.DropForeignKey(
				name: "FK_Veiculos_ClientesPJ_ClientesPJId",
				table: "Veiculos");

			migrationBuilder.DropTable(
				name: "ClientesPF");

			migrationBuilder.DropTable(
				name: "ClientesPJ");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Funcionarios",
				table: "Funcionarios");

			migrationBuilder.DropColumn(
				name: "ConfirmaSenha",
				table: "Usuarios");

			migrationBuilder.RenameTable(
				name: "Funcionarios",
				newName: "Pessoa");

			migrationBuilder.RenameIndex(
				name: "IX_Funcionarios_EnderecoId",
				table: "Pessoa",
				newName: "IX_Pessoa_EnderecoId");

			migrationBuilder.RenameIndex(
				name: "IX_Funcionarios_CnhId",
				table: "Pessoa",
				newName: "IX_Pessoa_CnhId");

			migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "Usuarios",
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 10);

			migrationBuilder.AlterColumn<string>(
				name: "Login",
				table: "Usuarios",
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 50);

			migrationBuilder.AlterColumn<bool>(
				name: "Status",
				table: "ControlePatio",
				nullable: true,
				oldClrType: typeof(bool));

			migrationBuilder.AlterColumn<string>(
				name: "Categoria",
				table: "Cnhs",
				maxLength: 2,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 2);

			migrationBuilder.AlterColumn<string>(
				name: "TituloEleitor",
				table: "Pessoa",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "TelResidencial",
				table: "Pessoa",
				maxLength: 14,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "TelCelular",
				table: "Pessoa",
				maxLength: 14,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20,
				oldNullable: true);

			migrationBuilder.AlterColumn<decimal>(
				name: "Salario",
				table: "Pessoa",
				nullable: true,
				oldClrType: typeof(decimal));

			migrationBuilder.AlterColumn<string>(
				name: "Rg",
				table: "Pessoa",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Pis",
				table: "Pessoa",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Nome",
				table: "Pessoa",
				maxLength: 200,
				nullable: false,
				oldClrType: typeof(string));

			migrationBuilder.AlterColumn<DateTime>(
				name: "Nascimento",
				table: "Pessoa",
				nullable: true,
				oldClrType: typeof(DateTime));

			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "Pessoa",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldMaxLength: 50);

			migrationBuilder.AlterColumn<string>(
				name: "Ctps",
				table: "Pessoa",
				maxLength: 20,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Cpf",
				table: "Pessoa",
				nullable: true,
				oldClrType: typeof(string));

			migrationBuilder.AlterColumn<DateTime>(
				name: "Admissao",
				table: "Pessoa",
				nullable: true,
				oldClrType: typeof(DateTime));

			migrationBuilder.AddColumn<int>(
				name: "Idade",
				table: "Pessoa",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Profissao",
				table: "Pessoa",
				maxLength: 50,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "TelComercial",
				table: "Pessoa",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "TipoCliente",
				table: "Pessoa",
				maxLength: 2,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Cnpj",
				table: "Pessoa",
				maxLength: 20,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Contato",
				table: "Pessoa",
				maxLength: 200,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Ie",
				table: "Pessoa",
				maxLength: 20,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "ClientesPJ_TelComercial",
				table: "Pessoa",
				maxLength: 14,
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "VeiculosId",
				table: "Pessoa",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Funcionarios_Cpf",
				table: "Pessoa",
				nullable: true);

			migrationBuilder.AddColumn<DateTime>(
				name: "Funcionarios_Nascimento",
				table: "Pessoa",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Funcionarios_Rg",
				table: "Pessoa",
				maxLength: 20,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Funcionarios_TelCelular",
				table: "Pessoa",
				maxLength: 20,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Funcionarios_TelResidencial",
				table: "Pessoa",
				maxLength: 20,
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Discriminator",
				table: "Pessoa",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Pessoa",
				table: "Pessoa",
				column: "Id");

			migrationBuilder.CreateIndex(
				name: "IX_Pessoa_VeiculosId",
				table: "Pessoa",
				column: "VeiculosId");

			migrationBuilder.AddForeignKey(
				name: "FK_ClienteLocacao_Pessoa_ClienteId",
				table: "ClienteLocacao",
				column: "ClienteId",
				principalTable: "Pessoa",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_ClienteLocacao_Pessoa_ClientesPJId",
				table: "ClienteLocacao",
				column: "ClientesPJId",
				principalTable: "Pessoa",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Pessoa_Veiculos_VeiculosId",
				table: "Pessoa",
				column: "VeiculosId",
				principalTable: "Veiculos",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Pessoa_Cnhs_CnhId",
				table: "Pessoa",
				column: "CnhId",
				principalTable: "Cnhs",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Pessoa_Enderecos_EnderecoId",
				table: "Pessoa",
				column: "EnderecoId",
				principalTable: "Enderecos",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Usuarios_Pessoa_FuncionariosId",
				table: "Usuarios",
				column: "FuncionariosId",
				principalTable: "Pessoa",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Veiculos_Pessoa_ClientesPJId",
				table: "Veiculos",
				column: "ClientesPJId",
				principalTable: "Pessoa",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}
	}
}
