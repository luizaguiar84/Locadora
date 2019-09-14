using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class HomeController : Controller
    {
		List<Veiculos> model;

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Alugar()
		{
			model = new List<Veiculos>();
			var veiculos = new VeiculosDao().GetAll();
			foreach (var veiculo in veiculos)
			{
				model.Add(veiculo);
			}
			return View(model);
		}

		public ActionResult Servicos()
		{
			return View();
		}
	}
}