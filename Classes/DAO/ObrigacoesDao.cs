using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class ObrigacoesDao
	{
		public void DbAdd(Obrigacoes obrigacao)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Obrigacoes.Add(obrigacao);
				contexto.SaveChanges();
			}
		}
	}
}
