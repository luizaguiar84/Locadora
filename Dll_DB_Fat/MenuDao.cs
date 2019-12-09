using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFat
{
	public class MenuDao : IDbBanco<Menu>
	{
		public bool DbAdd(Menu registro)
		{
			return new Db_Kernel().DbAdd(registro);
		}

		public bool DbUpdate(Menu registro)
		{
			return new Db_Kernel().DbUpdate(registro);
  }

		public bool DeleteRegistro(Menu registro)
		{
			return new Db_Kernel().DeleteRegistro(registro);
		}

		public List<Menu> GetAll()
		{
			return new Db_Kernel().GetAll<Menu>();
		}

		public Menu GetById(int id)
		{
			return GetAll()
				.Where(m => m.Id == id)
				.SingleOrDefault();

		}
	}
}
