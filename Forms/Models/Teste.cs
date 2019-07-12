using System.ComponentModel.DataAnnotations;

namespace Forms.Models
{
	public class Teste
	{
		public int Id { get; set; }

		[StringLength(100)]
		public string Nome { get; set; }

		[StringLength(100)]
		public string Email { get; set; }

	}
}
