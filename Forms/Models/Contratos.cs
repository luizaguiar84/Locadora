
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;

	public class Contratos
	{
		//public Contratos()
		//{
		//	this.contratocarro = new HashSet<Contratocarro>();
		//	this.pneus = new HashSet<Pneus>();
		//}

		public int Id { get; set; }
		public int ClienteId { get; set; }
		public sbyte? Status { get; set; }
		public DateTime DataContrato { get; set; }
		public DateTime? DataInicio { get; set; }
		public DateTime? DataFinal { get; set; }
		public decimal Valor { get; set; }
		public int KmInicial { get; set; }
		public int KmFinal { get; set; }

		//public virtual Cliente cliente { get; set; }
		//public virtual ICollection<Contratocarro> contratocarro { get; set; }
		//public virtual ICollection<Pneus> pneus { get; set; }
	}
}
