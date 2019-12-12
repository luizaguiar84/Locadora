using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFat
{
	public class VeiculosPneusDao : IDbBanco<VeiculosPneus>
	{
		public bool DbAdd(VeiculosPneus registro)
		{
			return new Db_Kernel().DbAdd(registro);
		}

		public bool DbUpdate(VeiculosPneus registro)
		{
			return new Db_Kernel().DbUpdate(registro);
		}

		public bool DeleteRegistro(VeiculosPneus registro)
		{
			throw new NotImplementedException();
		}

		public List<VeiculosPneus> GetAll()
		{
			return new Db_Kernel().GetAll<VeiculosPneus>().ToList();
		}

		public VeiculosPneus GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
