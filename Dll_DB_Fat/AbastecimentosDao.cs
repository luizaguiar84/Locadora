using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
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
			return new DbKernel.Db_Kernel().GetAll<Abastecimentos>();
		}

		public Abastecimentos GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Abastecimentos Add)
		{
			return new DbKernel.Db_Kernel().DbAdd<Abastecimentos>(Add);
		}

		public HashSet<Abastecimentos> GetAbastecimentos(int id)
		{
			return new DbKernel.Db_Kernel().GetAll<Abastecimentos>()
				.Where(a => a.VeiculoId == id)
				.ToHashSet();
		}

		public Abastecimentos GetById(int id)
		{
			return GetAll()
				.Where(a => a.Id == id)
				.SingleOrDefault();
		}
	}
}
