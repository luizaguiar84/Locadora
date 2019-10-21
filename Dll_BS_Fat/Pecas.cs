
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Pecas : BaseModel
	{
		//public Pecas()
		//{
		//	this.manutencaopeca = new HashSet<Manutencaopeca>();
		//}

		#region Anotações
		[Key]

		#endregion
		public int Id { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]

		#endregion
		public string Descricao { get; set; }

		#region Anotações
		[DataType(DataType.Currency)]
		#endregion
		public decimal Valor { get; set; }

		//public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
	}
}
