using System;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Sinistros : BaseModel
	{
		#region Consutrutores
		public Sinistros()
		{

		}
		public Sinistros(DateTime data, int km, string descricao, decimal valor, int veiculoId)
		{
			Data = data;
			Km = km;
			Descricao = descricao;
			Valor = valor;
			VeiculoId = veiculoId;
		}

		#endregion

		#region Anotações
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anotações
		[DataType(DataType.Date)]
		#endregion
		public DateTime Data { get; set; }

		#region Anotações
		[Display(Name = "Km")]
		#endregion
		public int Km { get; set; }

		#region Anotações
		[Display(Name = "Descrição")]
		#endregion
		public string Descricao { get; set; }

		#region Anotações
		[DataType(DataType.Currency)]
		#endregion
		public decimal Valor { get; set; }

		public virtual Veiculos Veiculo { get; set; }
		public int VeiculoId { get; set; }


	}
}
