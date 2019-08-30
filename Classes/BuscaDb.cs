using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class BuscaDb
	{
		public void BuscaCliente(Clientes cliente)
		{
			using (var contexto = new LocadoraContext())
			{

				var resultadoCnh = contexto.Cnhs
									.Where(c => c.Id == cliente.Id)
									.SingleOrDefault();

				var resultadoEndereco = contexto.Enderecos
										.Where(end => end.Id == cliente.Id)
										.SingleOrDefault();

				cliente.Cnh = resultadoCnh;
				cliente.Endereco = resultadoEndereco;
			}
		}

		public void BuscaFuncionario(Funcionarios funcionario)
		{
			using (var contexto = new LocadoraContext())
			{
				var query = from c in contexto.Cnhs
							join end in contexto.Enderecos on
							funcionario.EnderecoId equals end.Id
							where c.Id == funcionario.Id &&
								 end.Id == funcionario.Id
							select new
							{
								c,
								end
							};

				// var resultadoCnh = contexto.Cnhs
				//					.Where(cnh => cnh.Id == funcionario.Id)
				//					.SingleOrDefault();

				//var resultadoEndereco = contexto.Endereco
				//						.Where(endereco => endereco.Id == funcionario.Id)
				//						.SingleOrDefault();

				funcionario.Cnh = query.SingleOrDefault().c;
				funcionario.Endereco = query.SingleOrDefault().end;
			}
		}

	}
}
