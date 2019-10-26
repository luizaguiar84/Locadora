using System;

namespace Dll_BS_Fat
{
	public class DespesasBuilder : Despesas
	{

		public Despesas Build()
		{
			return new Despesas(IsAtiva, Data, TipoDespesaId, Valor, Descricao);
		}
		public DespesasBuilder GetIsAtiva(bool isAtiva)
		{
			this.IsAtiva = isAtiva;
			return this;
		}
		public DespesasBuilder GetData(DateTime data)
		{
			this.Data = data;
			return this;
		}
		public DespesasBuilder GetTipoDespesaId(int tipoDespesaId)
		{
			this.TipoDespesaId = tipoDespesaId;
			return this;
		}

		public DespesasBuilder GetValor(decimal valor)
		{
			this.Valor = valor;
			return this;
		}
		public DespesasBuilder GetDescricao(string descricao)
		{
			this.Descricao = descricao;
			return this;
		}

	}
}
