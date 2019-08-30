using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class MultasDao
	{
		public void DbAdd(Multas multa)
		{
			using (var contexto = new LocadoraContext())
			{
				contexto.Multas.Add(multa);
				contexto.SaveChanges();
			}
		}
	}
}
