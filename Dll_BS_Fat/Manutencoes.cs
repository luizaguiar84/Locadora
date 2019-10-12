
namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Manutencoes
	{
		public Manutencoes()
		{

		}
		public Manutencoes(DateTime data, int km, string descricao, decimal valor, int veiculoId)
		{
			Data = data;
			Km = km;
			Descricao = descricao;
			Valor = valor;
			VeiculoId = veiculoId;
		}

		public int Id { get; private set; }
		public DateTime Data { get; protected set; }
		public int Km { get; protected set; }
		[MaxLength(250)]
		public string Descricao { get; protected set; }
		public decimal Valor { get; protected set; }
		public int VeiculoId { get; protected set; }
		public virtual Veiculos Veiculo { get; protected set; }



	}
}
