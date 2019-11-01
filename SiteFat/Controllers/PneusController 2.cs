using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class PneusController : Controller
    {
        // GET: Pneus
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pneus/Details/5
        public ActionResult Details(int id)
        {
			var pneus = new PneusDao().GetPneu(id);
            return View(pneus);
        }

        // GET: Pneus/Create
		[HttpGet]
        public ActionResult Adicionar(int veiculoId)
        {
			ViewBag.Id = veiculoId;
            return View();
        }

        // POST: Pneus/Create
        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Adicionar(Pneus pneu)
        {
			try
			{
				new PneusDao().DbAdd(pneu);

				return RedirectToAction("Index", "Veiculos");
			}
			catch
			{
				return View();
			}
		}

        // GET: Pneus/Edit/5
        public ActionResult Editar(int id)
        {
			var pneu = new PneusDao().GetPneu(id);
            return View(pneu);
        }

        // POST: Pneus/Edit/5
        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Editar(Pneus pneu)
        {
            try
            {
				new PneusDao().DbUpdate(pneu);

                return RedirectToAction("Index");
            }
			catch
            {
				return View();
            }
        }

        // GET: Pneus/Delete/5
        public ActionResult Deletar(int id)
        {
			var pneu = new PneusDao().GetPneu(id);
            return View(pneu);
        }

        // POST: Pneus/Delete/5
        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Deletar(Pneus pneu)
        {
            try
            {
				new PneusDao().DeleteRegistro(pneu);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
