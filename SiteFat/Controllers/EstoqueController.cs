using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Index()
        {
			var estoque = new EstoqueDao().GetAll();
            return View(estoque);
        }

        // GET: Estoque/Details/5
        public ActionResult Detalhes(int id)
        {
			var pecaEstoque = new EstoqueDao().GetById(id);
            return View(pecaEstoque);
        }

        // GET: Estoque/Create
        public ActionResult Adicionar()
        {
            return View();
        }

		// POST: Estoque/Create
		[ValidateAntiForgeryToken]
		[HttpPost]
        public ActionResult Adicionar(Estoque estoque)
        {
            try
            {
				estoque.DataAdicao = DateTime.Now;
				new EstoqueDao().DbAdd(estoque);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estoque/Edit/5
        public ActionResult Edit(int id)
        {
			var pecaEstoque = new EstoqueDao().GetById(id);
            return View(pecaEstoque);
        }

        // POST: Estoque/Edit/5
        [HttpPost]
        public ActionResult Edit(Estoque estoque)
        {
            try
            {
				estoque.DataAdicao = DateTime.Now;
                estoque.DataSaida = DateTime.Now;

				new EstoqueDao().DbUpdate(estoque);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estoque/Delete/5
        public ActionResult Delete(int id)
        {
			var pecaEstoque = new EstoqueDao().GetById(id);
            return View(pecaEstoque);
        }

        // POST: Estoque/Delete/5
        [HttpPost]
        public ActionResult Delete(Estoque estoque)
        {
            try
            {
				new EstoqueDao().DeleteRegistro(estoque);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
