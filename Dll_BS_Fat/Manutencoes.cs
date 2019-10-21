
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

		public int Id { get; set; }
		[DataType(DataType.Date)]
		[Display(Name = "Data da Manutenção")]
		public DateTime Data { get; set; }
		public int Km { get; set; }
		[MaxLength(250)]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }
		[DataType(DataType.Currency)]
		public decimal Valor { get; set; }
		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }



	}
}
