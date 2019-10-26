using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;

namespace Dll_DB_Fat
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
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(TipoDespesa registro)
		{
			throw new NotImplementedException();
		}



		public TipoDespesa GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public List<TipoDespesa> GetAll()
		{
			return new DbKernel().GetAll<TipoDespesa>();
		}

		public bool DbAdd(TipoDespesa registro)
		{
			return new DbKernel().DbAdd<TipoDespesa>(registro);
		}
	}
}
