using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
	public class Estoque
	{
		public int Id { get; set; }
		public string Peca { get; set; }
		public string Descricao { get; set; }
		public decimal ValorUnitario { get; set; }
		public DateTime DataAdicao { get; set; }
		public DateTime? DataSaida { get; set; }
		public int Quantidade { get; set; }
		public string Observacoes { get; set; }
		public string IncluidoPor { get; internal set; }
		public string RetiradoPor { get; internal set; }
	}
}
