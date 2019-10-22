using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class EstoqueDao : IDbBanco<Estoque>
	{
		public bool DeleteRegistro(Estoque registro)
		{
			return new DbKernel().DeleteRegistro<Estoque>(registro);
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

		public Estoque GetDetalhe(int id)
		{
			return GetAll()
				.Where(e => e.Id == id)
				.SingleOrDefault();
		}

		public bool DbUpdate(Estoque update)
		{
			return new DbKernel().DbUpdate<Estoque>(update);
		}
	}
}
