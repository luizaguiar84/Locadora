
namespace Forms.Models
{
	using System;
	using System.Collections.Generic;

	public class Pneus
	{
		public int Id { get; set; }
		public int VeiculoId { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }

		public int KmInicial { get; set; }
		public int KmAtual { get; set; }

	}
}
