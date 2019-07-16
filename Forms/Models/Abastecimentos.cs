using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
	public class Abastecimentos
	{
		public int Id { get; set; }

		public int VeiculoId { get; set; }

		public DateTime Data { get; set; }
		public int Km { get; set; }
		public string Combustivel { get; set; }
		public float Litros { get; set; }
		public decimal ValorUnitario { get; set; }
	}
}
