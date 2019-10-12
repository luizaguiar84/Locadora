namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Multas
	{
		public Multas()
		{

		}
		public Multas(DateTime dataMulta, string descricao, DateTime vencimento, decimal valor, int pontos, int veiculoId)
		{
			DataMulta = dataMulta;
			Descricao = descricao;
			Vencimento = vencimento;
			Valor = valor;
			Pontos = pontos;
			VeiculoId = veiculoId;
		}

		public int Id { get; private set; }
		public DateTime DataMulta { get; protected set; }
		[MaxLength(200)]
		public string Descricao { get; protected set; }
		public DateTime Vencimento { get; protected set; }
		public decimal Valor { get; protected set; }
		public int Pontos { get; protected set; }

		public int VeiculoId { get; protected set; }
		public virtual Veiculos Veiculo { get; protected set; }




		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
	}
}
