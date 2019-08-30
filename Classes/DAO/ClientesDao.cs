using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;

namespace Classes.DAO
{
	public class ClientesDao
	{
		/// <summary>
		/// Adiciona o cliente informado no BD
		/// </summary>
		public void DbAdd(Clientes cliente)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Clientes.Add(cliente);
				contexto.SaveChanges();
			}
		}

		/// <summary>
		/// Faz um update do cliente informado no BD
		/// </summary>
		public void DbUpdate(Clientes cliente)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Clientes.Update(cliente);
				contexto.SaveChanges();
			}
		}

		/// <summary>
		/// Traz a lista com todos os clientes
		/// </summary>
		/// <returns></returns>
		public List<Clientes> GetClientes()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Clientes.ToList();
			}
		}

		/// <summary>
		/// Faz uma busca no BD
		/// </summary>
		/// <param name="filtro">informe o filtro da pesquisa</param>
		/// <param name="pesquisa">Informe a pesquisa</param>
		/// <returns></returns>
		public List<Clientes> DbSearch(string filtro, string pesquisa)
		{
			using (var contexto = new LocadoraContext())
			{
				var cliente = from c in contexto.Clientes
							  select c;

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
		}

		public Clientes GetClienteBd(string _id)
		{

			if (_id != "")
			{
				using (var contexto = new LocadoraContext())
				{
					int id = Convert.ToInt32(_id);

					var _cliente = contexto.Clientes
								.Where(c => c.Id == id)
									.Single();
					return _cliente;
				}
			}
			return null;

		}
	}
}
