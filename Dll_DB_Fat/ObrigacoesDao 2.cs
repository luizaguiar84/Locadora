using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ObrigacoesDao : IDbBanco<Obrigacoes>
	{

		public bool DbUpdate(Obrigacoes registro)
		{
			return new DbKernel().DbUpdate<Obrigacoes>(registro);
		}

		public bool DeleteRegistro(Obrigacoes registro)
		{
			return new DbKernel().DeleteRegistro<Obrigacoes>(registro);
		}

		public List<Obrigacoes> GetAll()
		{
			return new DbKernel().GetAll<Obrigacoes>();
		}

		public Obrigacoes GetObrigacao(int id)
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
			return new DbKernel().DbAdd<Obrigacoes>(registro);
		}

		public HashSet<Obrigacoes> GetObrigacoes(int id)
		{
			return new DbKernel().GetAll<Obrigacoes>()
				.Where(o => o.VeiculoId == id)
				.ToHashSet();
		}
	}
}
