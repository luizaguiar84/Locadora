using Classes.Models;
using System.Linq;

namespace Classes.DAO
{
	public class CnhsDao
	{
		public Cnhs DbGetCnh(int id)
		{
			using (LocadoraContext contexto = new LocadoraContext())
			{
				var query = from c in contexto.Cnhs
							where id == c.Id
							select c;

				return query.Single();
			}
		}
	}
}
