using System;

namespace Dll_BS_Fat
{
	public class ClientesPFBuilder : ClientesPF
	{

		public ClientesPF Build()
		{
			return new ClientesPF(Nome, Rg, Cpf, Nascimento, TipoCliente, Profissao, Email, TelResidencial, TelComercial, TelCelular, IsAtivo, Cnh, Endereco);
		}
		public ClientesPFBuilder GetRg(string rg)
		{
			this.Rg = rg;
			return this;
		}
		public ClientesPFBuilder GetCpf(string cpf)
		{
			this.Cpf = cpf;
			return this;
		}
		public ClientesPFBuilder GetNascimento(DateTime nascimento)
		{

			this.Nascimento = new DateTime(nascimento.Year, nascimento.Month, nascimento.Day);
			return this;
		}

		public ClientesPFBuilder GetTipoCliente(TipoCliente tipo)
		{
			this.TipoCliente = tipo;
			return this;
		}
		public ClientesPFBuilder GetProfissao(string profissao)
		{
			this.Profissao = profissao;
			return this;
		}
		public ClientesPFBuilder GetTelResidencial(string telResidencial)
		{
			this.TelResidencial = telResidencial;
			return this;
		}
		public ClientesPFBuilder GetTelComercial(string telComercial)
		{
			this.TelComercial = telComercial;
			return this;
		}
		public ClientesPFBuilder GetTelCelular(string telCelular)
		{
			this.TelCelular = telCelular;
			return this;
		}
		public ClientesPFBuilder GetNome(string nome)
		{
			this.Nome = nome;
			return this;
		}
		public ClientesPFBuilder GetEmail(string email)
		{
			this.Email = email;
			return this;
		}
		public ClientesPFBuilder GetCnh(Cnhs cnh)
		{
			this.Cnh = cnh;
			return this;
		}
		public ClientesPFBuilder GetEndereco(Enderecos endereco)
		{
			this.Endereco = endereco;
			return this;
		}
		public ClientesPFBuilder GetIsAtivo(bool isAtivo)
		{
			this.IsAtivo = isAtivo;
			return this;
		}
	}
}
