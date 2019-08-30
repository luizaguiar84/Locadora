using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class FuncionariosDao
	{
		public void DbAdd(Funcionarios funcionario)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Funcionarios.Add(funcionario);
				contexto.SaveChanges();
			}
		}

		public void DbUpdate(Funcionarios funcionario)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Funcionarios.Update(funcionario);
				contexto.SaveChanges();
			}
		}

		public Funcionarios DbSearch(string _id)
		{
			using (var contexto = new LocadoraContext())
			{
				int id = Convert.ToInt32(_id);

				var funcionario = contexto.Funcionarios
							.Where(f => f.Id == id)
								.Single();

				return funcionario;

			}
		}

		public List<Funcionarios> GetFuncionarios()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Funcionarios.ToList();
			}
		}

		public List<Funcionarios> DbSearch(string filtro, string pesquisa)
		{
			using (var contexto = new LocadoraContext())
			{
				var resultado = from f in contexto.Funcionarios
								select f;

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

		}
	}
}
