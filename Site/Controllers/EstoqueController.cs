using Dll_BS_Fat;
using Dll_DB_Fat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
			var pecaEstoque = new EstoqueDao().GetDetalhe(id);
            return View(pecaEstoque);
        }

        // GET: Estoque/Create
        public ActionResult Adicionar()
        {
            return View();
        }

        // POST: Estoque/Create
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
        public ActionResult Remover(int id)
        {
			var pecaEstoque = new EstoqueDao().GetDetalhe(id);
            return View(pecaEstoque);
        }

        // POST: Estoque/Edit/5
        [HttpPost]
        public ActionResult Remover(Estoque estoque)
        {
            try
            {
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
        public ActionResult Deletar(int id)
        {
			var pecaEstoque = new EstoqueDao().GetDetalhe(id);
            return View(pecaEstoque);
        }

        // POST: Estoque/Delete/5
        [HttpPost]
        public ActionResult Deletar(Estoque estoque)
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
