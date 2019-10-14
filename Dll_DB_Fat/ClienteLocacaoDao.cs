using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class ClienteLocacaoDao : IDbBanco<ClienteLocacao>
	{
		public bool DbAdd(ClienteLocacao registro)
		{
			return new DbKernel().DbAdd<ClienteLocacao>(registro);
		}

		public bool DbUpdate(ClienteLocacao registro)
		{
			return new DbKernel().DbUpdate<ClienteLocacao>(registro);
		}

		public bool DeleteRegistro(ClienteLocacao registro)
		{
			return new DbKernel().DeleteRegistro<ClienteLocacao>(registro);
		}

		public List<ClienteLocacao> GetAll()
		{
			return new DbKernel().GetAll<ClienteLocacao>();
		}

		public ClienteLocacao GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
	}
}
