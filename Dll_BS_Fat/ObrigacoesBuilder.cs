using System;

namespace BsFat
{
	public class ObrigacoesBuilder : Obrigacoes
	{

		public Obrigacoes Build()
		{
			return new Obrigacoes(Data, Tipo, Valor, Descricao, VeiculoId);
		}

		public ObrigacoesBuilder GetData(DateTime data)
		{
			this.Data = data;
			return this;
		}
		public ObrigacoesBuilder GetTipo(string tipo)
		{
			this.Tipo = tipo;
			return this;
		}
		public ObrigacoesBuilder GetValor(decimal valor)
		{
			this.Valor = valor;
			return this;
		}
		public ObrigacoesBuilder GetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}
		public ObrigacoesBuilder GetVeiculoId(int veiculoId)
		{
			this.VeiculoId = veiculoId;
			return this;
		}

	}
}
