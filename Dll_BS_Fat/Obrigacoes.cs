using System;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Obrigacoes
	{
		public Obrigacoes()
		{

		}
		public Obrigacoes(DateTime data, string tipo, decimal valor, string descricao, int veiculoId)
		{
			Data = data;
			Tipo = tipo;
			Valor = valor;
			Descricao = descricao;
			VeiculoId = veiculoId;
		}

		public int Id { get;  set; }
		public DateTime Data { get;  set; }
		[MaxLength(100)]
		public string Tipo { get;  set; }
		public decimal Valor { get;  set; }
		[MaxLength(250)]
		public string Descricao { get;  set; }

		public int VeiculoId { get;  set; }
		public virtual Veiculos Veiculo { get;  set; }


	}
}
