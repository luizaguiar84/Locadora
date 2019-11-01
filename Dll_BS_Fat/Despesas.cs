using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BsFat
{
	public class Despesas : BaseModel
	{
		#region Construtores
		public Despesas()
		{

		}
		public Despesas(bool isAtiva, DateTime data, int tipoDespesaId, decimal valor, string descricao)
		{
			IsAtiva = isAtiva;
			Data = data;
			TipoDespesaId = tipoDespesaId;
			Valor = valor;
			Descricao = descricao;
		}
		#endregion

		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Required]
		[DefaultValue(true)]
		#endregion
		public bool IsAtiva { get; set; }

		#region Anotações
		[Required]
		[DataType(DataType.Date)]
		#endregion
		public DateTime Data { get; set; }
		public int TipoDespesaId { get; set; }

		#region Anotações
		[Required]
		[Display(Name = "Tipo de despesa")]
		#endregion
		public TipoDespesa TipoDespesa { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Favor inserir o valor da Despesa")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0,c}")]
		#endregion
		public decimal Valor { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]
		#endregion
		public string Descricao { get; set; }

	}
}
