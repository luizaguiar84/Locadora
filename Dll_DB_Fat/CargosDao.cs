using BsFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFat
{
	public class CargosDao : IDbBanco<Cargos>
	{
		public bool DbAdd(Cargos registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Cargos>(registro);
		}

		public bool DbUpdate(Cargos registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Cargos>(registro);
		}

		public bool DeleteRegistro(Cargos registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Cargos>(registro);
		}

		public bool CheckCargo(string cargo)
		{
			bool cargoExiste = false;
			var listaCargos = GetAll();
			if (listaCargos == null)
			{
				cargoExiste = false;
			}
			else
			{
				foreach (var cargos in listaCargos)
				{
					if (String.Equals(cargo, cargos.Cargo, StringComparison.OrdinalIgnoreCase))
					{
						cargoExiste = true;
					}
				}
			}
			
			return cargoExiste;
		}

		public List<Cargos> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Cargos>();
		}

		public Cargos GetById(int id)
		{
			return GetAll()
					.Where(c => c.Id == id)
					.Single();
		}
	}
}
