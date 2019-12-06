//using System;

//namespace BsFat
//{
//	public class MotoristasBuilder : Motoristas
//	{

//		public Motoristas Build()
//		{
//			return new Motoristas(Nome, Rg, Cpf, Nascimento, Email, TelResidencial, TelCelular, IsAtivo, Cnh, Endereco);
//		}
//		public MotoristasBuilder GetRg(string rg)
//		{
//			this.Rg = rg;
//			return this;
//		}
//		public MotoristasBuilder GetCpf(string cpf)
//		{
//			this.Cpf = cpf;
//			return this;
//		}
//		public MotoristasBuilder GetNascimento(DateTime nascimento)
//		{

//			this.Nascimento = new DateTime(nascimento.Year, nascimento.Month, nascimento.Day);
//			return this;
//		}
//		public MotoristasBuilder GetTelResidencial(string telResidencial)
//		{
//			this.TelResidencial = telResidencial;
//			return this;
//		}
//		//public MotoristasBuilder GetTelComercial(string telComercial)
//		//{
//		//	this.TelComercial = telComercial;
//		//	return this;
//		//}
//		public MotoristasBuilder GetTelCelular(string telCelular)
//		{
//			this.TelCelular = telCelular;
//			return this;
//		}
//		public MotoristasBuilder GetNome(string nome)
//		{
//			this.Nome = nome;
//			return this;
//		}
//		public MotoristasBuilder GetEmail(string email)
//		{
//			this.Email = email;
//			return this;
//		}
//		public MotoristasBuilder GetCnh(Cnhs cnh)
//		{
//			this.Cnh = cnh;
//			return this;
//		}
//		public MotoristasBuilder GetEndereco(Enderecos endereco)
//		{
//			this.Endereco = endereco;
//			return this;
//		}
//		public MotoristasBuilder GetIsAtivo(bool isAtivo)
//		{
//			this.IsAtivo = isAtivo;
//			return this;
//		}
//	}
//}
