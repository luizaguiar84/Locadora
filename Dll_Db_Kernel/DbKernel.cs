using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_Db_Kernel
{
	public class DbKernel
	{
		public bool DbAdd<T>(T registro) where T : class
		{
			bool retorno = false;
			using (var contexto = new LocadoraContext())
			{
				try
				{
					contexto.Set<T>().Add(registro);
					contexto.SaveChanges();
					retorno = true;
				}
				catch (Exception ex)
				{
					string err = ex.Message;
				}
				return retorno;
			}
		}

		public bool DbUpdate<T>(T registro) where T : class
		{
			bool retorno = false;
			using (var contexto = new LocadoraContext())
			{
				try
				{
					contexto.Set<T>().Update(registro);
					contexto.SaveChanges();
					retorno = true;
				}
				catch (Exception ex)
				{
					string err = ex.Message;
				}
				return retorno;
			}
		}

		public List<T> GetAll<T>() where T : class
		{
			using (var contexto = new LocadoraContext())
			{
				try
				{
					return contexto.Set<T>().ToList();
				}
				catch (Exception ex)
				{

					string err = ex.Message;
				}
				return null;
			}
		}

		public bool DeleteRegistro<T>(T registro) where T : class
		{
			bool ret = false;
			using (var contexto = new LocadoraContext())
			{
				try
				{
					contexto.Set<T>().Remove(registro);
					contexto.SaveChanges();
					ret = true;
					return ret;
				}
				catch (Exception ex)
				{
					string err = ex.Message;
				}
				return ret;
			}
		}

		public T GetRegistroPorCodigo<T>(int idClasse, string idBuscado) where T : class
		{
			if (idBuscado != "")
			{
				using (var contexto = new LocadoraContext())
				{
					int id = Convert.ToInt32(idBuscado);

					var retornoId = contexto.Set<T>()
								.Where(c => idClasse == id)
									.Single();
					return retornoId;
				}
			}
			return null;
		}
	}
}
