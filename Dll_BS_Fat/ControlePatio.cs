namespace BsFat
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class ControlePatio : BaseModel
	{
		public int Id { get; set; }
		public int VeiculoId { get; set; }
		public int ClienteId { get; set; }

		#region Anota��es
		[Required]
		[DefaultValue(true)]
		[Display(Name = "Status")]
		#endregion
		public bool Status { get; set; }

		#region Anota��es
		[Required]
		[Display(Name = "Placa")]
		#endregion
		public string Placa { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data da Saida")]
		#endregion
		public DateTime? DataSaida { get; set; }

		#region Anota��es

		[DataType(DataType.Time)]
		[Display(Name = "Hora da Saida")]
		#endregion
		public TimeSpan? HoraSaida { get; set; }

		#region Anota��es
		[Display(Name = "Km na Saida")]
		#endregion
		public int KmSaida { get; set; }

		#region Anota��es
		[Display(Name = "Nivel de combust�vel")]
		#endregion
		public string NivelCombustivelSaida { get; set; }

		#region Anota��es
		[Display(Name = "Observa��es")]
		#endregion
		public string ObservacoesSaida { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data do Retorno")]
		#endregion
		public DateTime? DataRetorno { get; set; }

		#region Anota��es
		[Display(Name = "Hora do Retorno")]
		[DataType(DataType.Time)]
		#endregion
		public TimeSpan? HoraRetorno { get; set; }

		#region Anota��es
		[Display(Name = "Estado do carro")]
		#endregion
		public string EstadoRetorno { get; set; }

		#region Anota��es
		[Display(Name = "N�vel de combust�vel")]
		#endregion
		public string NivelCombustivelRetorno { get; set; }

		#region Anota��es
		[Display(Name = "Km")]

		#endregion
		public int KmRetorno { get; set; }

		//#region Anota��es
		//[Display(Name = "Liberado por")]
		//#endregion
		//public string LiberadoSaida { get; set; }


		//#region Anota��es
		//[Display(Name = "Recolhido por")]

		//#endregion
		//public string RecolhidoRetorno { get; set; }

	}
}
