using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class EstoqueDao : IDbBanco<Estoque>
	{
		public bool DeleteRegistro(Estoque registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Estoque>(registro);
		}


		public List<Estoque> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Estoque>();
		}

		public Estoque GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Estoque registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Estoque>(registro);
		}

		public Estoque GetById(int id)
		{
			return GetAll()
				.Where(e => e.Id == id)
				.SingleOrDefault();
		}

		public bool DbUpdate(Estoque update)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Estoque>(update);
		}

		public List<Estoque> PesquisaItem(string busca)
		{
			return GetAll()
				.Where(e => e.Peca.Contains(busca))
				.ToList();
		}
	}
}
