using Dll_BS_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_Db_Kernel;


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
	}
}
