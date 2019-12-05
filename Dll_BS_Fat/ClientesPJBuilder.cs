using System;

namespace BsFat
{
	public class ClientesPJBuilder : ClientesPJ
	{

		public ClientesPJ Build()
		{
			return new ClientesPJ(IsAtivo, RazaoSocial, Contato, Email, Cnpj, Ie, Endereco, TelComercial, TelCelular);
		}
		public ClientesPJBuilder GetIsAtivo(bool ativo)
		{
			this.IsAtivo = ativo;
			return this;
		}
		public ClientesPJBuilder GetRazaoSocial(string razaoSocial)
		{
			this.RazaoSocial = razaoSocial;
			return this;
		}
		public ClientesPJBuilder GetContato(string contato)
		{
			this.Contato = contato;
			return this;
		}
		public ClientesPJBuilder GetEmail(string email)
		{
			this.Email = email;
			return this;
		}
		public ClientesPJBuilder GetCnpj(string cnpj)
		{
			this.Cnpj = cnpj;
			return this;
		}
		public ClientesPJBuilder GetIe(string ie)
		{
			this.Ie = ie;
			return this;
		}
		public ClientesPJBuilder GetEndereco(Enderecos endereco)
		{
			this.Endereco = endereco;
			return this;
		}
		public ClientesPJBuilder GetTelComercial(string telComercial)
		{
			this.TelComercial = telComercial;
			return this;
		}

		public ClientesPJBuilder GetTelCelular(string telCelular)
		{
			this.TelCelular = telCelular;
			return this;
		}
	}
}
