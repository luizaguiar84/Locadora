using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class FuncionariosDao : IDbBanco<Funcionarios>
	{

		public List<Funcionarios> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Funcionarios>();
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

		public List<Funcionarios> GetMotoristas()
		{
			return GetAll()
				.Where(c => c.CnhId != null && c.Disponivel)
				.ToList();
		}
		public List<Funcionarios> GetNaoMotoristas()
		{
			List<Funcionarios> listaFunc = new List<Funcionarios>();
			
			var lista = GetAll();
			foreach (var motorista in lista)
			{
				if (String.IsNullOrWhiteSpace(GetById(motorista.Id).Cnh.Numero))
				{
					listaFunc.Add(motorista);
				}
			}
			return listaFunc;
		}

		public Funcionarios GetFuncionario(string buscaId)
		{

			int id = Convert.ToInt32(buscaId);

			return GetById(id);

		}
			public int BuscaIdMax()
		{
			try
			{
				return new DbKernel.Db_Kernel().GetAll<Funcionarios>()
				.Max(c => c.Id);
			}
			catch (System.Exception)
			{
				return 0;
			}

		}
	

	public Funcionarios GetById(int id)
		{
			var funcionario = new FuncionariosDao().GetAll()
				.Where(f => f.Id == id)
				.SingleOrDefault();
			//if (funcionario.CnhId != null)
			//{
			//	int _id = (int)funcionario.CnhId;
			//	funcionario.Cnh = new CnhsDao().GetById(_id);
			//}
			funcionario.Cnh = new CnhsDao().GetById((int)funcionario.CnhId);
			funcionario.Cargo = new CargosDao().GetById(funcionario.CargoId);
			funcionario.Endereco = new EnderecosDao().GetById(funcionario.EnderecoId);

			return funcionario;
		}

		public bool DbAdd(Funcionarios registro)
		{
			return new DbKernel.Db_Kernel().DbAdd<Funcionarios>(registro);
		}

		public bool DbUpdate(Funcionarios registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Funcionarios>(registro);
		}


		public bool DeleteRegistro(Funcionarios registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Funcionarios>(registro);
		}

		public Funcionarios GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}
	}
}
