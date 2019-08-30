using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class LocacoesDao
	{
		public void DbAdd(Locacoes locacao)
		{
			using (var context = new LocadoraContext())
			{
				context.Locacoes.Add(locacao);
				context.SaveChanges();
			}
		}

		public void DbUpdate(Locacoes locacao)
		{
			using (var context = new LocadoraContext())
			{
				context.Locacoes.Update(locacao);
				context.SaveChanges();
			}
		}
	}
}
