using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class LocacoesDao : IDbBanco<Locacoes>
	{
		

		public bool DeleteRegistro(Locacoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Locacoes> GetAll()
		{
			throw new NotImplementedException();
		}

		public Locacoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Locacoes registro)
		{
			return new DbKernel().DbAdd<Locacoes>(registro);
		}

		public bool DbUpdate(Locacoes registro)
		{
			return new DbKernel().DbUpdate<Locacoes>(registro);
		}
	}
}
