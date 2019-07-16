
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Manutencao
	{
		//public Manutencao()
		//{
		//	this.carros = new HashSet<Carros>();
		//	this.manutencaopeca = new HashSet<Manutencaopeca>();
		//}

		public int Id { get; set; }
		public int VeiculoId { get; set; }
		public DateTime DataManutencao { get; set; }
		public int KmManutencao { get; set; }
		[MaxLength(250)]
		public string Descricao { get; set; }
		public decimal ValorManutencao { get; set; }

		//public virtual ICollection<Carros> carros { get; set; }
		//public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
	}
}
