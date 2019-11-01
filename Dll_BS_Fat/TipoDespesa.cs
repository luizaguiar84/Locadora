using System.ComponentModel.DataAnnotations;

namespace BsFat
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