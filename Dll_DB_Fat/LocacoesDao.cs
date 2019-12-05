using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DbFat
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
			return new DbKernel.Db_Kernel().DbAdd<Locacoes>(registro);
		}

		public bool DbUpdate(Locacoes registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Locacoes>(registro);
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
					   join motorista in contexto.Motoristas on cl.ClienteId equals motorista.Id
					   join veiculo in contexto.Veiculos on locacao.VeiculoId equals veiculo.Id
					   where
					   motorista.Id == cl.ClienteId &&
					   locacao.Id == cl.LocacaoId &&
					   veiculo.Id == locacao.VeiculoId
					   select new
					   {
						   OS = locacao.Id,
						   Cliente = motorista.Nome,
						   VeiculoAlugado = veiculo.Modelo,
						   veiculo.Placa,
						   DataInicio = locacao.DataInicio,
						   locacao.DataFinal,
						   IsAtiva = locacao.IsAtiva
					   };
				return q;
			}

		}

		public Locacoes GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}