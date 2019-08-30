using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.DAO
{
	public class DespesasDao
	{
		public void DbAdd(Despesas despesa)
		{
			using (var repo = new LocadoraContext())
			{
				repo.Despesas.Add(despesa);
				repo.SaveChanges();
			}
			System.Windows.Forms.MessageBox.Show("Despesa cadastrada com sucesso!");
		}

		public void DbUpdate(Despesas despesa)
		{
			using (var repo = new LocadoraContext())
			{
				repo.Despesas.Update(despesa);
				repo.SaveChanges();
			}
			MessageBox.Show("Despesa atualizada com sucesso!");
		}

		public List<Despesas> GetDespesas()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Despesas.ToList();
			}
		}
	}
}
