using BsFat;
using DbFat;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Alugar()
		{
			var model = new List<Veiculos>();
			var veiculos = new VeiculosDao().GetAll()
							.Where(v => v.IsAtivo)
							.ToList(); //busca os veiculos ativos no BD
			veiculos.ForEach(v => model.Add(v)); //adiciona os veiculos na variavel model
			model.Sort(); // deixa em ordem alfabética pelo modelo
			return View(model);
		}

		public ActionResult Servicos()
		{
			return View();
		}
	}
}