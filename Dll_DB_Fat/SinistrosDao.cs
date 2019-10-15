using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class SinistrosDao : IDbBanco<Sinistros>
	{

		public bool DbUpdate(Sinistros update)
		{
			return new DbKernel().DbUpdate<Sinistros>(update);
		}

		public bool DeleteRegistro(Sinistros registro)
		{
			return new DbKernel().DeleteRegistro<Sinistros>(registro);
		}

		public List<Sinistros> GetAll()
		{
			return new DbKernel().GetAll<Sinistros>();
		}

		public Sinistros GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Sinistros registro)
		{
			return new DbKernel().DbAdd<Sinistros>(registro);
		}

		public Sinistros GetSinistro(int id)
		{
			return GetAll()
				.Where(s => s.Id == id)
				.SingleOrDefault();
		}

		public HashSet<Sinistros> GetSinistros(int veiculoId)
		{
			return new DbKernel().GetAll<Sinistros>()
							.Where(s => s.VeiculoId == veiculoId)
							.ToHashSet();
		}
	}
}
