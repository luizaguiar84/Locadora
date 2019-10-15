namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Cnhs
	{
		#region Construtores
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

		#endregion

		#region Anota��es
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anota��es
		[Display(Name = "N�mero da CNH")]
		[MaxLength(20)]
		#endregion

		public string Numero { get; set; }

		#region Anota��es
		[MaxLength(2)]
		[Required(ErrorMessage = "Favor selecionar a categoria da CNH")]
		#endregion
		public string Categoria { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data de emiss�o")]
		#endregion
		public DateTime? Emissao { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data de validade")]
		#endregion
		public DateTime? Validade { get; set; }



		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual Endereco endereco { get; set; }
	}
}