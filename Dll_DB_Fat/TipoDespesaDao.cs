using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class TipoDespesaDao : IDbBanco<TipoDespesa>
	{

		public bool DbAddTipo(TipoDespesa tipo)
		{
			bool ret = false;
			bool existe = false;
			var tipos = GetAll();
			foreach (var t in tipos)
			{
				if (tipo.Tipo == t.Tipo)
				{
					existe = true;
					ret = true;
				}
			}
			if (!existe)
			{
				DbAdd(tipo);
				ret = true;
				return ret;
			}
			return ret;
		}

		public bool DbUpdate(TipoDespesa registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate(registro);
		}

		public bool DeleteRegistro(TipoDespesa registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro(registro);
		}



		public TipoDespesa GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public List<TipoDespesa> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<TipoDespesa>();
		}

		public bool DbAdd(TipoDespesa registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<TipoDespesa>(registro);
		}

		public TipoDespesa GetById(int id)
		{
			return GetAll()
				.Where(d => d.Id == id)
				.SingleOrDefault();
		}
	}
}
