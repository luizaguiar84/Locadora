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

		#region Anotações
		[Required]
		[DefaultValue(true)]
		[Display(Name = "Status")]
		#endregion
		public bool Status { get; set; }

		#region Anotações
		[Required]
		[Display(Name = "Placa")]
		#endregion
		public string Placa { get; set; }

		#region Anotações
		[DataType(DataType.Date)]
		[Display(Name = "Data da Saida")]
		#endregion
		public DateTime? DataSaida { get; set; }

		#region Anotações

		[DataType(DataType.Time)]
		[Display(Name = "Hora da Saida")]
		#endregion
		public TimeSpan? HoraSaida { get; set; }

		#region Anotações
		[Display(Name = "Km na Saida")]
		#endregion
		public int KmSaida { get; set; }

		#region Anotações
		[Display(Name = "Nivel de combustível")]
		#endregion
		public string NivelCombustivelSaida { get; set; }

		#region Anotações
		[Display(Name = "Observações")]
		#endregion
		public string ObservacoesSaida { get; set; }

		#region Anotações
		[DataType(DataType.Date)]
		[Display(Name = "Data do Retorno")]
		#endregion
		public DateTime? DataRetorno { get; set; }

		#region Anotações
		[Display(Name = "Hora do Retorno")]
		[DataType(DataType.Time)]
		#endregion
		public TimeSpan? HoraRetorno { get; set; }

		#region Anotações
		[Display(Name = "Estado do carro")]
		#endregion
		public string EstadoRetorno { get; set; }

		#region Anotações
		[Display(Name = "Nível de combustível")]
		#endregion
		public string NivelCombustivelRetorno { get; set; }

		#region Anotações
		[Display(Name = "Km")]

		#endregion
		public int KmRetorno { get; set; }

		//#region Anotações
		//[Display(Name = "Liberado por")]
		//#endregion
		//public string LiberadoSaida { get; set; }


		//#region Anotações
		//[Display(Name = "Recolhido por")]

		//#endregion
		//public string RecolhidoRetorno { get; set; }

	}
}
