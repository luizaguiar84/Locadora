namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;

	public class Cnhs
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