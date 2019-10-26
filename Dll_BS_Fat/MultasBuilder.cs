using System;

namespace Dll_BS_Fat
{
	public class MultasBuilder : Multas
	{
		public Multas Build()
		{
			return new Multas(DataMulta, Descricao, Vencimento, Valor, Pontos, VeiculoId);
		}

		public MultasBuilder GetDataMulta(DateTime data)
		{
			this.DataMulta = data;
			return this;
		}
		public MultasBuilder GetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}
		public MultasBuilder GetVencimento(DateTime vencimento)
		{
			this.Vencimento = vencimento;
			return this;
		}
		public MultasBuilder GetValor(decimal valor)
		{
			this.Valor = valor;
			return this;
		}
		public MultasBuilder GetPontos(int pontos)
		{
			this.Pontos = pontos;
			return this;
		}
		public MultasBuilder getVeiculoId(int veiculoId)
		{
			this.VeiculoId = veiculoId;
			return this;
		}



	}
}
