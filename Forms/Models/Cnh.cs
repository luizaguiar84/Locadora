
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Cnh
	{
		public int Id { get; set; }
		[MaxLength(20)]
		public string Numero { get; set; }
		[MaxLength(2)]
		public string Categoria { get; set; }
		public DateTime? Emissao { get; set; }
		public DateTime? Validade { get; set; }

		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual Endereco endereco { get; set; }
	}
}