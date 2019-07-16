using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
	public class Sinistros
	{
		public int Id { get; set; }

		public int VeiculoId { get; set; }

		public DateTime Data { get; set; }
		public int Km { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }

	}
}
