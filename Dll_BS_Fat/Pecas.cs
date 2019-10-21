
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
		[Display(Name = "Descri��o")]

		#endregion
		public string Descricao { get; set; }

		#region Anota��es
		[DataType(DataType.Currency)]
		#endregion
		public decimal Valor { get; set; }

		//public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
	}
}
