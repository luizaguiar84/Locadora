using System;

namespace Dll_BS_Fat
{
	public class AbastecimentosBuilder : Abastecimentos
	{
		public Abastecimentos Build()
		{
			return new Abastecimentos(Data, Km, Combustivel, Litros, ValorUnitario, VeiculoId);
		}

		public AbastecimentosBuilder GetData(DateTime data)
		{
			this.Data = data;
			return this;
		}
		public AbastecimentosBuilder GetKm(int km)
		{
			this.Km = km;
			return this;
		}
		public AbastecimentosBuilder GetCombustivel(string combustivel)
		{
			this.Combustivel = combustivel;
			return this;
		}
		public AbastecimentosBuilder GetLitros(decimal litros)
		{
			this.Litros = litros;
			return this;
		}
		public AbastecimentosBuilder GetValorUnitario(decimal valorUnitario)
		{
			this.ValorUnitario = valorUnitario;
			return this;
		}
		public AbastecimentosBuilder GetVeiculoId(int veiculoId)
		{
			this.VeiculoId = veiculoId;
			return this;
		}

	}
}
