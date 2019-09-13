using System.Collections.Generic;
using Dll_BS_Fat;
using Dll_Db_Kernel;

namespace Dll_DB_Fat
{
	public class ControlePatioDao : IDbBanco<ControlePatio>
	{
		
		public bool DeleteRegistro(ControlePatio registro)
		{
			throw new System.NotImplementedException();
		}

		public List<ControlePatio> GetAll()
		{
			return new DbKernel().GetAll<ControlePatio>();
		}

		public ControlePatio GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new System.NotImplementedException();
		}

		public bool DbAdd(ControlePatio registro)
		{
			return new DbKernel().DbAdd<ControlePatio>(registro);
		}

		public bool DbUpdate(ControlePatio update)
		{
			return new DbKernel().DbUpdate<ControlePatio>(update);
		}
	}
}
