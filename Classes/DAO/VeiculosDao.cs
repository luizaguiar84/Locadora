using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class VeiculosDao
	{
		public void DbAdd(Veiculos veiculo)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Veiculos.Add(veiculo);
				contexto.SaveChanges();
			}
		}

		public void DbUpdate(Veiculos veiculo)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Veiculos.Update(veiculo);
				contexto.SaveChanges();

			}
		}

		public List<Veiculos> DbSearch(string filtro, string pesquisa)
		{
			using (var contexto = new LocadoraContext())
			{
				var busca = from v in contexto.Veiculos
							select v;

				busca.Take(10);


				if (filtro == "Marca")
				{
					return busca
							.Where(v => v.Montadora.Contains(pesquisa))
							.ToList();
				}
				if (filtro == "Modelo")
				{
					return busca
							.Where(v => v.Modelo.Contains(pesquisa))
							.ToList();
				}
				if (filtro == "Placa")
				{
					return busca
							.Where(v => v.Placa.Contains(pesquisa))
							.ToList();
				}
				if (filtro == "Chassi")
				{
					return busca
							.Where(v => v.Chassi.Contains(pesquisa))
							.ToList();
				}
				return null;
			}
		}
		public List<Veiculos> GetVeiculos()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Veiculos.ToList();
			}
		}
	}
}
