using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class DespesasController : Controller
    {
        // GET: Despesas
        public ActionResult Index()
        {
			//List<Despesas> despesas = new DespesasDao().GetDespesa(veiculoId);
            return View();
        }

        // GET: Despesas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Despesas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Despesas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Despesas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Despesas/Edit/5
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

        // GET: Despesas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Despesas/Delete/5
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
