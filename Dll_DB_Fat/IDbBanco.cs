using System.Collections.Generic;

namespace DbFat
{
	public interface IDbBanco<T>
	{
		bool DbAdd(T registro);
		bool DbUpdate(T registro);
		List<T> GetAll();
		bool DeleteRegistro(T registro);
		T GetById(int id);

	}
}
