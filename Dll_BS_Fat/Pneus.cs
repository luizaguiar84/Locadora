
namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Pneus : BaseModel
	{
		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Insira a marca do pneu")]
		[Display(Name = "Marca")]
		#endregion
		public string Marca { get; set; }

		#region Anotações
		[Display(Name = "Modelo")]
		#endregion
		public string Modelo { get; set; }

		#region Anotações
		[Display(Name = "Estado")]
		#endregion
		public string Estado { get; set; }

		#region Anotações

		[Display(Name = "Km Inicial")]
		#endregion
		public int KmInicial { get; set; }

		#region Anotações
		[Display(Name = "Km Atual")]
		#endregion
		public int KmAtual { get; set; }

		#region Anotações
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Data da adição")]
		#endregion
		public DateTime DataAdicao { get; set; }
		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }

	}
}
