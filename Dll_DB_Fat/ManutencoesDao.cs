using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ManutencoesDao : IDbBanco<Manutencoes>
	{
		public bool DbUpdate(Manutencoes registro)
		{
			return new DbKernel().DbUpdate<Manutencoes>(registro);
  }

		public bool DeleteRegistro(Manutencoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Manutencoes> GetAll()
		{
			return new DbKernel().GetAll<Manutencoes>();
		}

		public Manutencoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Manutencoes registro)
		{
			return new DbKernel().DbAdd<Manutencoes>(registro);
		}

		public HashSet<Manutencoes> GetManutencoes(int id)
		{
			return new DbKernel().GetAll<Manutencoes>()
				.Where(m => m.VeiculoId == id)
				.ToHashSet();
		}
	}
}
