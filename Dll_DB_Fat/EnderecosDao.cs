using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class EnderecosDao : IDbBanco<Enderecos>
	{
		public bool DbAdd(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public Enderecos DbGetEndereco(int id)
		{

			return GetAll()
					.Where(e => e.Id == id)
					.SingleOrDefault();

		}

		public bool DbUpdate(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro(Enderecos registro)
		{
			throw new NotImplementedException();
		}

		public List<Enderecos> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Enderecos>();
		}

		public Enderecos GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public Enderecos GetById(int enderecoId)
		{
			return GetAll()
					.Where(e => e.Id == enderecoId)
					.SingleOrDefault();
		}
	}
}
