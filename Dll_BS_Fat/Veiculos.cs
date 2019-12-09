namespace BsFat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Veiculos : BaseModel, IComparable
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
			string combustivel, string valorAtual, string observacoes, DateTime? dataAquisicao, bool arCondicionado, bool direcaoHidraulica, bool vidroEletrico,
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
			//ValorDiaria = valorDiaria;
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

		#region Atributos
		#region Anota��es
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor informar a Montadora")]
		[Display(Name = "Montadora")]
		#endregion
		public string Montadora { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor informar o modelo do ve�culo")]
		[Display(Name = "Modelo")]
		#endregion
		public string Modelo { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o ano e modelo do ve�culo")]
		[Display(Name = "Ano / Modelo", Description = "Ano e Modelo do veiculo")]
		#endregion
		public string AnoModelo { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o N� de portas do veiculo")]
		[Display(Name = "N� de Portas")]
		#endregion
		public int Portas { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe a cor do ve�culo")]
		[Display(Name = "Cor")]
		#endregion
		public string Cor { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe a placa do veiculo")]
		[Display(Name = "Placa")]
		[MaxLength(8)]
		#endregion
		public string Placa { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o RENAVAM do veiculo")]
		[Display(Name = "RENAVAM")]
		#endregion
		public string Renavam { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o chassi do veiculo")]
		[Display(Name = "Chassi")]
		#endregion
		public string Chassi { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o numero de lugares do veiculo")]
		[Display(Name = "Lugares")]
		#endregion
		public int Lugares { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe a KM do ve�culo")]
		[Display(Name = "Quilometragem")]
		#endregion
		public int Quilometragem { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "informe o Status do veiculo")]
		[Display(Name = "Status")]
		#endregion
		public string Status { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Informe o tipo de combustivel do veiculo")]
		[Display(Name = "Combust�vel")]
		#endregion
		public string Combustivel { get; set; }

		#region Anota��es
		[Display(Name = "Valor de mercado na compra")]
		[DataType(DataType.Currency)]
		#endregion
		public string ValorAtual { get; set; }
		[DefaultValue(true)]
		public bool Disponivel { get; set; }


		//#region Anota��es
		//[Required(ErrorMessage = "Favor informar o valor da di�ria.")]
		//[DisplayFormat(DataFormatString = "{0,c}")]
		//[Display(Name = "Valor da di�ria")]
		//[DataType(DataType.Currency)]
		//[Range(1, 9999, ErrorMessage = "O {0} deve estar entre {1} e {2}")]
		//#endregion
		//public decimal ValorDiaria { get; set; }

		#region Anota��es
		[Display(Name = "Observa��es")]
		[DataType(DataType.MultilineText)]
		#endregion
		public string Observacoes { get; set; }

		#region Anota��es
		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Data de Aquisi��o")]
		#endregion
		public DateTime? DataAquisicao { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(false)]
		[Display(Name = "Ar Condicionado")]
		#endregion
		public bool ArCondicionado { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(false)]
		[Display(Name = "Dire��o Hidr�ulica")]
		#endregion
		public bool DirecaoHidraulica { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(false)]
		[Display(Name = "Vidros El�tricos")]
		#endregion
		public bool VidroEletrico { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(false)]
		[Display(Name = "Air Bag")]
		#endregion
		public bool AirBag { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(false)]
		[Display(Name = "Freios ABS")]
		#endregion
		public bool Abs { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(true)]
		[Display(Name = "Veiculo Ativo?")]
		#endregion
		public bool IsAtivo { get; set; }


		public virtual ICollection<Abastecimentos> Abastecimentos { get; set; }
		public virtual ICollection<Manutencoes> Manutencao { get; set; }
		public virtual ICollection<Sinistros> Sinistros { get; set; }
		public virtual ICollection<Obrigacoes> Obrigacoes { get; set; }
		public virtual ICollection<Multas> Multas { get; set; }
		public virtual ICollection<Pneus> Pneu { get; set; } 
		#endregion

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
