using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
	public class Despesas
	{
		public Despesas()
		{
			this.TipoDespesa = new TipoDespesa();
		}


		public int Id { get; set; }

		
		public sbyte Status { get; set; }
		public DateTime Data { get; set; }
		public TipoDespesa TipoDespesa { get; set; }
		public decimal Valor { get; set; }
		public string Descricao { get; set; }

	}
}
