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

		public int Id { get; private set; }
		public DateTime Data { get; protected set; }
		[MaxLength(100)]
		public string Tipo { get; protected set; }
		public decimal Valor { get; protected set; }
		[MaxLength(250)]
		public string Descricao { get; protected set; }

		public int VeiculoId { get; protected set; }
		public virtual Veiculos Veiculo { get; private set; }


	}
}
