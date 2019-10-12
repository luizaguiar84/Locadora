using System;

namespace Dll_BS_Fat
{
	public class CnhsBuilder : Cnhs
	{
		public Cnhs Build()
		{
			return new Cnhs(Numero, Categoria, Emissao, Validade);
		}

		public CnhsBuilder GetNumero(string numero)
		{
			this.Numero = numero;
			return this;
		}
		public CnhsBuilder GetCategoria(string categoria)
		{
			this.Categoria = categoria;
			return this;
		}
		public CnhsBuilder GetEmissao(DateTime emissao)
		{
			this.Emissao = emissao;
			return this;
		}
		public CnhsBuilder GetValidade(DateTime validade)
		{
			this.Validade = validade;
			return this;
		}
	}
}
