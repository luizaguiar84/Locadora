namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;

	public class Veiculos : IComparable
	{
		public Veiculos()
		{
			this.Pneu = new HashSet<Pneus>();
			this.Abastecimentos = new HashSet<Abastecimentos>();
			this.Manutencao = new HashSet<Manutencoes>();
			this.Sinistros = new HashSet<Sinistros>();
			this.Obrigacoes = new HashSet<Obrigacoes>();
			this.Multas = new HashSet<Multas>();
		}


		public int Id { get; set; }

		public string Montadora { get; set; }
		public string Modelo { get; set; }
		public string AnoModelo { get; set; }
		public int Portas { get; set; }
		public string Cor { get; set; }
		public string Placa { get; set; }
		public string Renavam { get; set; }
		public string Chassi { get; set; }
		public int Lugares { get; set; }
		public int Quilometragem { get; set; }
		public string Status { get; set; }
		public string Combustivel { get; set; }
		public string ValorAtual { get; set; }
		public decimal ValorDiaria { get; set; }
		public string Observacoes { get; set; }
		public DateTime? DataAquisicao { get; set; }
		[DefaultValue(false)]
		public bool ArCondicionado { get; set; }
		[DefaultValue(false)]
		public bool DirecaoHidraulica { get; set; }
		[DefaultValue(false)]
		public bool VidroEletrico { get; set; }
		[DefaultValue(false)]
		public bool AirBag { get; set; }
		[DefaultValue(false)]
		public bool Abs { get; set; }
		[DefaultValue(true)]
		public bool IsAtivo { get; set; }


		public virtual ICollection<Abastecimentos> Abastecimentos { get; set; }
		public virtual ICollection<Manutencoes> Manutencao { get; set; }
		public virtual ICollection<Sinistros> Sinistros { get; set; }
		public virtual ICollection<Obrigacoes> Obrigacoes { get; set; }
		public virtual ICollection<Multas> Multas { get; set; }
		public virtual ICollection<Pneus> Pneu { get; set; }

		public int CompareTo(object obj)
		{
			Veiculos outro = obj as Veiculos;
			return Modelo.CompareTo(outro.Modelo);
		}

		/// <summary>
		/// Registra a Km rodada do carro
		/// </summary>
		/// <param name="kmfinal">Quilometragem final</param>
		public void RegistrarKmDb(int kmfinal)
		{
			int kmRodada = kmfinal - this.Quilometragem;

			this.Quilometragem += kmRodada;

			//var dao = new VeiculosDao();
			//dao.DbUpdate(this);
		}

		


		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual ICollection<Contratocarro> contratocarro1 { get; set; }
		//public virtual ICollection<Entradasaida> entradasaida { get; set; }
	}
}
