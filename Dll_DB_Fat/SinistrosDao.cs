﻿using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class SinistrosDao : IDbBanco<Sinistros>
	{
		
		public bool DbUpdate(Sinistros update)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Sinistros registro)
		{
			throw new NotImplementedException();
		}

		public List<Sinistros> GetAll()
		{
			return new DbKernel().GetAll<Sinistros>();
		}

		public Sinistros GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Sinistros registro)
		{
			return new DbKernel().DbAdd<Sinistros>(registro);
		}
	}
}