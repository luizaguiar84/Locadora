using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class FuncionariosDao : IDbBanco<Funcionarios>
	{

		public List<Funcionarios> GetAll()
		{
			return new DbKernel().GetAll<Funcionarios>();
		}

		public List<Funcionarios> DbSearch(string filtro, string pesquisa)
		{
			var resultado = GetAll();

			if (filtro == "Nome")
			{
				return resultado
						.Where(f => f.Nome.Contains(pesquisa))
						.ToList();
			}

			if (filtro == "RG")
			{
				return resultado
						.Where(f => f.Rg.Contains(pesquisa))
						.ToList();
			}

			if (filtro == "CPF")
			{
				return resultado
						.Where(f => f.Cpf.Contains(pesquisa))
						.ToList();
			}

			if (filtro == "Registro")
			{
				return resultado
						.Where(f => f.Id.ToString().Contains(pesquisa))
						.ToList();
			}

			return null;
		}

		public Funcionarios GetFuncionario(string buscaId)
		{

			int id = Convert.ToInt32(buscaId);

			return GetAll()
					.Where(f => f.Id == id)
					.Single();
		}

		public bool DbAdd(Funcionarios registro)
		{
			return new DbKernel().DbAdd<Funcionarios>(registro);
		}

		public bool DbUpdate(Funcionarios registro)
		{
			return new DbKernel().DbUpdate<Funcionarios>(registro);
		}


		public bool DeleteRegistro(Funcionarios registro)
		{
			return new DbKernel().DeleteRegistro<Funcionarios>(registro);
		}

		public Funcionarios GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
	}
}
