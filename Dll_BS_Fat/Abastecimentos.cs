using System;

namespace Dll_BS_Fat
{
	public class Abastecimentos
	{
		public Abastecimentos()
		{
		}
		public Abastecimentos(DateTime data, int km, string combustivel, decimal litros, decimal valorUnitario, int veiculoId)
		{
			Data = data;
			Km = km;
			Combustivel = combustivel;
			Litros = litros;
			ValorUnitario = valorUnitario;
			VeiculoId = veiculoId;
		}

		public int Id { get; set; }
		public DateTime Data { get; set; }
		public int Km { get; set; }
		public string Combustivel { get; set; }
		public decimal Litros { get; set; }
		public decimal ValorUnitario { get; set; }
		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }
	}
}
