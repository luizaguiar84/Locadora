using BsFat;
using DbKernel;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class CnhsDao : IDbBanco<Cnhs>
	{
		public bool DbAdd(Cnhs Add)
		{
			return new DbKernel.Db_Kernel().DbAdd(Add);
		}

		public Cnhs GetById(int cnhId)
		{
			return GetAll()
					.Where(c => c.Id == cnhId)
					.SingleOrDefault();
		}

		public bool DbUpdate(Cnhs Add)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Cnhs>(Add);
		}

		public bool DeleteRegistro(Cnhs Registro)
		{
			throw new System.NotImplementedException();
		}

		public List<Cnhs> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Cnhs>();
		}

		public Cnhs GetRegistroPorCodigo(int id, string registro)
		{
			return new DbKernel.Db_Kernel().GetRegistroPorCodigo<Cnhs>(id, registro);
		}
	}
}
