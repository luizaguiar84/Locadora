using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class SinistrosDao : IDbBanco<Sinistros>
	{

		public bool DbUpdate(Sinistros update)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Sinistros>(update);
		}

		public bool DeleteRegistro(Sinistros registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Sinistros>(registro);
		}

		public List<Sinistros> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Sinistros>();
		}

		public Sinistros GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Sinistros registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Sinistros>(registro);
		}

		public Sinistros GetById(int id)
		{
			return GetAll()
				.Where(s => s.Id == id)
				.SingleOrDefault();
		}

		public HashSet<Sinistros> GetSinistros(int veiculoId)
		{
			return new DbKernel.Db_Kernel().GetAll<Sinistros>()
							.Where(s => s.VeiculoId == veiculoId)
							.ToHashSet();
		}
	}
}
