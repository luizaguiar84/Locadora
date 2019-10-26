using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class MultasController : Controller
    {
        // GET: Multas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Multas/Details/5
        public ActionResult Detalhes(int id)
        {
			var multa = new MultasDao().GetMultaId(id);
            return View(multa);
        }

        // GET: Multas/Create
        public ActionResult Adicionar(int veiculoId)
        {
			ViewBag.Id = veiculoId;
            return View();
        }

        // POST: Multas/Create
        [HttpPost]
        public ActionResult Adicionar(Multas multa)
        {
            try
            {
				new MultasDao().DbAdd(multa);
                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Multas/Edit/5
        public ActionResult Editar(int id)
        {
			var multa = new MultasDao().GetMultaId(id);
            return View(multa);
        }

        // POST: Multas/Edit/5
        [HttpPost]
        public ActionResult Editar(Multas multa)
        {
            try
            {
				new MultasDao().DbUpdate(multa);
                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Multas/Delete/5
        public ActionResult Deletar(int id)
        {
			var multa = new MultasDao().GetMultaId(id);
            return View(multa);
        }

        // POST: Multas/Delete/5
        [HttpPost]
        public ActionResult Deletar(Multas multa)
        {
            try
            {
				new MultasDao().DeleteRegistro(multa);

                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }
    }
}
