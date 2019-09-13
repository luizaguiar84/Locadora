using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class UsuariosDao : IDbBanco<Usuarios>
	{
		

		
		public bool DeleteRegistro(Usuarios registro)
		{
			throw new NotImplementedException();
		}

		

		public Usuarios GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public List<Usuarios> GetAll()
		{
			return new DbKernel().GetAll<Usuarios>();
		}

		public bool DbAdd(Usuarios registro)
		{
			return new DbKernel().DbAdd<Usuarios>(registro);
		}

		public bool DbUpdate(Usuarios registro)
		{
			return new DbKernel().DbUpdate<Usuarios>(registro);
		}
	}
}
