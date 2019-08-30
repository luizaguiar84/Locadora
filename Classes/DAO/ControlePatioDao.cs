using Classes.Models;

namespace Classes.DAO
{
	public class ControlePatioDao
	{
		public void DbAdd(ControlePatio controle)
		{
			using (var repo = new LocadoraContext())
			{
				repo.ControlePatio.Add(controle);
				repo.SaveChanges();
			}
		}

		public void DbUpdate(ControlePatio controle)
		{
			using (var repo = new LocadoraContext())
			{
				repo.ControlePatio.Update(controle);
				repo.SaveChanges();
			}
		}
	}
}
