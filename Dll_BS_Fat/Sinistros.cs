using System;

namespace Dll_BS_Fat
{
	public class Sinistros
	{
		public Sinistros()
		{

		}
		public Sinistros(DateTime data, int km, string descricao, decimal valor, int veiculoId)
		{
			Data = data;
			Km = km;
			Descricao = descricao;
			Valor = valor;
			VeiculoId = veiculoId;
		}

		public int Id { get; set; }

		public DateTime Data { get; protected set; }
		public int Km { get; protected set; }
		public string Descricao { get; protected set; }
		public decimal Valor { get; protected set; }

		public virtual Veiculos Veiculo { get; protected set; }
		public int VeiculoId { get; protected set; }


	}
}
