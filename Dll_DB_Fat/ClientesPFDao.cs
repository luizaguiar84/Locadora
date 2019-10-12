using Dll_BS_Fat;
using Dll_Db_Kernel;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class ClientesPFDao : IDbBanco<ClientesPF>
	{
		/// <summary>
		/// Adiciona o cliente informado no BD
		/// </summary>
		public bool DbAdd(ClientesPF cliente) => new DbKernel().DbAdd<ClientesPF>(cliente);

		/// <summary>
		/// Faz um update do cliente informado no BD
		/// </summary>
		public bool DbUpdate(ClientesPF cliente) => new DbKernel().DbUpdate<ClientesPF>(cliente);

		public int BuscaId()
		{
			try
			{
				return new DbKernel().GetAll<ClientesPF>()
				.Max(c => c.Id);
			}
			catch (System.Exception)
			{
				return 0;
			}

		}

		/// <summary>
		/// Traz a lista com todos os clientes
		/// </summary>
		/// <returns></returns>
		public List<ClientesPF> GetAll() => new DbKernel().GetAll<ClientesPF>();


		/// <summary>
		/// DeleteRegistro - exclui uma entidade pelo id informado
		/// </summary>
		/// <param name="registro"></param>
		/// <returns></returns>
		public bool DeleteRegistro(ClientesPF registro) => new DbKernel().DeleteRegistro<ClientesPF>(registro);


		/// <summary>
		/// Faz uma busca no BD
		/// </summary>
		/// <param name="filtro">informe o filtro da pesquisa</param>
		/// <param name="pesquisa">Informe a pesquisa</param>
		/// <returns></returns>
		public List<ClientesPF> DbSearch(string filtro, string pesquisa)
		{
			var cliente = GetAll();

			if (filtro == "Nome")
			{
				return cliente
						.Where(c => c.Nome.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "RG")
			{
				return cliente
						.Where(c => c.Rg.Contains(pesquisa))
						.ToList();
			}
			if (filtro == "CPF")
			{
				return cliente
						.Where(c => c.Cpf.Contains(pesquisa))
						.ToList();
			}
			return null;
		}

		/// <summary>
		/// GetRegistroPorCodigo - obtem uma entidade pelo codigo
		/// </summary>
		/// <param name="registro"></param>
		/// <returns></returns>
		public ClientesPF GetRegistroPorCodigo(int id, string registro) => new DbKernel().GetRegistroPorCodigo<ClientesPF>(id, registro);


	}
}
