namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Cnhs : BaseModel
	{
		#region Construtores
		public Cnhs()
		{

		}
		public Cnhs(string numero, string categoria, DateTime emissao, DateTime validade)
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
		[Required(ErrorMessage = "Favor inserir o n�mero da CNH")]
		[Display(Name = "N�mero da CNH", Description = "N�mero da CNH")]
		[MaxLength(20)]
		#endregion
				public string Numero { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor selecionar a categoria da CNH")]
		[MaxLength(2)]
		#endregion
		public string Categoria { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor inserir a data de emiss�o da CNH")]
		[DataType(DataType.Date)]
		[Display(Name = "Data de emiss�o")]
		#endregion
		public DateTime Emissao { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor inserir a data de validade da CNH")]
		[DataType(DataType.Date)]
		[Display(Name = "Data de validade")]
		#endregion
		public DateTime Validade { get; set; }



		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual Endereco endereco { get; set; }
	}
}