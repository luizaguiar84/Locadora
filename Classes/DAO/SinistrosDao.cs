using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class SinistrosDao
	{
		public void DbAdd(Sinistros sinistro)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Sinistros.Add(sinistro);
				contexto.SaveChanges();
			}
		}
	}
}
