using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Dll_DB_Fat
{
	public class LocacoesDao : IDbBanco<Locacoes>
	{


		public bool DeleteRegistro(Locacoes registro)
		{
			throw new NotImplementedException();
		}

		public List<Locacoes> GetAll()
		{
			throw new NotImplementedException();
		}

		public Locacoes GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Locacoes registro)
		{
			return new DbKernel().DbAdd<Locacoes>(registro);
		}

		public bool DbUpdate(Locacoes registro)
		{
			return new DbKernel().DbUpdate<Locacoes>(registro);
		}
		public DataTable GetViewLocacoes()
		{
			string query = "SELECT * FROM [dbo].[VW_LOCACOES]";
			return new DbKernelAdo().Select(query);
		}
		public IQueryable GetLocacoes()
		{
			using (var contexto = new LocadoraContext())
			{
				var q =  from locacao in contexto.Locacoes
					   join cl in contexto.ClienteLocacao on locacao.Id equals cl.LocacaoId
					   join cliente in contexto.ClientesPF on cl.ClienteId equals cliente.Id
					   join veiculo in contexto.Veiculos on locacao.VeiculoId equals veiculo.Id
					   where
					   cliente.Id == cl.ClienteId &&
					   locacao.Id == cl.LocacaoId &&
					   veiculo.Id == locacao.VeiculoId
					   select new
					   {
						   OS = locacao.Id,
						   Cliente = cliente.Nome,
						   VeiculoAlugado = veiculo.Modelo,
						   veiculo.Placa,
						   DataInicio = locacao.DataInicio,
						   locacao.DataFinal,
						   IsAtiva = locacao.IsAtiva
					   };
				return q;
			}

		}
	}
}