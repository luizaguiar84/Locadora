using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
	public class Obrigacoes
	{
		public int Id { get; set; }
		public int VeiculoId { get; set; }
		public DateTime Data { get; set; }
		[MaxLength(100)]
		public string Tipo { get; set; }
		public decimal Valor { get; set; }
		[MaxLength(250)]
		public string Descricao { get; set; }

	}
}
