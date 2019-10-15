using System;
using System.ComponentModel.DataAnnotations;

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

		public DateTime Data { get;  set; }
		public int Km { get;  set; }
		[Display (Name = "Descrição")]
		public string Descricao { get;  set; }
		public decimal Valor { get;  set; }

		public virtual Veiculos Veiculo { get;  set; }
		public int VeiculoId { get;  set; }


	}
}
