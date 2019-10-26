using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class TipoDespesa : BaseModel
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Informe o tipo de despesa")]
		[Display(Name = "Tipo de despesa")]
		public string Tipo { get; set; }


	}
}