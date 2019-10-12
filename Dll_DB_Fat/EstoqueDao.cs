using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;

namespace Dll_DB_Fat
{
	public class EstoqueDao : IDbBanco<Estoque>
	{
		public bool DeleteRegistro(Estoque registro)
		{
			throw new NotImplementedException();
		}


		public List<Estoque> GetAll()
		{
			return new DbKernel().GetAll<Estoque>();
		}

		public Estoque GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Estoque registro)
		{
			return new DbKernel().DbAdd<Estoque>(registro);
		}

		public bool DbUpdate(Estoque update)
		{
			return new DbKernel().DbUpdate<Estoque>(update);
		}
	}
}
