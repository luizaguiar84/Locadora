using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.DAO
{
	public class TipoDespesaDao
	{
		public void DbAdd(TipoDespesa tipo)
		{
			using (var context = new LocadoraContext())
			{
				context.TipoDespesa.Add(tipo);
				context.SaveChanges();
			}

		}

		public void DbAddTipo(TipoDespesa tipo)
		{

			using (var context = new LocadoraContext())
			{
				bool existe = false;

				var tipos = context.TipoDespesa.ToList();

				foreach (var t in tipos)
				{
					if (tipo.Tipo == t.Tipo)
					{
						existe = true;
					}
				}
				if (!existe)
				{
					DbAdd(tipo);
				}
				else
				{
					MessageBox.Show("Tipo de despesa já cadastrado.");
				}
			}
		}
		public List<TipoDespesa> GetTipoDespesas()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.TipoDespesa.ToList();
			}
		}
	}
}
