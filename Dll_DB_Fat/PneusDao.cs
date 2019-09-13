using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_DB_Fat
{
	public class PneusDao : IDbBanco<Pneus>
	{
		
		public bool DbUpdate(Pneus Add)
		{
			return new DbKernel().DbUpdate<Pneus>(Add);
		}

		public void DbUpdateKm(ControlePatio controle, Veiculos veiculo)
		{
			var pneus = GetAll()
						.Where(p => p.Id == veiculo.Id);

			var listaPneus = pneus.ToList();
			var kmRodada = controle.KmRetorno - controle.KmSaida;
			foreach (var pneu in listaPneus)
			{
				pneu.KmAtual += kmRodada;

				DbUpdate(pneu);
			}
		}

		public void DbUpdateKm(Locacoes locacao, Veiculos veiculo)
		{
			var pneus = GetAll()
					.Where(p => p.Id == veiculo.Id);

			var listaPneus = pneus.ToList();
			var kmRodada = locacao.KmDevolucao - locacao.KmInicial;
			foreach (var pneu in listaPneus)
			{
				pneu.KmAtual += kmRodada;
				DbUpdate(pneu);
			}
		}

		public bool DeleteRegistro(Pneus Registro)
		{
			throw new NotImplementedException();
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
	}
}
