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

		public ActionResult NovoVeiculo(Veiculos veiculo)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Adiciona(Veiculos veiculo)
		{
			try
			{
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
		public ActionResult Atualizar (Veiculos veiculo)
		{
			new VeiculosDao().DbUpdate(veiculo);

			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Deletar(Veiculos veiculo)
		{
			try
			{
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
