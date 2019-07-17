
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;

	public class ControlePatio
	{
		public int Id { get; set; }
		public int VeiculoId { get; set; }
		public int ClienteId { get; set; }

		public sbyte? Status { get; set; } 
		public string Placa { get; set; }
		public DateTime? SaidaPatio { get; set; }
		public int KmSaida { get; set; }
		public string NivelCombustivelSaida { get; set; }
		public string LiberadoSaida { get; set; }
		public string ObservacoesSaida { get; set; }

		public DateTime? RetornoPatio { get; set; }
		public string EstadoRetorno { get; set; }
		public string NivelCombustivelRetorno { get; set; }
		public int KmRetorno { get; set; }
		public string RecolhidoRetorno { get; set; }


	}
}
