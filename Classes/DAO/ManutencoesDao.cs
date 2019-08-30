using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class ManutencoesDao
	{
		public void DbAdd(Manutencoes manutencao)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Manutencoes.Add(manutencao);
				contexto.SaveChanges();
			}
		}
	}
}
