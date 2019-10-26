
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Pecas : BaseModel
	{
		//public Pecas()
		//{
		//	this.manutencaopeca = new HashSet<Manutencaopeca>();
		//}

		#region Anota��es
		[Key]

		#endregion
		public int Id { get; set; }

		#region Anota��es
	[Required(ErrorMessage = "Informe a descri��o da pe�a")]	
  [Display(Name = "Descri��o")]
		#endregion
		public string Descricao { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Insira o valor da pe�a")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0,c}")]
		#endregion
		public decimal Valor { get; set; }

		//public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
	}
}
