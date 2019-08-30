using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class AbastecimentosDao
	{
		public void DbAdd(Abastecimentos abastecimento)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Abastecimentos.Add(abastecimento);
				contexto.SaveChanges();
			}
		}
	}
}
