using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
	public class VeiculosController : Controller
	{
		// GET: Veiculos
		public ActionResult Index()
		{
			List<Veiculos> lista = new VeiculosDao().GetAll();
			return View(lista);
		}
		public ActionResult NovoVeiculo()
		{
			var veiculo = new Veiculos();
			return View(veiculo);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Adiciona(Veiculos veiculo)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(veiculo);
				}
				veiculo.IsAtivo = true;
				new VeiculosDao().DbAdd(veiculo);
				return RedirectToAction("Index");
			}
			catch (Exception)
			{

				return View();
			}
		}

		public ActionResult Reserva(int id)
		{
			var veiculo = new VeiculosDao().GetVeiculo(id);

			return View(veiculo);
		}

		public ActionResult Deletar(int id)
		{
			var veiculo = new VeiculosDao().GetVeiculo(id);


			return View(veiculo);
		}


		public ActionResult Editar(int id)
		{
			var veiculo = new VeiculosDao().GetVeiculo(id);

			return View(veiculo);
		}
		public ActionResult Atualizar(Veiculos veiculo)
		{
			veiculo.IsAtivo = true;
			new VeiculosDao().DbUpdate(veiculo);

			return RedirectToAction("Index");
		}
		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Deletar(Veiculos veiculo)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(veiculo);
				}
				new VeiculosDao().DeleteRegistro(veiculo);

				return RedirectToAction("Index", "Veiculos");
			}
			catch
			{
				return View();
			}
		}
	}
}
