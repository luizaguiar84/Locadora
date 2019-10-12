using System;
using System.ComponentModel;

namespace Dll_BS_Fat
{
	public class Despesas
	{
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

		public int Id { get; set; }
		[DefaultValue(true)]
		public bool IsAtiva { get; protected set; }
		public DateTime Data { get; protected set; }
		public int TipoDespesaId { get; protected set; }
		public TipoDespesa TipoDespesa { get; protected set; }
		public decimal Valor { get; protected set; }
		public string Descricao { get; protected set; }

	}
}
