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
			var dao = new VeiculosDao();
			var funcionou = dao.DbAdd(veiculo);
			return RedirectToAction("Index");
		}

		public ActionResult Reserva(int id)
		{
			var veiculo = new VeiculosDao().GetAll()
				.Where(v => v.Id == id)
				.SingleOrDefault();

			return View(veiculo);
		}
	}
}
