using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_BS_Fat
{
	public class Abastecimentos
	{
		public int Id { get; set; }
		public DateTime Data { get; set; }
		public int Km { get; set; }
		public string Combustivel { get; set; }
		public decimal Litros { get; set; }
		public decimal ValorUnitario { get; set; }

		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }
		
	}
}
