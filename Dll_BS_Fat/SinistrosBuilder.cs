using System;

namespace BsFat
{
	public class SinistrosBuilder : Sinistros
	{
		public Sinistros Build()
		{
			return new Sinistros(Data, Km, Descricao, Valor, VeiculoId);
		}
		public SinistrosBuilder GetData(DateTime data)
		{
			this.Data = data;
			return this;
		}
		public SinistrosBuilder GetKm(int km)
		{
			this.Km = km;
			return this;
		}
		public SinistrosBuilder GetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}
		public SinistrosBuilder GetValor(decimal valor)
		{
			this.Valor = valor;
			return this;
		}
		public SinistrosBuilder GetVeiculoId(int veiculoId)
		{
			this.VeiculoId = veiculoId;
			return this;
		}
	}
}
