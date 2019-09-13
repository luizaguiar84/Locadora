using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class DespesasDao : IDbBanco<Despesas>
	{
		


		public bool DeleteRegistro(Despesas registro)
		{
			throw new NotImplementedException();
		}

		public List<Despesas> GetAll()
		{
			return new DbKernel().GetAll<Despesas>();
		}

		public Despesas GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool  DbAdd(Despesas registro)
		{
			return new DbKernel().DbAdd<Despesas>(registro);
		}

		public bool  DbUpdate(Despesas registro)
		{
			return new DbKernel().DbUpdate<Despesas>(registro);
		}
	}
}
