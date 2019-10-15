using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ControlePatioDao : IDbBanco<ControlePatio>
	{

		public bool DeleteRegistro(ControlePatio registro)
		{
			return new DbKernel().DeleteRegistro<ControlePatio>(registro);
		}

		public List<ControlePatio> GetAll()
		{
			return new DbKernel().GetAll<ControlePatio>();
		}

		public ControlePatio GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new System.NotImplementedException();
		}

		public bool DbAdd(ControlePatio registro)
		{
			return new DbKernel().DbAdd<ControlePatio>(registro);
		}

		public bool DbUpdate(ControlePatio update)
		{
			return new DbKernel().DbUpdate<ControlePatio>(update);
		}

		public List<ControlePatio> GetCarrosFora()
		{
			return GetAll()
					.Where(c => c.Status == true)
					.ToList();
		}

		public ControlePatio GetControle(int id)
		{
			return  GetAll()
					.Where(c => c.Id == id)
					.SingleOrDefault();
			
		}

		public bool RegistraRetorno(ControlePatio controle, Veiculos veiculo)
		{
			bool ret = false;

			if (new PneusDao().DbUpdateKm(controle, veiculo))
			{
				if (new VeiculosDao().RegistrarKmDb(veiculo, controle.KmRetorno))
				{
					if (DbUpdate(controle))
					{
						ret = true;
					}
				}
			}
			return ret;
		}
	}
}
