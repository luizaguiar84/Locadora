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

		public int Id { get;  set; }
		[Display(Name = "Data da Multa")]
		public DateTime DataMulta { get;  set; }
		[MaxLength(200)]
		[Display(Name = "Descrição")]
		public string Descricao { get;  set; }
		[Display(Name = "Data de vencimento")]
		public DateTime Vencimento { get;  set; }
		public decimal Valor { get;  set; }
		public int Pontos { get;  set; }

		public int VeiculoId { get;  set; }
		public virtual Veiculos Veiculo { get; set; }




		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
	}
}
