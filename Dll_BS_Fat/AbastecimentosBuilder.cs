using System;

namespace BsFat
{
	public class AbastecimentosBuilder : Abastecimentos
	{
		public Abastecimentos Build()
		{
			return new Abastecimentos(Data, Combustivel, Litros, ValorUnitario, VeiculoId);
		}

		public AbastecimentosBuilder GetData(DateTime data)
		{
			this.Data = data;
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
