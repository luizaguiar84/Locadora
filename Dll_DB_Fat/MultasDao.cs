using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class MultasDao : IDbBanco<Multas>
	{


		public bool DbUpdate(Multas Add)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Multas>(Add);
		}

		public bool DeleteRegistro(Multas Registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Multas>(Registro);
		}

		public List<Multas> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Multas>();
		}

		public Multas GetById(int id)
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
			return new DbKernel.Db_Kernel().DbAdd<Multas>(Add);
		}

		public Multas GetMulta(int veiculoId)
		{
			return GetAll()
					.Where(m => m.VeiculoId == veiculoId)
					.SingleOrDefault();

		}

		public HashSet<Multas> GetMultas(int id)
		{
			return new DbKernel.Db_Kernel().GetAll<Multas>()
							.Where(m => m.VeiculoId == id)
							.ToHashSet();
		}
	}
}
