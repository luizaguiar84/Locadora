using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFat
{
	public class ClientesPjDao : IDbBanco<ClientesPJ>
	{
		public bool DbAdd(ClientesPJ registro)
		{
			return new DbKernel.Db_Kernel().DbAdd(registro);
		}

		public bool DbUpdate(ClientesPJ registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate(registro);
		}

		public bool DeleteRegistro(ClientesPJ registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<ClientesPJ>(registro);
		}

		public List<ClientesPJ> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<ClientesPJ>();
		}

		public ClientesPJ GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
		public List<ClientesPJ> DbSearch(string filtro, string pesquisa)
		{
			var cliente = GetAll();

			if (filtro == "Razão Social")
			{
				return cliente
						.Where(c => c.RazaoSocial.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "CNPJ")
			{
				return cliente
						.Where(c => c.Cnpj.Contains(pesquisa))
						.ToList();
			}

			return null;
		}
		public ClientesPJ GetById(int clienteId)
		{
			var cliente = GetAll()
				.Where(c => c.Id == clienteId)
				.SingleOrDefault();

			cliente.Endereco = new EnderecosDao().GetById(cliente.EnderecoId);
			cliente.Locacao = new ClienteLocacaoDao().GetLocacoes(cliente.Id);

			return cliente;
		}
	}
}
