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
			var pneus = new PneusDao().GetPneuUnico(id);
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pneus/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pneus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pneus/Delete/5
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
