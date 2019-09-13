
namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Pneus
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Estado { get; set; }

		public int KmInicial { get; set; }
		public int KmAtual { get; set; }

		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }
		public DateTime DataAdicao { get; set; }

		
	}
}
