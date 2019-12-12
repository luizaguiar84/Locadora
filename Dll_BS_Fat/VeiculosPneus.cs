using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsFat
{
	public class VeiculosPneus
	{
		public int Id { get; set; }
		public Veiculos Veiculos { get; set; }
		public int VeiculosId { get; set; }
		public Pneus Pneus { get; set; }
		public int PneusId { get; set; }

	}
}
