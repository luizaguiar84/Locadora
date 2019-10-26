using System;

namespace Dll_BS_Fat
{
	public class ManutencoesBuilder : Manutencoes
	{
		public Manutencoes Build()
		{
			return new Manutencoes(Data, Km, Descricao, Valor, VeiculoId);
		}
		public ManutencoesBuilder GetData(DateTime data)
		{
			this.Data = data;
			return this;
		}
		public ManutencoesBuilder GetKm(int km)
		{
			this.Km = km;
			return this;
		}
		public ManutencoesBuilder GetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}
		public ManutencoesBuilder GetValor(decimal valor)
		{
			this.Valor = valor;
			return this;
		}
		public ManutencoesBuilder GetVeiculoId(int veiculoId)
		{
			this.VeiculoId = veiculoId;
			return this;
		}

	}
}
