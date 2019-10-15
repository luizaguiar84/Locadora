using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
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

		public int BuscaIdMax()
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

		public ClientesPF GetDetalhesMotorista(int id)
		{
			var motorista = GetMotoristas()
							.Where(m => m.Id == id)
							.SingleOrDefault();
			motorista.Endereco = new EnderecosDao().GetEndereco(motorista.EnderecoId);
			motorista.Cnh = new CnhsDao().GetCnh(motorista.CnhId);

			return motorista;
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

		public List<ClientesPF> GetMotoristas()
		{
				return GetAll()
						.Where(c => c.Cnh != null)
						.ToList();
		}


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

		public ClientesPF GetCliente(int clienteId)
		{
			var cliente = GetAll()
				.Where(c => c.Id == clienteId)
				.SingleOrDefault();

			cliente.Cnh = new CnhsDao().GetCnh(cliente.CnhId);
			cliente.Endereco = new EnderecosDao().GetEndereco(cliente.EnderecoId);

			return cliente;
		}


	}
}
