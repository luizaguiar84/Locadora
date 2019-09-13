using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public interface IDbBanco<T>
	{
		bool DbAdd(T registro);
		bool DbUpdate(T registro);
		List<T> GetAll();
		bool DeleteRegistro(T registro);
		T GetRegistroPorCodigo(int classeId, string registro);

	}
}
