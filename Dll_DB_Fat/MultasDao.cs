using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;

namespace Dll_DB_Fat
{
	public class MultasDao : IDbBanco<Multas>
	{


		public bool DbUpdate(Multas Add)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Multas Registro)
		{
			throw new NotImplementedException();
		}

		public List<Multas> GetAll()
		{
			return new DbKernel().GetAll<Multas>();
		}

		public Multas GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Multas Add)
		{
			return new DbKernel().DbAdd<Multas>(Add);
		}
	}
}
