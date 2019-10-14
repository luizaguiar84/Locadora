using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ObrigacoesDao : IDbBanco<Obrigacoes>
	{

		public bool DbUpdate(Obrigacoes registro)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Obrigacoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Obrigacoes> GetAll()
		{
			throw new NotImplementedException();
		}

		public Obrigacoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Obrigacoes registro)
		{
			return new DbKernel().DbAdd<Obrigacoes>(registro);
		}

		public HashSet<Obrigacoes> GetObrigacoes(int id)
		{
			return new DbKernel().GetAll<Obrigacoes>()
				.Where(o => o.VeiculoId == id)
				.ToHashSet();
		}
	}
}
