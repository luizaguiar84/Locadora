
namespace Classes.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Manutencoes
	{
		
		public int Id { get; set; }
		public DateTime Data { get; set; }
		public int Km { get; set; }
		[MaxLength(250)]
		public string Descricao { get; set; }
		public decimal Valor { get; set; }

		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }


		
	}
}
