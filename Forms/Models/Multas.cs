
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Multas
	{
		public int Id { get; set; }
		public DateTime DataMulta { get; set; }
		[MaxLength(200)]
		public string Descricao { get; set; }
		public DateTime Vencimento { get; set; }
		public decimal Valor { get; set; }
		public int Pontos { get; set; }

		public int VeiculoId { get; set; }
		public int ClienteId { get; set; }



		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
	}
}
