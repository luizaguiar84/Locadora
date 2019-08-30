using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.DAO
{
	public class UsuariosDao
	{
		public void DbAdd(Usuarios usuario)
		{
			using (var context = new LocadoraContext())
			{
				context.Usuarios.Add(usuario);
				context.SaveChanges();
			}
			MessageBox.Show("Usuário criado com Sucesso");
		}

		public void DbUpdate(Usuarios usuario)
		{
			using (var context = new LocadoraContext())
			{
				context.Usuarios.Update(usuario);
				context.SaveChanges();
			}
			MessageBox.Show("Usuário atualizado com Sucesso");
		}

		public List<Usuarios> GetUsuarios()
		{
			using (var contexto = new LocadoraContext())
			{
				return contexto.Usuarios.ToList();
			}
		}
	}
}
