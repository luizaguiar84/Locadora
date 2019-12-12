using BsFat;
using DbKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DbFat
{
	public class UsuariosDao : IDbBanco<Usuarios>
	{

		public bool DeleteRegistro(Usuarios registro)
		{
			return new DbKernel.Db_Kernel().DeleteRegistro(registro);
		}

		public Usuarios GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public List<Usuarios> GetAll()
		{
			return new DbKernel.Db_Kernel().GetAll<Usuarios>();
			 
		}

		public bool ConfereUsuario(Usuarios usuario)
		{
			if (usuario != null)
			{
				var testaUsuario = GetAll()
				.Where(u => u.Login == usuario.Login)
				.SingleOrDefault();
				if (testaUsuario != null)
				{
					if (testaUsuario.Password == usuario.Password)
					{
						return true;
					}
				}
			}		
   		return false;
		}
		public bool ConfirmaUsuario(Usuarios usuario)
		{
			var lista = GetAll();
			foreach (var user in lista)
			{
				if (user.Login == usuario.Login)
				{
					// usuario ja existe no banco
					return false;
				}
			}
			return true;
		}
		public Usuarios GetByLogin(string login, string password)
		{
			var usuario = GetAll()
				.Where(u => (u.Login == login) && (u.Password == password))
				.SingleOrDefault();

			return usuario;
		}

		public Usuarios GetById(int usuarioId)
		{
			var usuario = GetAll()
				.Where(u => u.Id == usuarioId)
				.SingleOrDefault();

			return usuario;
		}

		public Usuarios GetUsuarioDoFuncionario(int funcionarioId)
		{
			var usuario = new FuncionariosDao().GetById(funcionarioId).Usuario;
				
				
				//GetAll()
				//.Where(u => u.FuncionariosId == funcionarioId)
				//.SingleOrDefault();

			return usuario;
		}

		public bool DbAdd(Usuarios usuario)
		{
			
			if (ConfereUsuario(usuario))
			{
				//usuario já existe no banco
				return false;
			}
			else
			{
				return new DbKernel.Db_Kernel().DbAdd<Usuarios>(usuario);
			}
			
		}

		public bool DbUpdate(Usuarios registro)
		{
			return new DbKernel.Db_Kernel().DbUpdate<Usuarios>(registro);
		}
	}
}
