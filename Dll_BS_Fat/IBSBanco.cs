using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_BS_Fat
{
	public interface IBSBanco<T> where T : class
	{
		bool DbAdd();
		bool DbUpdate();
		List<T> GetAll();
		bool DeleteRegistro();
	}
}
