using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class ManutencoesDao : IDbBanco<Manutencoes>
	{
		public bool DbUpdate(Manutencoes registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Manutencoes>(registro);
  }

		public bool DeleteRegistro(Manutencoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Manutencoes> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Manutencoes>();
		}

		public Manutencoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Manutencoes registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Manutencoes>(registro);
		}

		public HashSet<Manutencoes> GetManutencoes(int id)
		{
			return new DbKernel.Db_Kernel().GetAll<Manutencoes>()
				.Where(m => m.VeiculoId == id)
				.ToHashSet();
		}

		public Manutencoes GetById(int id)
		{
			return GetAll()
				.Where(m => m.Id == id)
				.SingleOrDefault();
		}
	}
}
