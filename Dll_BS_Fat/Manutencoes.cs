
namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Manutencoes : BaseModel
	{
		#region Construtores
		public Manutencoes()
		{

		}
		public Manutencoes(DateTime data, int km, string descricao, decimal valor, int veiculoId)
		{
			Data = data;
			Km = km;
			Descricao = descricao;
			Valor = valor;
			VeiculoId = veiculoId;
		}
		#endregion

		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Inserir a data da manutenção")]
		[DataType(DataType.Date)]
		[Display(Name = "Data da Manutenção")]
		public DateTime Data { get; set; }

		[Required(ErrorMessage = "Inserir a KM do veiculo na manutenção")]
		[Display(Name = "KM")]
		public int Km { get; set; }

		[MaxLength(250)]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "Favor informar o valor da Manutenção")]
		[DataType(DataType.Currency)]
		[DisplayFormat(DataFormatString = "{0,c}")]
		[Display(Name = "Valor")]
		public decimal Valor { get; set; }


		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }



	}
}
