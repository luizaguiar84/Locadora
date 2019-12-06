using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFat
{
	public class ClienteLocacaoDao : IDbBanco<ClienteLocacao>
	{
		public bool DbAdd(ClienteLocacao registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<ClienteLocacao>(registro);
		}

		public bool DbUpdate(ClienteLocacao registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<ClienteLocacao>(registro);
		}

		public bool DeleteRegistro(ClienteLocacao registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<ClienteLocacao>(registro);
		}

		public List<ClienteLocacao> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<ClienteLocacao>();
		}

		public ClienteLocacao GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<ClienteLocacao> GetLocacoes(int clienteId)
		{
			return GetAll()
					.Where(l => l.FuncionarioId == clienteId)
					.ToList();
		}
	}
}
