using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class PneusDao : IDbBanco<Pneus>
	{

		public bool DbUpdate(Pneus pneu)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Pneus>(pneu);
		}

		public bool DbUpdateKm(int kmRodado, int veiculoId)
		{
			bool ret = false;

			var listaPneus = GetPneusVeiculo(veiculoId);
						
			if (listaPneus.Count == 0) 
			{ 
				return true;
			}
			else
			{
				foreach (var pneu in listaPneus)
				{
					pneu.KmAtual += kmRodado;
					
					if (new DbKernel.Db_Kernel().DbUpdate<Pneus>(pneu))
					{
						ret = true;
					}
					else
					{
						ret = false;
					}
				}
			}
			
			return ret;
		}

		public bool DbUpdateKm1(Locacoes locacao, Veiculos veiculo)
		{
			List<Pneus> pneus = GetAll()
					.Where(p => p.Id == veiculo.Id)
					.ToList();

			var kmRodada = locacao.KmDevolucao - locacao.KmInicial;
			foreach (var pneu in pneus)
			{
				pneu.KmAtual = pneu.KmAtual + kmRodada;

				return DbUpdate(pneu);
			}
			return false;
		}

		public bool DeleteRegistro(Pneus Registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro<Pneus>(Registro);
		}

		public List<Pneus> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Pneus>();
		}

		public Pneus GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public bool DbAdd(Pneus Add)
		{
			return new DbKernel.Db_Kernel().DbAdd<Pneus>(Add);
		}

		
		public Pneus GetById(int pneuId)
		{
			return GetAll()
				.Where(p => p.Id == pneuId)
				.SingleOrDefault();
		}
		public List<Pneus> GetPneusVeiculo(int veiculoId)
		{
			List<Pneus> listaPneusVeiculo = new List<Pneus>();

			var veiculo = new VeiculosDao().GetById(veiculoId);
			var listaPneus = new VeiculosPneusDao().GetAll().Where(v => v.VeiculosId == veiculoId).ToList();
			foreach (var pneu in listaPneus)
			{
				listaPneusVeiculo.Add(GetById(pneu.PneusId));
			}

			return listaPneusVeiculo;

		}
	}
}
