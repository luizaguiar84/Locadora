using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ClientesPjDao : IDbBanco<ClientesPJ>
	{
		public bool DbAdd(ClientesPJ registro)
		{
			return new DbKernel().DbAdd<ClientesPJ>(registro);
		}

		public bool DbUpdate(ClientesPJ registro)
		{
			return new DbKernel().DbAdd<ClientesPJ>(registro);
		}

		public bool DeleteRegistro(ClientesPJ registro)
		{
			throw new NotImplementedException();
		}

		public List<ClientesPJ> GetAll()
		{
			return new DbKernel().GetAll<ClientesPJ>();
		}

		public ClientesPJ GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
		public List<ClientesPJ> DbSearch(string filtro, string pesquisa)
		{
			var cliente = GetAll();

			if (filtro == "Razão Social")
			{
				return cliente
						.Where(c => c.RazaoSocial.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "CNPJ")
			{
				return cliente
						.Where(c => c.Cnpj.Contains(pesquisa))
						.ToList();
			}

			return null;
		}
	}
}
