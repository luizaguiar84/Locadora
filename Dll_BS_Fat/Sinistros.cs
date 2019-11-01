using System;
using System.ComponentModel.DataAnnotations;

namespace BsFat
{
	public class Sinistros : BaseModel
	{
		#region Consutrutores
		public Sinistros()
		{

		}
		public Sinistros(DateTime data, int km, string descricao, decimal valor, int veiculoId)
		{
			Data = data;
			Km = km;
			Descricao = descricao;
			Valor = valor;
			VeiculoId = veiculoId;
		}

		#endregion

		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Informe a data do sinistro")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "dd/mm/yyyy")]
		#endregion
		public DateTime Data { get; set; }

		#region Anotações
				[Required (ErrorMessage = "Informe a KM no sinistro")]
		[Display(Name = "KM")]
		#endregion
		public int Km { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]
		#endregion
		public string Descricao { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Informe o valor do sinistro")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0,c}")]
		[Range(1,99999)]
		#endregion
		public decimal Valor { get; set; }

		public virtual Veiculos Veiculo { get; set; }
		public int VeiculoId { get; set; }


	}
}
