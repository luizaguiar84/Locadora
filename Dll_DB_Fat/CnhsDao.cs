using Dll_BS_Fat;
using Dll_Db_Kernel;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class CnhsDao : IDbBanco<Cnhs>
	{
		public bool DbAdd(Cnhs Add)
		{
			throw new System.NotImplementedException();
		}

		public Cnhs DbGetCnh(int id)
		{
			return GetAll()
					.Where(c => c.Id == id)
					.Single();
		}

		public bool DbUpdate(Cnhs Add)
		{
			throw new System.NotImplementedException();
		}

		public bool DeleteRegistro(Cnhs Registro)
		{
			throw new System.NotImplementedException();
		}

		public List<Cnhs> GetAll()
		{
			throw new System.NotImplementedException();
		}

		public Cnhs GetRegistroPorCodigo(int id, string registro)
		{
			return new DbKernel().GetRegistroPorCodigo<Cnhs>(id, registro);
		}
	}
}
