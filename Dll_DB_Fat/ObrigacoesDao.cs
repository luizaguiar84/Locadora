using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class ObrigacoesDao : IDbBanco<Obrigacoes>
	{

		public bool DbUpdate(Obrigacoes registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Obrigacoes>(registro);
		}

		public bool DeleteRegistro(Obrigacoes registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Obrigacoes>(registro);
		}

		public List<Obrigacoes> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Obrigacoes>();
		}

		public Obrigacoes GetById(int id)
		{
			return GetAll().Where(o => o.Id == id)
							.SingleOrDefault();
		}

		public Obrigacoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Obrigacoes registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Obrigacoes>(registro);
		}

		public HashSet<Obrigacoes> GetObrigacoes(int id)
		{
			return new DbKernel.Db_Kernel().GetAll<Obrigacoes>()
				.Where(o => o.VeiculoId == id)
				.ToHashSet();
		}
	}
}
