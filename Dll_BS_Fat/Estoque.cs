using System;
using System.ComponentModel.DataAnnotations;

namespace BsFat
{
	public class Estoque : BaseModel
	{
		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Favor informar o nome da peça")]
		[Display(Name = "Peça")]
		#endregion
		public string Peca { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]
		#endregion
		public string Descricao { get; set; }

		#region Anotações
		[Required]
		[Display(Name = "Valor Unitário")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0,c}")]
		[Range(1, 9999)]
		#endregion
		public decimal ValorUnitario { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Favor inserir a Data da Adição")]
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
		[Required(ErrorMessage = "Inserir a quantidade")]
		[Display(Name = "Quantidade")]
		[Range(1, 9999)]
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
