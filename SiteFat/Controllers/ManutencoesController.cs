using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class ManutencoesController : Controller
    {
        // GET: Manutencoes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Manutencoes/Details/5
        public ActionResult Detalhes(int id)
        {
			var obrigacao = new ObrigacoesDao().GetById(id);
            return View(obrigacao);
        }

        // GET: Manutencoes/Create
        public ActionResult Adicionar(int veiculoId)
        {
			ViewBag.Id = veiculoId;
            return View();
        }

        // POST: Manutencoes/Create
        [HttpPost]
        public ActionResult Adicionar(Manutencoes manutencao)
        {
            try
            {
				new ManutencoesDao().DbAdd(manutencao);

                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manutencoes/Edit/5
        public ActionResult Editar(int id)
        {
			var obrigacao = new ObrigacoesDao().GetById(id);
            return View(obrigacao);
        }

        // POST: Manutencoes/Edit/5
        [HttpPost]
        public ActionResult Editar(Obrigacoes obrigacao)
        {
            try
            {
				new ObrigacoesDao().DbUpdate(obrigacao);

                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manutencoes/Delete/5
        public ActionResult Deletar(int id)
        {
			var obrigacao = new ObrigacoesDao().GetById(id);
            return View(obrigacao);
        }

        // POST: Manutencoes/Delete/5
        [HttpPost]
        public ActionResult Deletar(Obrigacoes obrigacao)
        {
            try
            {
				new ObrigacoesDao().DeleteRegistro(obrigacao);

                return RedirectToAction("Index", "Veiculos");
            }
            catch
            {
                return View();
            }
        }
    }
}
