using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class ControlePatioDao : IDbBanco<ControlePatio>
	{

		public bool DeleteRegistro(ControlePatio registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<ControlePatio>(registro);
		}

		public List<ControlePatio> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<ControlePatio>();
		}

		public ControlePatio GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new System.NotImplementedException();
		}

		public bool DbAdd(ControlePatio registro)
		{
			var carro = new VeiculosDao().GetById(registro.VeiculoId);
			if (carro.Disponivel == true)
			{
				carro.Disponivel = false;
				new VeiculosDao().DbUpdate(carro);
				return new DbKernel.Db_Kernel().DbAdd<ControlePatio>(registro);
			}
			return false;
		}

		public bool DbUpdate(ControlePatio update)
		{
			return new DbKernel.Db_Kernel().DbUpdate<ControlePatio>(update);
		}

		public List<ControlePatio> GetCarrosFora()
		{
			return GetAll()
					.Where(c => c.Status == true)
					.ToList();
		}

		public ControlePatio GetById(int id)
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
