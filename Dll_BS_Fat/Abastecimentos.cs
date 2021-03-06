﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BsFat
{
	public class Abastecimentos : BaseModel
	{
		#region Construtores
		public Abastecimentos()
		{
		}
		public Abastecimentos(DateTime data, string combustivel, decimal litros, decimal valorUnitario, int veiculoId)
		{
			Data = data;
			Combustivel = combustivel;
			Litros = litros;
			ValorUnitario = valorUnitario;
			VeiculoId = veiculoId;
		}
		#endregion

		#region Atributos
		public int Id { get; set; }

		[Required(ErrorMessage = "Favor informar a data do abastecimento")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "mm/dd/yyyy")]
		public DateTime Data { get; set; }

		[Required(ErrorMessage = "Favor informar o tipo de combustível")]
		[Display(Name = "Combustível")]
		public string Combustivel { get; set; }

		[Required(ErrorMessage = "Favor informar a quantidade de litros abastecidos")]
		[Display(Name = "Litros")]
		public decimal Litros { get; set; }

		[Required(ErrorMessage = "Favor informar o valor do litro")]
		[Display(Name = "Valor Unitário")]
		[DisplayFormat(DataFormatString = "{0,c}")]
		public decimal ValorUnitario { get; set; }

		public int VeiculoId { get; set; }

		public virtual Veiculos Veiculo { get; set; } 
		#endregion
	}
}
