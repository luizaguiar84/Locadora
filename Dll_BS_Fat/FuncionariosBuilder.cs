using System;

namespace BsFat
{
	public class FuncionariosBuilder : Funcionarios
	{

		public Funcionarios Build()
		{
			return new Funcionarios(IsAtivo, Nome, Email, Endereco, Rg, Cpf, Nascimento, TelResidencial, TelCelular, Salario, Admissao, Ctps, Pis, TituloEleitor, Observacoes, Cargo);
		}


		public FuncionariosBuilder GetIsAtivo(bool ativo)
		{
			this.IsAtivo = ativo;
			return this;
		}
		public FuncionariosBuilder GetNome(string nome)
		{
			this.Nome = nome;
			return this;
		}
		public FuncionariosBuilder GetEmail(string email)
		{
			this.Email = email;
			return this;
		}
		public FuncionariosBuilder GetEndereco(Enderecos endereco)
		{
			this.Endereco = endereco;
			return this;
		}
		//public FuncionariosBuilder GetCnh(Cnhs cnh)
		//{
		//	this.Cnh = cnh;
		//	return this;
		//}
		public FuncionariosBuilder GetRg(string rg)
		{
			this.Rg = rg;
			return this;
		}
		public FuncionariosBuilder GetCpf(string cpf)
		{
			this.Cpf = cpf;
			return this;
		}
		public FuncionariosBuilder GetNascimento(DateTime nascimento)
		{
			this.Nascimento = nascimento;
			return this;
		}
		public FuncionariosBuilder GetTelResidencial(string telResidencial)
		{
			this.TelResidencial = telResidencial;
			return this;
		}
		public FuncionariosBuilder GetTelCelular(string telCelular)
		{
			this.TelCelular = telCelular;
			return this;
		}
		public FuncionariosBuilder GetSalario(decimal salario)
		{
			this.Salario = salario;
			return this;
		}
		public FuncionariosBuilder GetAdmissao(DateTime admissao)
		{
			this.Admissao = admissao;
			return this;
		}
		public FuncionariosBuilder GetCtps(string ctps)
		{
			this.Ctps = ctps;
			return this;
		}
		public FuncionariosBuilder GetPis(string pis)
		{
			this.Pis = pis;
			return this;
		}
		public FuncionariosBuilder GetTituloEleitor(string tituloEleitor)
		{
			this.TituloEleitor = tituloEleitor;
			return this;
		}
		//public FuncionariosBuilder GetDemissao(DateTime demissao)
		//{
		//	this.Demissao = demissao;
		//	return this;
		//}
		public FuncionariosBuilder GetObservacoes(string observacoes)
		{
			this.Observacoes = observacoes;
			return this;
		}
		public FuncionariosBuilder GetCargo(Cargos cargo)
		{
			this.Cargo = cargo;
			return this;
		}

	}
}
