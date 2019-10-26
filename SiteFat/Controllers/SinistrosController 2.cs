using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class SinistrosController : Controller
    {
        // GET: Sinistros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sinistros/Details/5
        public ActionResult Detalhes(int id)
        {
			var sinistro = new SinistrosDao().GetSinistro(id);
            return View(sinistro);
        }

        // GET: Sinistros/Create
        public ActionResult Adicionar(int veiculoId)
        {
			ViewBag.Id = veiculoId;
			return View();
        }

        // POST: Sinistros/Create
        [HttpPost]
        public ActionResult Adicionar(Sinistros sinistro)
        {
            try
            {
				new SinistrosDao().DbAdd(sinistro);

                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sinistros/Edit/5
        public ActionResult Editar(int id)
        {
			var sinistro = new SinistrosDao().GetSinistro(id);
            return View(sinistro);
        }

        // POST: Sinistros/Edit/5
        [HttpPost]
        public ActionResult Editar(Sinistros sinistro)
        {
            try
            {
				new SinistrosDao().DbUpdate(sinistro);
                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sinistros/Delete/5
        public ActionResult Deletar(int id)
        {
			var sinistro = new SinistrosDao().GetSinistro(id);
            return View(sinistro);
        }

		// POST: Sinistros/Delete/5
		[HttpPost]
		public ActionResult Deletar(Sinistros sinistro)
		{
			try
			{
				new SinistrosDao().DeleteRegistro(sinistro);

				return RedirectToAction("Index", "Veiculos");
			}
			catch
			{
				return View();
			}
		}
	}
}
