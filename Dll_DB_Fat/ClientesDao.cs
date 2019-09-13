using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_BS_Fat;
using Dll_Db_Kernel;

namespace Dll_DB_Fat
{
	public class ClientesDao : IDbBanco<Clientes>
	{
		/// <summary>
		/// Adiciona o cliente informado no BD
		/// </summary>
		public bool DbAdd(Clientes cliente)
		{
			return new DbKernel().DbAdd<Clientes>(cliente);
		}

		/// <summary>
		/// Faz um update do cliente informado no BD
		/// </summary>
		public bool DbUpdate(Clientes cliente)
		{
			return new DbKernel().DbUpdate<Clientes>(cliente);
		}

		public int BuscaId()
		{		
				return new DbKernel().GetAll<Clientes>()
					.Max(c => c.Id);		
		}

		/// <summary>
		/// Traz a lista com todos os clientes
		/// </summary>
		/// <returns></returns>
		public List<Clientes> GetAll()
		{
			return new DbKernel().GetAll<Clientes>();
		}

		/// <summary>
		/// DeleteRegistro - exclui uma entidade pelo id informado
		/// </summary>
		/// <param name="registro"></param>
		/// <returns></returns>
		public bool DeleteRegistro(Clientes registro)
		{
			return new DbKernel().DeleteRegistro<Clientes>(registro);
		}

		/// <summary>
		/// Faz uma busca no BD
		/// </summary>
		/// <param name="filtro">informe o filtro da pesquisa</param>
		/// <param name="pesquisa">Informe a pesquisa</param>
		/// <returns></returns>
		public List<Clientes> DbSearch(string filtro, string pesquisa)
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
		public Clientes GetRegistroPorCodigo(int id, string registro)
		{
			return new DbKernel().GetRegistroPorCodigo<Clientes>(id, registro);
		}

	
	}
}
