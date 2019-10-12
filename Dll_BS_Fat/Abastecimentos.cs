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

		public int Id { get; private set; }
		public DateTime Data { get; protected set; }
		public int Km { get; protected set; }
		public string Combustivel { get; protected set; }
		public decimal Litros { get; protected set; }
		public decimal ValorUnitario { get; protected set; }
		public int VeiculoId { get; protected set; }
		public virtual Veiculos Veiculo { get; protected set; }
	}
}
