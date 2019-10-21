using Dll_BS_Fat;
using Dll_Db_Kernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dll_DB_Fat
{
	public class UsuariosDao : IDbBanco<Usuarios>
	{

		public bool DeleteRegistro(Usuarios registro)
		{
			return new DbKernel().DeleteRegistro(registro);
		}

		public Usuarios GetRegistroPorCodigo(int classeId, string registro)
		{
			throw new NotImplementedException();
		}

		public List<Usuarios> GetAll()
		{
			return new DbKernel().GetAll<Usuarios>();
			 
		}

		public bool ConfereUsuario(Usuarios usuario)
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
			return false;
		}

		public Usuarios GetUsuario(int id)
		{
			var usuario = GetAll()
				.Where(u => u.Id == id)
				.SingleOrDefault();
			usuario.Funcionario = new FuncionariosDao().GetFuncionario(usuario.FuncionariosId);

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
				return new DbKernel().DbAdd<Usuarios>(usuario);
			}
			
		}

		public bool DbUpdate(Usuarios registro)
		{
			return new DbKernel().DbUpdate<Usuarios>(registro);
		}
	}
}
