
namespace Classes.Models
{
	using System;
	using System.Collections.Generic;

	public class Pecas
	{
		//public Pecas()
		//{
		//	this.manutencaopeca = new HashSet<Manutencaopeca>();
		//}

		public int Id { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }

		//public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
	}
}
