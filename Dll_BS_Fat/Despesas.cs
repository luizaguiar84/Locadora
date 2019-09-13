using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dll_BS_Fat
{
	public class Despesas
	{
		
		public int Id { get; set; }

		public bool IsAtiva { get; set; }
		public DateTime Data { get; set; }
		public int TipoDespesaId { get; set; }
		public TipoDespesa TipoDespesa { get; set; }
		public decimal Valor { get; set; }
		public string Descricao { get; set; }

	}
}
