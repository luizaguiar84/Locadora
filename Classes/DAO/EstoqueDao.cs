using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class EstoqueDao
	{
		public void DbAdd(Estoque estoque)
		{
			using (var repo = new LocadoraContext())
			{
				repo.Estoque.Add(estoque);
				repo.SaveChanges();
			}
		}

		public void DbUpdate(Estoque estoque)
		{
			using (var repo = new LocadoraContext())
			{
				repo.Estoque.Update(estoque);
				repo.SaveChanges();
			}
		}

		public List<Estoque> GetEstoque()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Estoque.ToList();
			}
		}
	}
}
