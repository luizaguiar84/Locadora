using System;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Estoque
	{
		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Display(Name = "Peça")]
		#endregion
		public string Peca { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]
		#endregion
		public string Descricao { get; set; }

		#region Anotações
		[Display(Name = "Valor Unitário")]
		[DataType(DataType.Currency)]
		#endregion
		public decimal ValorUnitario { get; set; }

		#region Anotações
		[Display(Name = "Data de Adição")]
		[DataType(DataType.Date)]
		#endregion
		public DateTime DataAdicao { get; set; }

		#region Anotações
		[Display(Name = "Data de Saida")]
		[DataType(DataType.Date)]
		#endregion
		public DateTime? DataSaida { get; set; }

		#region Anotações
		[Display(Name = "Quantidade")]
		#endregion
		public int Quantidade { get; set; }

		#region Anotações
		[Display(Name = "Observações")]
		[DataType(DataType.MultilineText)]

		#endregion
		public string Observacoes { get; set; }

		#region Anotações
		[Display(Name = "Incluido por")]
		#endregion
		public string IncluidoPor { get; set; }

		#region Anotações
		[Display(Name = "Retirado por")]
		#endregion
		public string RetiradoPor { get; set; }
	}
}
