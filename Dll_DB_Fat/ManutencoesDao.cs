using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class ManutencoesDao : IDbBanco<Manutencoes>
	{
		public bool DbUpdate(Manutencoes registro)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Manutencoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Manutencoes> GetAll()
		{
			throw new NotImplementedException();
		}

		public Manutencoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Manutencoes registro)
		{
			return new DbKernel().DbAdd<Manutencoes>(registro);
		}
	}
}
