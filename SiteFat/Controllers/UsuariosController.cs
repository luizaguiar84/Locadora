using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class UsuariosController : Controller
    {
		// GET: Usuarios
		public ActionResult Index()
        {
			var usuarios = new UsuariosDao().GetAll();
            return View(usuarios);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int funcionarioId)
        {
			var usuario = new UsuariosDao().GetUsuarioDoFuncionario(funcionarioId);

		 return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create(int funcionarioId)
        {
			Usuarios usuario = new UsuariosDao().GetUsuarioDoFuncionario(funcionarioId);
            return View(usuario);
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuarios usuario)
        {
			var confereUsuario = new UsuariosDao().GetById(usuario.Id);
			if (confereUsuario != null)
			{
				return View(usuario);
			}
			usuario.IsAtivo = true;

            try
            {
				if (!ModelState.IsValid)
				{
					return View(usuario);

				}
				if (new UsuariosDao().DbAdd(usuario))
				{
					return RedirectToAction("Index", "Funcionarios", "");
				}
				return View();


			}
			catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int funcionarioId)
        {
			var usuario = new UsuariosDao().GetUsuarioDoFuncionario(funcionarioId);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuarios usuario)
        {
            try
            {
				if (!ModelState.IsValid)
				{
					return View(usuario);
				}
				else
				{
					if (new UsuariosDao().DbUpdate(usuario))
					{
						return RedirectToAction("Index");
					}
					return View(usuario);
				}
            }
            catch
            {
                return View(usuario);
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
