using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
	public class ObrigacoesController : Controller
	{
		// GET: Obrigacoes
		public ActionResult Index()
		{
			return View();
		}

		// GET: Obrigacoes/Details/5
		public ActionResult Detalhes(int id)
		{
			var obrigacao = new ObrigacoesDao().GetById(id);
			return View(obrigacao);
		}

		// GET: Obrigacoes/Create
		public ActionResult Adicionar(int veiculoId)
		{
			ViewBag.id = veiculoId;
			return View();
		}

		// POST: Obrigacoes/Create
		[HttpPost]
		public ActionResult Adicionar(Obrigacoes obrigacao)
		{
			try
			{
				new ObrigacoesDao().DbAdd(obrigacao);
				return RedirectToAction("Index", "Veiculos");
			}
			catch
			{
				return View();
			}
		}

		// GET: Obrigacoes/Edit/5
		public ActionResult Editar(int id)
		{
			var obrigacao = new ObrigacoesDao().GetById(id);
			return View(obrigacao);
		}

		// POST: Obrigacoes/Edit/5
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

		// GET: Obrigacoes/Delete/5
		public ActionResult Deletar(int id)
		{
			var obrigacoes = new ObrigacoesDao().GetById(id);
			new ObrigacoesDao().DeleteRegistro(obrigacoes);

			return RedirectToAction("Index", "Veiculos");
		}

		// POST: Obrigacoes/Delete/5
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
