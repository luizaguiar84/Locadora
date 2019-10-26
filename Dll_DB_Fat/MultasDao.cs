using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class MultasDao : IDbBanco<Multas>
	{


		public bool DbUpdate(Multas Add)
		{
			return new DbKernel().DbUpdate<Multas>(Add);
		}

		public bool DeleteRegistro(Multas Registro)
		{
			return new DbKernel().DeleteRegistro<Multas>(Registro);
		}

		public List<Multas> GetAll()
		{
			return new DbKernel().GetAll<Multas>();
		}

		public Multas GetMultaId(int id)
		{
			return GetAll()
				.Where(m => m.Id == id)
				.SingleOrDefault();
		}

		public Multas GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Multas Add)
		{
			return new DbKernel().DbAdd<Multas>(Add);
		}

		public Multas GetMulta(int veiculoId)
		{
			return GetAll()
					.Where(m => m.VeiculoId == veiculoId)
					.SingleOrDefault();

		}

		public HashSet<Multas> GetMultas(int id)
		{
			return new DbKernel().GetAll<Multas>()
							.Where(m => m.VeiculoId == id)
							.ToHashSet();
		}
	}
}
