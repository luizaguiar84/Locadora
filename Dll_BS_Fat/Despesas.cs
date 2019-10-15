using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Despesas
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
		[DefaultValue(true)] 
		#endregion
		public bool IsAtiva { get;  set; }
		
		#region Anotações
		[DataType(DataType.Date)] 
		#endregion
		public DateTime Data { get;  set; }
		public int TipoDespesaId { get;  set; }
		
		#region Anotações
		[Display(Name = "Tipo de despesa")] 
		#endregion
		public TipoDespesa TipoDespesa { get;  set; }
		
		#region Anotações
		[DataType(DataType.Currency)] 
		#endregion
		public decimal Valor { get;  set; }
		
		#region Anotações
		[Display(Name = "Descrição")] 
		#endregion
		public string Descricao { get;  set; }

	}
}
