using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class PneusDao : IDbBanco<Pneus>
	{

		public bool DbUpdate(Pneus Add)
		{
			return new DbKernel().DbUpdate<Pneus>(Add);
		}

		public bool DbUpdateKm(ControlePatio controle, Veiculos veiculo)
		{
			bool ret = false;
			var listaPneus = GetAll()
						.Where(p => p.Id == veiculo.Id)
						.ToList();

			var kmRodada = controle.KmRetorno - controle.KmSaida;
			foreach (var pneu in listaPneus)
			{
				pneu.KmAtual += kmRodada;

				if (DbUpdate(pneu))
				{
					ret = true;
				}
				else
				{
					return ret;
				}
			}
			return ret;
		}

		public bool DbUpdateKm(Locacoes locacao, Veiculos veiculo)
		{
			var pneus = GetAll()
					.Where(p => p.Id == veiculo.Id);

			var listaPneus = pneus.ToList();
			var kmRodada = locacao.KmDevolucao - locacao.KmInicial;
			foreach (var pneu in listaPneus)
			{
				pneu.KmAtual += kmRodada;
				return DbUpdate(pneu);
			}
			return false;
		}

		public bool DeleteRegistro(Pneus Registro)
		{
			return new DbKernel().DeleteRegistro<Pneus>(Registro);
		}

		public List<Pneus> GetAll()
		{
			return new DbKernel().GetAll<Pneus>();
		}

		public Pneus GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Pneus Add)
		{
			return new DbKernel().DbAdd<Pneus>(Add);
		}

		public HashSet<Pneus> GetPneus(int veiculoId)
		{
			return GetAll().Where
				(p => p.VeiculoId == veiculoId)
				.ToHashSet();
		}
		public Pneus GetPneuUnico(int pneuId)
		{
			return GetAll()
				.Where(p => p.Id == pneuId)
				.SingleOrDefault();
		}
	}
}
