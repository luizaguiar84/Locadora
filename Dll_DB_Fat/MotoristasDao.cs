using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class MotoristasDao : IDbBanco<Motoristas>
	{
		/// <summary>
		/// Adiciona o cliente informado no BD
		/// </summary>
		public bool DbAdd(Motoristas cliente) => new DbKernel.Db_Kernel().DbAdd<Motoristas>(cliente);

		/// <summary>
		/// Faz um update do cliente informado no BD
		/// </summary>
		public bool DbUpdate(Motoristas cliente) => new DbKernel.Db_Kernel().DbUpdate<Motoristas>(cliente);

		public int BuscaIdMax()
		{
			try
			{
				return new DbKernel.Db_Kernel().GetAll<Motoristas>()
				.Max(c => c.Id);
			}
			catch (System.Exception)
			{
				return 0;
			}

		}

		public Motoristas GetDetalhesMotorista(int id)
		{
			var motorista = GetMotoristas()
							.Where(m => m.Id == id)
							.SingleOrDefault();
			motorista.Endereco = new EnderecosDao().GetById(motorista.EnderecoId);
			motorista.Cnh = new CnhsDao().GetById(motorista.CnhId);

			return motorista;
		}

		/// <summary>
		/// Traz a lista com todos os clientes
		/// </summary>
		/// <returns></returns>
		public List<Motoristas> GetAll() => new DbKernel.Db_Kernel().GetAll<Motoristas>();


		/// <summary>
		/// DeleteRegistro - exclui uma entidade pelo id informado
		/// </summary>
		/// <param name="registro"></param>
		/// <returns></returns>
		public bool DeleteRegistro(Motoristas registro) => new DbKernel.Db_Kernel().DeleteRegistro<Motoristas>(registro);

		public List<Motoristas> GetMotoristas()
		{
			return GetAll()
					.Where(c => c.CnhId > 0)
					.ToList();
		}


		/// <summary>
		/// Faz uma busca no BD
		/// </summary>
		/// <param name="filtro">informe o filtro da pesquisa</param>
		/// <param name="pesquisa">Informe a pesquisa</param>
		/// <returns></returns>
		public List<Motoristas> DbSearch(string filtro, string pesquisa)
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
		public Motoristas GetRegistroPorCodigo(int id, string registro) => new DbKernel.Db_Kernel().GetRegistroPorCodigo<Motoristas>(id, registro);

		public Motoristas GetById(int clienteId)
		{
			var cliente = GetAll()
				.Where(c => c.Id == clienteId)
				.SingleOrDefault();

			cliente.Cnh = new CnhsDao().GetById(cliente.CnhId);
			cliente.Endereco = new EnderecosDao().GetById(cliente.EnderecoId);
			cliente.Locacao = new ClienteLocacaoDao().GetLocacoes(cliente.Id);

			return cliente;
		}

	}
}
