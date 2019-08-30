using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DAO
{
	public class EnderecosDao
	{
		public Enderecos DbGetEndereco(int id)
		{
			using (var contexto = new LocadoraContext())
			{
				var query = from e in contexto.Enderecos
							where id == e.Id
							select e;

				return query.Single();

			}
		}
	}
}
