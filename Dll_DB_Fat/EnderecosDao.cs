using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class EnderecosDao : IDbBanco<Enderecos>
	{
		public bool DbAdd(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public Enderecos DbGetEndereco(int id)
		{

			return GetAll()
					.Where(e => e.Id == id)
					.SingleOrDefault();

		}

		public bool DbUpdate(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public List<Enderecos> GetAll()
		{
			return new DbKernel().GetAll<Enderecos>();
		}

		public Enderecos GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
	}
}
