
using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class AbastecimentosDao : IDbBanco<Abastecimentos>
	{
		
		public bool DbUpdate(Abastecimentos Add)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Abastecimentos Registro)
		{
			throw new NotImplementedException();
		}

		public List<Abastecimentos> GetAll()
		{
			return new DbKernel().GetAll<Abastecimentos>();
		}

		public Abastecimentos GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Abastecimentos Add)
		{
			return new DbKernel().DbAdd<Abastecimentos>(Add);
		}
	}
}
