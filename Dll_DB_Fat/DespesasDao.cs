using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class DespesasDao : IDbBanco<Despesas>
	{
		public bool DeleteRegistro(Despesas registro)
		{
			throw new NotImplementedException();
		}

		public List<Despesas> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Despesas>();
		}

		

		public Despesas GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Despesas registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Despesas>(registro);
		}

		public bool DbUpdate(Despesas registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Despesas>(registro);
		}

		public Despesas GetById(int id)
		{
			return GetAll()
							.Where(x => x.Id == id)
							.SingleOrDefault();
		}
	}
}
