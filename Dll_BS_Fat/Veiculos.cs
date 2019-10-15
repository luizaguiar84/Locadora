namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Veiculos : IComparable
	{
		#region Construtores
		public Veiculos()
		{
			this.Pneu = new HashSet<Pneus>();
			this.Abastecimentos = new HashSet<Abastecimentos>();
			this.Manutencao = new HashSet<Manutencoes>();
			this.Sinistros = new HashSet<Sinistros>();
			this.Obrigacoes = new HashSet<Obrigacoes>();
			this.Multas = new HashSet<Multas>();
		}

		public Veiculos(string montadora, string modelo, string anoModelo, int portas, string cor, string placa, string renavam, string chassi, int lugares, int quilometragem, string status,
			string combustivel, string valorAtual, decimal valorDiaria, string observacoes, DateTime? dataAquisicao, bool arCondicionado, bool direcaoHidraulica, bool vidroEletrico,
			bool airBag, bool abs, bool isAtivo)
		{
			Montadora = montadora;
			Modelo = modelo;
			AnoModelo = anoModelo;
			Portas = portas;
			Cor = cor;
			Placa = placa;
			Renavam = renavam;
			Chassi = chassi;
			Lugares = lugares;
			Quilometragem = quilometragem;
			Status = status;
			Combustivel = combustivel;
			ValorAtual = valorAtual;
			ValorDiaria = valorDiaria;
			Observacoes = observacoes;
			DataAquisicao = dataAquisicao;
			ArCondicionado = arCondicionado;
			DirecaoHidraulica = direcaoHidraulica;
			VidroEletrico = vidroEletrico;
			AirBag = airBag;
			Abs = abs;
			IsAtivo = isAtivo;

			this.Pneu = new HashSet<Pneus>();
			this.Abastecimentos = new HashSet<Abastecimentos>();
			this.Manutencao = new HashSet<Manutencoes>();
			this.Sinistros = new HashSet<Sinistros>();
			this.Obrigacoes = new HashSet<Obrigacoes>();
			this.Multas = new HashSet<Multas>();
		}

		#endregion

		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Display(Name = "Montadora")]
		#endregion
		public string Montadora { get; set; }

		#region Anotações
		[Display(Name = "Modelo")]
		#endregion
		public string Modelo { get; set; }

		#region Anotações
		[Display(Name = "Ano / Modelo", Description = "Ano e Modelo do veiculo")]
		#endregion
		public string AnoModelo { get; set; }

		#region Anotações
		[Display(Name = "N. de Portas")]
		#endregion
		public int Portas { get; set; }

		#region Anotações
		[Display(Name = "Cor")]
		#endregion
		public string Cor { get; set; }

		#region Anotações
		[Display(Name = "Placa")]
		#endregion
		public string Placa { get; set; }

		#region Anotações
		[Display(Name = "RENAVAM")]
		#endregion
		public string Renavam { get; set; }

		#region Anotações
		[Display(Name = "Chassi")]
		#endregion
		public string Chassi { get; set; }

		#region Anotações
		[Display(Name = "Lugares")]
		#endregion
		public int Lugares { get; set; }

		#region Anotações
		[Display(Name = "Quilometragem")]
		#endregion
		public int Quilometragem { get; set; }

		#region Anotações
		[Display(Name = "Status")]
		#endregion
		public string Status { get; set; }

		#region Anotações
		[Display(Name = "Combustível")]
		#endregion
		public string Combustivel { get; set; }

		#region Anotações
		[Display(Name = "Valor de mercado na compra")]
		[DataType(DataType.Currency)]
		#endregion
		public string ValorAtual { get; set; }

		#region Anotações
		[Display(Name = "Valor da diária")]
		[DataType(DataType.Currency)]
		#endregion
		public decimal ValorDiaria { get; set; }

		#region Anotações
		[Display(Name = "Observações")]
		[DataType(DataType.MultilineText)]
		#endregion
		public string Observacoes { get; set; }

		#region Anotações
		[DataType(DataType.Date)]
		[Display(Name = "Data de Aquisição")]
		#endregion
		public DateTime? DataAquisicao { get; set; }

		#region Anotações
		[DefaultValue(false)]
		[Display(Name = "Ar Condicionado")]
		#endregion
		public bool ArCondicionado { get; set; }

		#region Anotações
		[DefaultValue(false)]
		[Display(Name = "Direção Hidráulica")]
		#endregion
		public bool DirecaoHidraulica { get; set; }

		#region Anotações
		[DefaultValue(false)]
		[Display(Name = "Vidros Elétricos")]
		#endregion
		public bool VidroEletrico { get; set; }

		#region Anotações
		[DefaultValue(false)]
		[Display(Name = "Air Bag")]
		#endregion
		public bool AirBag { get; set; }

		#region Anotações
		[DefaultValue(false)]
		[Display(Name = "Freios ABS")]
		#endregion
		public bool Abs { get; set; }

		#region Anotações
		[DefaultValue(true)]
		[Display(Name = "Ativo?")]
		#endregion
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

		//public virtual Contratocarro contratocarro { get; set; }
		//public virtual ICollection<Contratocarro> contratocarro1 { get; set; }
		//public virtual ICollection<Entradasaida> entradasaida { get; set; }
	}
}
