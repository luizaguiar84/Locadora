using Dll_BS_Fat;
using Dll_Db_Kernel;
using System.Collections.Generic;
using System.Linq;


namespace Dll_DB_Fat
{
	public class VeiculosDao : IDbBanco<Veiculos>
	{
		public bool DbAdd(Veiculos veiculo)
		{
			return new DbKernel().DbAdd<Veiculos>(veiculo);
		}

		public bool DbUpdate(Veiculos veiculo)
		{
			return new DbKernel().DbUpdate<Veiculos>(veiculo);
		}

		public List<Veiculos> DbSearch(string filtro, string pesquisa)
		{
			var busca = new DbKernel().GetAll<Veiculos>();

			if (filtro == "Marca")
			{
				return busca
						.Where(v => v.Montadora.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "Modelo")
			{
				return busca
						.Where(v => v.Modelo.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "Placa")
			{
				return busca
						.Where(v => v.Placa.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "Chassi")
			{
				return busca
						.Where(v => v.Chassi.Contains(pesquisa))
						.ToList();
			}
			return null;
		}

		/// <summary>
		/// Retorna uma lista com todos os veiculos
		/// </summary>
		/// <returns></returns>
		public List<Veiculos> GetAll()
		{
			return new DbKernel().GetAll<Veiculos>();
		}

		public bool DeleteRegistro(Veiculos registro)
		{
			return new DbKernel().DeleteRegistro<Veiculos>(registro);
		}

		public Veiculos GetRegistroPorCodigo(int classeId, string registro)
		{
			return new DbKernel().GetRegistroPorCodigo<Veiculos>(classeId, registro);
		}

		/// <summary>
		/// Registra a Km rodada do carro
		/// </summary>
		/// <param name="kmfinal">Quilometragem final</param>
		public bool RegistrarKmDb(Veiculos veiculo, int kmfinal)
		{
			int kmRodada = kmfinal - veiculo.Quilometragem;
			veiculo.Quilometragem += kmRodada;
			return DbUpdate(veiculo);
		}


	}
}