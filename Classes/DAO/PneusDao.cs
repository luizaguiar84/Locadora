using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class PneusDao
	{
		public void DbAdd(Pneus pneu)
		{
			using (var context = new LocadoraContext())
			{
				context.Pneus.Add(pneu);
				context.SaveChanges();
			}
		}

		public void DbUpdateKm(ControlePatio controle, Veiculos veiculo)
		{
			using (var context = new LocadoraContext())
			{
				var pneus = from p in context.Pneus
							where p.VeiculoId == veiculo.Id
							select p;

				var listaPneus = pneus.ToList();
				var kmRodada = controle.KmRetorno - controle.KmSaida;
				foreach (var pneu in listaPneus)
				{
					pneu.KmAtual += kmRodada;

					context.Pneus.Update(pneu);
				}

				context.SaveChanges();
			}
		}

		public void DbUpdateKm(Locacoes locacao, Veiculos veiculo)
		{

			using (var context = new LocadoraContext())
			{
				var pneus = from p in context.Pneus
							where p.VeiculoId == veiculo.Id
							select p;

				var listaPneus = pneus.ToList();
				var kmRodada = locacao.KmDevolucao - locacao.KmInicial;
				foreach (var pneu in listaPneus)
				{
					pneu.KmAtual += kmRodada;

					context.Pneus.Update(pneu);
				}

				context.SaveChanges();
			}
		}
	}
}
