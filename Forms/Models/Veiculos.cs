using Forms.Models;

namespace Forms.Models
{
	using System;
	using System.Collections.Generic;

	public class Veiculos
	{
		public Veiculos()
		{
			//this.contratocarro1 = new HashSet<Contratocarro>();
			//this.entradasaida = new HashSet<Entradasaida>();

		}

		public int Id { get; set; }

		public int MontadoraId { get; set; }
		public int ModeloId { get; set; }
		public int AnoFabricacao { get; set; }
		public int AnoModelo { get; set; }
		public int Portas { get; set; }
		public int CorId { get; set; }
		public string Placa { get; set; }
		public string Renavam { get; set; }
		public string Chassi { get; set; }
		public int Lugares { get; set; }
		public int Quilometragem { get; set; }
		public string Status { get; set; }
		public string Combustivel { get; set; }
		public decimal ValorDiaria { get; set; }

		public DateTime DataAquisicao { get; set; }

		public sbyte? ArCondicionado { get; set; }
		public sbyte? DirecaoHidraulica { get; set; }
		public sbyte? VidroEletrico { get; set; }
		public sbyte? AirBag { get; set; }
		public sbyte? Abs { get; set; }
		public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }
		public int MANUTENCAO_IDMANUTENCAO { get; set; }


		//public virtual Modelos modelos { get; set; }
		//public virtual Manutencao manutencao { get; set; }
		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual ICollection<Contratocarro> contratocarro1 { get; set; }
		//public virtual ICollection<Entradasaida> entradasaida { get; set; }
	}
}
