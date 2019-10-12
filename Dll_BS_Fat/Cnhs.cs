namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Cnhs
	{
		public Cnhs()
		{

		}
		public Cnhs(string numero, string categoria, DateTime? emissao, DateTime? validade)
		{
			Numero = numero;
			Categoria = categoria;
			Emissao = emissao;
			Validade = validade;
		}

		public int Id { get; set; }
		[MaxLength(20)]
		public string Numero { get;  set; }
		[MaxLength(2)]
		[Required(ErrorMessage = "Favor selecionar a categoria da CNH")]
		public string Categoria { get;  set; }
		public DateTime? Emissao { get;  set; }
		public DateTime? Validade { get;  set; }



		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual Endereco endereco { get; set; }
	}
}